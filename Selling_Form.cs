


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace supermarket_mangement_system
{
    public partial class Selling_Form : Form
    {
        //private DataGridView prodDGV;
        private PrintDocument printDocument = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
        public Selling_Form()
        {
            InitializeComponent();
            LoadProductData();

            ConfigurePrintPreviewDialog();
            populate();
            // Assign the PrintPage event handler
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            // Set the Document for the PrintPreviewDialog
            printPreviewDialog.Document = printDocument;

            // Assign the Load event handler for the PrintPreviewDialog
            // Note: It's better not to use the Load event for showing the PrintPreviewDialog
            // PrintPreviewDialog.Load += new EventHandler(PrintPreviewDialog_Load);

            Brushers = new object();
            // InitializeCustomComponents();
        }
        SqlConnection Con = new SqlConnection(@" Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Ehtisham\Downloads\supermarket_mangement_system\supermarket_mangement_system\SMMS.mdf; Integrated Security = True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fillCategory()
        {
            //This Method will bind the Combobox with the Database
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoriesTable", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            //cbSearchcategory.ValueMember = "CatName";
            //cbSearchcategory.DataSource = dt;
            cbselectcategory.ValueMember = "CatName";
            cbselectcategory.DataSource = dt;
            Con.Close();
        }
        private void Selling_Form_Load_1(object sender, EventArgs e)
        {



            populate();
            populatebills();
            fillCategory();
            lBname.Text = Login.SellerName;
            LoadProductData();

        }

        private void lbPRICE_Click(object sender, EventArgs e)
        {

        }

        private void TextProductName_TextChanged(object sender, EventArgs e)
        {

        }



        private void populate()
        {
            try
            {
                Con.Open();
                //this.con.Open();
                string query = "select ProdName,ProdQty,ProdPrice from ProductsTable;";
                SqlDataAdapter sda = new SqlDataAdapter(query, this.Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                prodDGV.DataSource = ds.Tables[0];
                // Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (this.Con.State == ConnectionState.Open)
                    this.Con.Close();
            }
        }


        private void populatebills()
        {
            try
            {
                Con.Open();
                //this.con.Open();
                string query = "select * from BillsTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, this.Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                BillsDGV.DataSource = ds.Tables[0];
                // Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (this.Con.State == ConnectionState.Open)
                    this.Con.Close();

            }

        }
        private void LoadProductData()
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ehtisham\Downloads\supermarket_mangement_system\supermarket_mangement_system\SMMS.mdf;Integrated Security=True"))
                {
                    Con.Open();
                    string query = "select ProdName,ProdQty,ProdPrice from ProductsTable where ProdCat='" + cbselectcategory.SelectedValue + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    prodDGV.DataSource = ds.Tables[0];
                    Con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (this.Con.State == ConnectionState.Open)
                    this.Con.Close();

                //throw new NotImplementedException();
            }
            /*try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ehtisham\Downloads\supermarket_mangement_system\supermarket_mangement_system\SMMS.mdf;Integrated Security=True"))
                {
                    con.Open();
                    string query = "SELECT ProdName, ProdQty,ProdPrice FROM ProductsTable WHERE ProdCat = @ProdCat";
                    using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                    {
                        sda.SelectCommand.Parameters.AddWithValue("@ProdCat", cbselectcategory.SelectedItem?.ToString() ?? string.Empty);
                        var ds = new DataSet();
                        sda.Fill(ds);
                        prodDGV.DataSource = ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
        private void cbselectcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProductData();

            /*


              try
               {
                    using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ehtisham\Downloads\supermarket_mangement_system\supermarket_mangement_system\SMMS.mdf;Integrated Security=True"))
                   {
                   Con.Open();
                   string query = "select ProdName,ProdQty,ProdPrice from ProductsTable where ProdCat='" + cbselectcategory + "'";
                   SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                   SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                   var ds = new DataSet();
                   sda.Fill(ds);
                   prodDGV.DataSource = ds.Tables[0];
                   //Con.Close();

               }
            }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message);
               }
            finally
               {
                   if (this.Con.State == ConnectionState.Open)
                       this.Con.Close();

                   //throw new NotImplementedException();
               }*/
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            lbdate.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();

        }

        private void prodDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (prodDGV.SelectedRows.Count > 0)
            {
                var selectedRow = prodDGV.SelectedRows[0];
                if (selectedRow.Cells[0].Value != null)
                {
                    txtProductName.Text = selectedRow.Cells[0].Value.ToString();
                }
                if (selectedRow.Cells[1].Value != null)
                {
                    txtProductPrice.Text = selectedRow.Cells[1].Value.ToString();
                }
            }

        }


        int Grdtotal = 0, n = 0;




        private void btnAddproduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
                string.IsNullOrWhiteSpace(txtProductQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtProductPrice.Text))
            {
                MessageBox.Show("Missing information");
                return;
            }

            int total = Convert.ToInt32(txtProductPrice.Text) * Convert.ToInt32(txtProductQuantity.Text);
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(orderDGV);
            newRow.Cells[0].Value = n + 1;
            newRow.Cells[1].Value = txtProductName.Text;
            newRow.Cells[2].Value = txtProductQuantity.Text;
            newRow.Cells[3].Value = txtProductPrice.Text;
            newRow.Cells[4].Value = total;
            orderDGV.Rows.Add(newRow);
            n++;
            Grdtotal += total;
            lbamount.Text = Grdtotal.ToString();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (txtBillID.Text == "")
            {
                MessageBox.Show("Select the Bill to Delete");
                return;
            }
            else
            {

                try
                {
                    using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ehtisham\Downloads\supermarket_mangement_system\supermarket_mangement_system\SMMS.mdf;Integrated Security=True"))
                    {
                        Con.Open();
                        string query = "DELETE FROM BillsTbl WHERE BillId = @BillId";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.Parameters.AddWithValue("@BillId", txtBillID.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Bill Deleted Successfully");
                        populatebills();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SQL Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (Con.State == ConnectionState.Open)
                        Con.Close();
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBillID.Text) ||
                string.IsNullOrWhiteSpace(lBname.Text) ||
                string.IsNullOrWhiteSpace(lbdate.Text) ||
                string.IsNullOrWhiteSpace(lbamount.Text))
            {
                MessageBox.Show("Missing Bill Information");
                return;
            }

            try
            {

                using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ehtisham\Downloads\supermarket_mangement_system\supermarket_mangement_system\SMMS.mdf;Integrated Security=True"))
                {
                    /* int BillId = Convert.ToInt32(txtBillID.Text);
                     String SellerName = lBname.Text;
                     String BillDate = lbdate.Text;
                     int TotalAmount = Convert.ToInt32(lbamount.Text);*/

                    Con.Open();
                    string query = "INSERT INTO dbo.BillsTbl VALUES (" + txtBillID.Text + ", '" + lBname.Text + "', '" + lbdate.Text + "', '" + lbamount.Text + "')";
                    // string query = "INSERT INTO BillsTbl (BillId, SellerName, BillDate, TotalAmount) VALUES (@BillId, @SellerName, @BillDate, @TotalAmount);";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@BillId", Convert.ToInt32(txtBillID.Text));
                    cmd.Parameters.AddWithValue("@SellerName", lBname.Text);
                    cmd.Parameters.AddWithValue("@BillDate", lbdate.Text);
                    cmd.Parameters.AddWithValue("@TotalAmount", Convert.ToInt32(lbamount.Text));

                    /*  cmd.Parameters.AddWithValue("@BillId", BillId);
                      cmd.Parameters.AddWithValue("@SellerName", SellerName);
                      cmd.Parameters.AddWithValue("@BillDate", BillDate);
                      cmd.Parameters.AddWithValue("@TotalAmount", TotalAmount);*/
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added successfully");
                    populatebills();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General Error: {ex.Message}");
            }

            finally
            {
                if (Con.State == ConnectionState.Open)
                    //Con.Close();
                    // populatebills();
                    Con.Close();
            }

            // populatebills();
        }













        //  public DataGridView orderDGV { get; private set; }

        public object Brushers { get; private set; }

        private void ConfigurePrintPreviewDialog()
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Load += new EventHandler(printPreviewDialog_Load);
        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (e.Graphics != null)
            {
                if (BillsDGV.SelectedRows.Count > 0)
                {
                    var selectedRow = BillsDGV.SelectedRows[0];

                    if (selectedRow.Cells.Count >= 4) // Ensure there are at least 4 cells
                    {
                        e.Graphics.DrawString("Azeem SuperMarket", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230, 30));
                        e.Graphics.DrawString("Bill ID: " + selectedRow.Cells[0].Value?.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(70, 100));
                        e.Graphics.DrawString("Seller Name: " + selectedRow.Cells[1].Value?.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(70, 140));
                        e.Graphics.DrawString("Bill Date: " + selectedRow.Cells[2].Value?.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(70, 180));
                        e.Graphics.DrawString("Total Amount: " + selectedRow.Cells[3].Value?.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(70, 220));
                        e.Graphics.DrawString("Azeem Technology", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230, 260));
                    }
                    else
                    {
                        MessageBox.Show("Error: The selected row does not contain enough data to print.", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error: No row selected for printing.", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error: Unable to access the graphics object for printing.", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printPreviewDialog_Load(object sender, EventArgs e)
        {


            // No need to handle visibility here
        }
        /*  private void printPreviewDialog_Load(object sender, EventArgs e)
          {
              if (printPreviewDialog.ShowDialog() == DialogResult.OK)
              {
                  printDocument.Print();
              }
          }*/




        private void btnrefresh_Click(object sender, EventArgs e)
        {


            txtBillID.Text = "";
            txtProductName.Text = "";
            txtProductQuantity.Text = "";
            txtProductPrice.Text = "";
            // populate();
        }

        private void BillsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void orderDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void SELLERS_Click(object sender, EventArgs e)
        {
            SELLER_Form Sell = new SELLER_Form();

            Sell.Show();

            this.Hide();
        }

        private void bTNCATEGORIES_Click(object sender, EventArgs e)
        {
            Category Cat = new Category();
            Cat.Show();
            this.Hide();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            prod.Show();
            this.Hide();
        }

        private void lBname_Click(object sender, EventArgs e)
        {

        }




        private void cbselectcategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                // Con.Open();
                string query = "select ProdName,ProdQty from ProductsTable where ProdCat='" + cbselectcategory + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                prodDGV.DataSource = ds.Tables[0];
                //Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void btnprint_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in BillsDGV
            if (BillsDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a bill to print.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hide the current form to prevent the modal dialog error
            this.Visible = false;

            try
            {
                // Show the print preview dialog
                printPreviewDialog.ShowDialog();
            }
            finally
            {
                // Make the current form visible again after closing the print preview dialog
                this.Visible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
    
















