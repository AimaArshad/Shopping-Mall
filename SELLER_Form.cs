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
using System.Runtime.ConstrainedExecution;

namespace supermarket_mangement_system
{
    public partial class SELLER_Form : Form
    {
        public SELLER_Form()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ehtisham\Downloads\supermarket_mangement_system\supermarket_mangement_system\SMMS.mdf;Integrated Security=True");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
      

        private void textProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Product Prod = new Product();
            Prod.Show();
            this.Hide();
        }

        private void btncategory_Click(object sender, EventArgs e)
        {
            Category Cat = new Category();
            Cat.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)

        {
            this.Hide();
            Form login = new Form1();
            login.Show();
        }

        private void btnselling_Click(object sender, EventArgs e)
        {
            Selling_Form sell = new Selling_Form();
            sell.Show();
            this.Hide();
        }

        private void populate()
        {
            string query = "select  * from SellersTbl";
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SellersDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SELLER_Form_Load(object sender, EventArgs e)
        {

            populate();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ehtisham\Downloads\supermarket_mangement_system\supermarket_mangement_system\SMMS.mdf;Integrated Security=True"))
                {
                    Con.Open();
                    string query = "INSERT INTO dbo.SellersTbl (SellerId, SellerName, SellerAge, SellerMobileNo, SellerPassword) VALUES (@SellerId, @SellerName, @SellerAge, @SellerMobileNo, @SellerPassword)";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@SellerId", txtSellerID.Text);
                    cmd.Parameters.AddWithValue("@SellerName", txtSellerName.Text);
                    cmd.Parameters.AddWithValue("@SellerAge", txtSellerAge.Text);
                    cmd.Parameters.AddWithValue("@SellerMobileNo", txtSellerMobileNo.Text);
                    cmd.Parameters.AddWithValue("@SellerPassword", txtSellerPassword.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Added Successfully");
                    Con.Close();
                    populate();
                    txtSellerID.Text = "";
                    txtSellerName.Text = "";
                    txtSellerAge.Text = "";
                    txtSellerPassword.Text = "";
                    txtSellerMobileNo.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*
        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ehtisham\OneDrive\Desktop\VP\supermarket_mangement_system\supermarket_mangement_system\SMMS.mdf;Integrated Security=True"))
                {

                    Con.Open();

                    string query = "insert into SellersTbl values(" + txtSellerID.Text + ",'" + txtSellerName.Text + "', '" + txtSellerAge.Text + "'," + txtSellerMobileNo.Text + ",'" + txtSellerPassword.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Added Successfully");


                    populate();

                    txtSellerID.Text = "";
                    txtSellerName.Text = "";
                    txtSellerAge.Text = "";
                    txtSellerPassword.Text = "";
                    txtSellerMobileNo.Text = "";
                    Con.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }*/

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSellerID.Text == "" || txtSellerName.Text == "" || txtSellerAge.Text == "" || txtSellerMobileNo.Text == "" || txtSellerPassword.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "UPDATE dbo.SellersTbl SET SellerName=@SellerName, SellerAge=@SellerAge, SellerMobileNo=@SellerMobileNo, SellerPassword=@SellerPassword WHERE SellerId=@SellerId";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@SellerId", txtSellerID.Text);
                    cmd.Parameters.AddWithValue("@SellerName", txtSellerName.Text);
                    cmd.Parameters.AddWithValue("@SellerAge", txtSellerAge.Text);
                    cmd.Parameters.AddWithValue("@SellerMobileNo", txtSellerMobileNo.Text);
                    cmd.Parameters.AddWithValue("@SellerPassword", txtSellerPassword.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Updated Successfully");
                    Con.Close();
                    populate();
                    txtSellerID.Text = "";
                    txtSellerName.Text = "";
                    txtSellerAge.Text = "";
                    txtSellerPassword.Text = "";
                    txtSellerMobileNo.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtSellerID.Text == "" || txtSellerName.Text == "" || txtSellerAge.Text == "" || txtSellerMobileNo.Text == "" || txtSellerPassword.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update SellersTbl set SellerName='" + txtSellerName.Text + "', SellerAge=" + txtSellerAge.Text + ", SellerMobileNo=" + txtSellerMobileNo.Text + ",SellerPassword=" + txtSellerPassword.Text + "";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Updated Successfully");

                    Con.Close();
                    populate();

                    txtSellerID.Text = "";
                    txtSellerName.Text = "";
                    txtSellerAge.Text = "";
                    txtSellerPassword.Text = "";
                    txtSellerMobileNo.Text = "";
                   // Con.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }*/

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtSellerID.Text == "")
                {
                    MessageBox.Show("Select the Seller to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from SellersTbl where SellerId=" + txtSellerID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted Successfully");
                    Con.Close();
                    populate();

                    txtSellerID.Text = "";
                    txtSellerName.Text = "";
                    txtSellerAge.Text = "";
                    txtSellerPassword.Text = "";
                    txtSellerMobileNo.Text = "";
                    //Con.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void SellersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSellerID.Text = SellersDGV.SelectedRows[0].Cells[0].Value.ToString();
            txtSellerName.Text = SellersDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtSellerAge.Text = SellersDGV.SelectedRows[0].Cells[2].Value.ToString();
            txtSellerMobileNo.Text = SellersDGV.SelectedRows[0].Cells[3].Value.ToString();
            txtSellerPassword.Text = SellersDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        

        /*private void btnDelete_Click(object sender, EventArgs e)
{
    try
    {
        if (txtSellerID.Text == "")
        {
            MessageBox.Show("Select the Seller to Delete");
        }
        else
        {
            Con.Open();
            string query = "DELETE FROM dbo.SellersTbl WHERE SellerId=@SellerId";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@SellerId", txtSellerID.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Seller Deleted Successfully");
            Con.Close();
            populate();
            txtSellerID.Text = "";
            txtSellerName.Text = "";
            txtSellerAge.Text = "";
            txtSellerPassword.Text = "";
            txtSellerMobileNo.Text = "";
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
}
*/
    }










}