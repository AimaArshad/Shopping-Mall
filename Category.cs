
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
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace supermarket_mangement_system
{
    public partial class Category : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Ehtisham\Downloads\supermarket_mangement_system\supermarket_mangement_system\SMMS.mdf;Integrated Security =True");
        private DataGridView CategoriesDGV;
        public Category()
        {
            InitializeComponent();
            CategoriesDGV = dataGridView1;
            populate();
        }
        //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ehtisham\OneDrive\Desktop\VP\supermarket_mangement_system\supermarket_mangement_system\SMMS.mdf;Integrated Security=True");

        //public object CategoriesDGV { get; private set; }

        //  SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ehtisham\OneDrive\Desktop\VP\supermarket_mangement_system\supermarket_mangement_system\SMMS.mdf;Integrated Security=True");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }


        private void txtCategoryDesc_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnSellers_Click(object sender, EventArgs e)
        {
            SELLER_Form Sell = new SELLER_Form();

            Sell.Show();

            this.Hide();
        }


        private void populate()
        {
            try
            {
                //this.con.Open();
                string query = "select * from CategoriesTable";
                SqlDataAdapter sda = new SqlDataAdapter(query, this.con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                CategoriesDGV.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (this.con.State == ConnectionState.Open)
                    this.con.Close();
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ehtisham\Downloads\supermarket_mangement_system\supermarket_mangement_system\SMMS.mdf;Integrated Security=True"))
                {

                    Con.Open();
                    string query = "Insert into CategoriesTable values(" + txtCategoryID.Text + " ,'" + txtCategoryName.Text + "','" + txtCategoryDesc.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Added Successfully");

                    populate();
                    txtCategoryID.Text = "";
                    txtCategoryName.Text = "";
                    txtCategoryDesc.Text = "";
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /*  private void btnClose_Click(object sender, EventArgs e)
          {

              Application.Exit();
          }*/


        private void Category_Load(object sender, EventArgs e)
        {
            populate();
        }

        /*
  private void CategoriesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
           {
               txtCategoryID.Text = CategoriesDGV.SelectedRows[0].Cells[0].Value.ToString();
               txtCategoryName.Text = CategoriesDGV.SelectedRows[0].Cells[1].Value.ToString();
               txtCategoryDesc.Text = CategoriesDGV.SelectedRows[0].Cells[2].Value.ToString();
           }
         */


        private void CategoriesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CategoriesDGV.Rows[e.RowIndex];
                txtCategoryID.Text = row.Cells[0].Value.ToString();
                txtCategoryName.Text = row.Cells[1].Value.ToString();
                txtCategoryDesc.Text = row.Cells[2].Value.ToString();
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ehtisham\Downloads\supermarket_mangement_system\supermarket_mangement_system\SMMS.mdf;Integrated Security=True"))
                {
                    Con.Open();

                    string categoryIDText = txtCategoryID.Text;
                    string categoryName = txtCategoryName.Text;
                    string categoryDesc = txtCategoryDesc.Text;

                    if (string.IsNullOrEmpty(categoryIDText) || string.IsNullOrEmpty(categoryName) || string.IsNullOrEmpty(categoryDesc))
                    {
                        MessageBox.Show("Please fill all fields.");
                        return;
                    }

                    if (!int.TryParse(categoryIDText, out int categoryID))
                    {
                        MessageBox.Show("Invalid Category ID. Please enter a valid integer.");
                        return;
                    }

                    string query = "UPDATE CategoriesTable SET CatName = @CatName, CatDesc = @CatDesc WHERE CatID = @CatID";
                    SqlCommand cmd2 = new SqlCommand(query, Con);

                    // Using parameters to prevent SQL injection
                    cmd2.Parameters.AddWithValue("@CatID", categoryID);
                    cmd2.Parameters.AddWithValue("@CatName", categoryName);
                    cmd2.Parameters.AddWithValue("@CatDesc", categoryDesc);

                    int rowsAffected = cmd2.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Category Updated Successfully");
                        populate();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Please check the Category ID.");
                    }

                    Con.Close();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }









        private void ClearFields()
        {
            txtCategoryID.Text = "";
            txtCategoryName.Text = "";
            txtCategoryDesc.Text = "";
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ehtisham\Downloads\supermarket_mangement_system\supermarket_mangement_system\SMMS.mdf;Integrated Security=True"))
                {
                    Con.Open();

                    string categoryIDText = txtCategoryID.Text;

                    if (string.IsNullOrEmpty(categoryIDText))
                    {
                        MessageBox.Show("Please enter a Category ID.");
                        return;
                    }

                    if (!int.TryParse(categoryIDText, out int categoryID))
                    {
                        MessageBox.Show("Invalid Category ID. Please enter a valid integer.");
                        return;
                    }

                    string query = "DELETE FROM CategoriesTable WHERE CatID = @CatID";
                    SqlCommand cmd = new SqlCommand(query, Con);

                    // Using parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@CatID", categoryID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Category Deleted Successfully");
                        populate();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Delete failed. Please check the Category ID.");
                    }

                    Con.Close();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtCategoryID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            Selling_Form sell = new Selling_Form();

            sell.Show();

            this.Hide();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Product Prod = new Product();

            Prod.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}








































































































  



























































































