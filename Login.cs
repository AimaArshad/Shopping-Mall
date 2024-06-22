using supermarket_mangement_system.Properties;
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
using System.Diagnostics.Eventing.Reader;
namespace supermarket_mangement_system
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ehtisham\Downloads\supermarket_mangement_system\supermarket_mangement_system\SMMS.mdf;Integrated Security=True");

        public static string SellerName = ""; 

        private void Login_Load(object sender, EventArgs e)
        {

        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbSelectRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
/*
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter username and Password");
            }
            else
            {
                if (cbSelectRole.SelectedIndex > -1)
                {
                    if (cbSelectRole.SelectedItem.ToString() == "Admin")
                    {
                        if (txtUsername.Text == "Admin" && txtPassword.Text == "Admin")
                        {
                            Product Prod = new Product();
                            Prod.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If you are Admin,Enter the Correct Username and Password");
                        }
                    }
                    else
                    {
                        //MessageBox.Show("you are in Seller section");
                        Con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from SellersTbl where SellerName='" + txtUsername.Text + "' and SellerPassword='" + txtPassword.Text + "'", Con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            SellerName = txtUsername.Text;
                            Selling_Form sell = new Selling_Form();
                            sell.Show(); this.Hide();
                            Con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Username and Password");

                        }
                        Con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Select the Role to login");
                }
            }
        }*/


        
         private void btnLogin_Click(object sender, EventArgs e)
{
    if (txtUsername.Text == "" || txtPassword.Text == "")
    {
        MessageBox.Show("Please enter username and Password");
    }
    else
    {
        if (cbSelectRole.SelectedIndex > -1)
        {
            if (cbSelectRole.SelectedItem.ToString() == "Admin")
            {
                        Con.Open();
                if (txtUsername.Text == "Admin" && txtPassword.Text == "Admin")
                {
                    Product Prod = new Product();
                    Prod.Show();
                    this.Hide();
                     Con.Close();
                }
                else
                {
                    MessageBox.Show("If you are Admin,Enter the Correct Username and Password");
                    Con.Close();
                        }
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from SellersTbl where SellerName=@SellerName and SellerPassword=@SellerPassword", Con);
                    sda.SelectCommand.Parameters.AddWithValue("@SellerName", txtUsername.Text);
                    sda.SelectCommand.Parameters.AddWithValue("@SellerPassword", txtPassword.Text);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        SellerName = txtUsername.Text;
                        Selling_Form sell = new Selling_Form();
                        sell.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username and Password");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
        }
        else
        {
            MessageBox.Show("Select the Role to login");
        }
    }
}

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
        }
    }
}
