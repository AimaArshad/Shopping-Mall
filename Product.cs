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
//using static System.Net.Mime.MediaTypeNames;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace supermarket_mangement_system
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            //ProductsDGV = dataGridView;
            // populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ehtisham\Downloads\supermarket_mangement_system\supermarket_mangement_system\SMMS.mdf;Integrated Security=True");
        //private DataGridView ProductsDGV;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cbselectcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Con.Open();
                string query = "select * from ProductsTable where ProdCat='" + cbSearchcategory + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                ProductsDGV.DataSource = ds.Tables[0];
                // Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void FillCategory()
        {


            // This Method will bind the Combobox with the Database
            if (cbSearchcategory == null)
            {
                MessageBox.Show("cbSearchcategory is not properly initialized.");
                return;
            }
            if (cbselectcategory == null)
            {
                MessageBox.Show("cbselectcategory is not properly initialized.");
                return;
            }
            //This Method will bind the Combobox with the Database
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoriesTable", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            cbSearchcategory.ValueMember = "CatName";
            cbSearchcategory.DataSource = dt;
            cbselectcategory.ValueMember = "CatName";
            cbselectcategory.DataSource = dt;
            Con.Close();
        }
        /* private void populate()
         {
             Con.Open();
             string query = "select * from ProductsTbl";
             SqlDataAdapter sda = new SqlDataAdapter(query, Con);
             SqlCommandBuilder builder = new SqlCommandBuilder(sda);
             var ds = new DataSet();
             sda.Fill(ds);
             ProductsDGV.DataSource = ds.Tables[0];
             Con.Close();
         }*/

        private void populate()
        {
            try
            {
                //this.con.Open();
                string query = "select * from ProductsTable";
                SqlDataAdapter sda = new SqlDataAdapter(query, this.Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                ProductsDGV.DataSource = ds.Tables[0];
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

        private void Product_Load(object sender, EventArgs e)
        {

            if (cbSearchcategory == null)
            {
                MessageBox.Show("cbSearchcategory is not properly initialized.");
                return;
            }
            if (cbselectcategory == null)
            {
                MessageBox.Show("cbselectcategory is not properly initialized.");
                return;
            }
            FillCategory();
            populate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        /*
        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ehtisham\OneDrive\Desktop\VP\supermarket_mangement_system\supermarket_mangement_system\SMMS.mdf;Integrated Security=True"))
                {

                    Con.Open();

                    string query = "insert into ProductsTable values(" + txtProductID.Text + ",'" + TxtProductName.Text + "', " + TxtProductQuantity.Text + "," + TxtProductPrice.Text + ",'" + cbselectcategory.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Added Successfully");

                    Con.Close();
                    populate();
                    txtProductID.Text = "";
                    TxtProductName.Text = "";
                    TxtProductQuantity.Text = "";
                    TxtProductPrice.Text = "";
                  // Con.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }*/



        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtProductID.Text = "";
            TxtProductName.Text = "";
            TxtProductQuantity.Text = "";
            TxtProductPrice.Text = "";
        }

        private void ProductsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                // DataGridViewRow row = ProductsDGV.Rows[e.RowIndex];
                txtProductID.Text = ProductsDGV.SelectedRows[0].Cells[0].Value.ToString();
                TxtProductName.Text = ProductsDGV.SelectedRows[0].Cells[1].Value.ToString();
                TxtProductQuantity.Text = ProductsDGV.SelectedRows[0].Cells[2].Value.ToString();
                TxtProductPrice.Text = ProductsDGV.SelectedRows[0].Cells[3].Value.ToString();
                cbselectcategory.Text = ProductsDGV.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductID.Text == "" || TxtProductName.Text == "" || TxtProductQuantity.Text == ""
            || TxtProductPrice.Text == "")

                {

                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();
                    // string query = "Update ProductsTable set ProdName='" + TxtProductName.Text + "' ProdQty=" + TxtProductQuantity.Text + ", ProdPrice=" + TxtProductPrice.Text + " , ProdCat='" + cbselectcategory.SelectedValue.ToString() + "' where ProdId=" + txtProductID.Text + ";";
                    string query = "Update ProductsTable set ProdName='" + TxtProductName.Text + "', ProdQty=" + TxtProductQuantity.Text + ", ProdPrice=" + TxtProductPrice.Text + ", ProdCat='" + cbselectcategory + "' where ProdId=" + txtProductID.Text + ";";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Successfully updated");
                    // Con.Close();
                    populate();
                    txtProductID.Text = "";
                    TxtProductName.Text = "";
                    TxtProductQuantity.Text = "";
                    TxtProductPrice.Text = "";
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductID.Text == "")
                {
                    MessageBox.Show("Select the Product to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete  from ProductsTable where ProdId=" + txtProductID.Text + "";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product deleted successfully");
                    // Con.Close();
                    populate();
                    txtProductID.Text = "";
                    TxtProductName.Text = "";
                    TxtProductQuantity.Text = "";
                    TxtProductPrice.Text = "";
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }



        private void btnSelling_Click_1(object sender, EventArgs e)
        {
            Selling_Form sell = new Selling_Form();
            sell.Show();
            this.Hide();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            Category Cat = new Category();
            Cat.Show();
            this.Hide();
        }

        private void btnSellers_Click(object sender, EventArgs e)
        {
            SELLER_Form Sell = new SELLER_Form();
            Sell.Show();
            this.Hide();
        }

        /*private void btnClose_Click(object sender, EventArgs e)
        {
            this.Application.Exit();
        }*/



        /* private void btnClose_Click(object sender, EventArgs e)
         {
             Application.Exit();
        }*/

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ehtisham\Downloads\supermarket_mangement_system\supermarket_mangement_system\SMMS.mdf;Integrated Security=True"))
                {
                    Con.Open();
                    string query = "INSERT INTO dbo.ProductsTable (ProdId, ProdName, ProdQty, ProdPrice, ProdCat) VALUES (@ProdId, @ProdName, @ProdQty, @ProdPrice, @ProdCat)";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@ProdId", txtProductID.Text);
                    cmd.Parameters.AddWithValue("@ProdName", TxtProductName.Text);
                    cmd.Parameters.AddWithValue("@ProdQty", TxtProductQuantity.Text);
                    cmd.Parameters.AddWithValue("@ProdPrice", TxtProductPrice.Text);
                    cmd.Parameters.AddWithValue("@ProdCat", cbselectcategory.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Added Successfully");

                    populate();
                    txtProductID.Text = "";
                    TxtProductName.Text = "";
                    TxtProductQuantity.Text = "";
                    TxtProductPrice.Text = "";
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}














































