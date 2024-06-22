
namespace supermarket_mangement_system
{
    partial class Category
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtCategoryDesc = new TextBox();
            txtCategoryName = new TextBox();
            txtCategoryID = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            btnSellers = new Button();
            btnProducts = new Button();
            btnSelling = new Button();
            btnLogout = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtCategoryDesc);
            panel1.Controls.Add(txtCategoryName);
            panel1.Controls.Add(txtCategoryID);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(224, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 453);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(293, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(435, 350);
            dataGridView1.TabIndex = 21;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(16, 316);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 47);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.IndianRed;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(16, 264);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 46);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.IndianRed;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(16, 219);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 39);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtCategoryDesc
            // 
            txtCategoryDesc.Location = new Point(152, 155);
            txtCategoryDesc.Margin = new Padding(2, 3, 2, 3);
            txtCategoryDesc.Name = "txtCategoryDesc";
            txtCategoryDesc.Size = new Size(116, 37);
            txtCategoryDesc.TabIndex = 17;
            txtCategoryDesc.TextChanged += txtCategoryDesc_TextChanged;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(152, 94);
            txtCategoryName.Margin = new Padding(2, 3, 2, 3);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(116, 37);
            txtCategoryName.TabIndex = 16;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(152, 38);
            txtCategoryID.Margin = new Padding(2, 3, 2, 3);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(116, 37);
            txtCategoryID.TabIndex = 15;
            txtCategoryID.TextChanged += txtCategoryID_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.RosyBrown;
            label5.Font = new Font("Century Gothic", 9.25F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(16, 164);
            label5.Name = "label5";
            label5.Size = new Size(128, 23);
            label5.TabIndex = 14;
            label5.Text = "DESCRIPTION";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RosyBrown;
            label3.Font = new Font("Century Gothic", 9.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(27, 103);
            label3.Name = "label3";
            label3.Size = new Size(65, 23);
            label3.TabIndex = 13;
            label3.Text = "NAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RosyBrown;
            label2.Font = new Font("Century Gothic", 9.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(49, 43);
            label2.Name = "label2";
            label2.Size = new Size(28, 23);
            label2.TabIndex = 12;
            label2.Text = "ID";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.RosyBrown;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(380, 23);
            label4.Name = "label4";
            label4.Size = new Size(236, 27);
            label4.TabIndex = 11;
            label4.Text = "Manage Categories";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.25F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(349, 9);
            label1.Name = "label1";
            label1.Size = new Size(566, 37);
            label1.TabIndex = 10;
            label1.Text = "SUPERMARKET MANAGEMENT SYSTEM";
            // 
            // btnSellers
            // 
            btnSellers.FlatAppearance.BorderSize = 0;
            btnSellers.FlatStyle = FlatStyle.Flat;
            btnSellers.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSellers.ForeColor = Color.Red;
            btnSellers.Location = new Point(41, 91);
            btnSellers.Name = "btnSellers";
            btnSellers.Size = new Size(127, 35);
            btnSellers.TabIndex = 12;
            btnSellers.Text = "SELLERS";
            btnSellers.UseVisualStyleBackColor = true;
            btnSellers.Click += btnSellers_Click;
            // 
            // btnProducts
            // 
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProducts.ForeColor = Color.Red;
            btnProducts.Location = new Point(41, 132);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(145, 35);
            btnProducts.TabIndex = 13;
            btnProducts.Text = "PRODUCTS";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnSelling
            // 
            btnSelling.FlatAppearance.BorderSize = 0;
            btnSelling.FlatStyle = FlatStyle.Flat;
            btnSelling.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelling.ForeColor = Color.Red;
            btnSelling.Location = new Point(41, 173);
            btnSelling.Name = "btnSelling";
            btnSelling.Size = new Size(127, 35);
            btnSelling.TabIndex = 14;
            btnSelling.Text = "SELLING";
            btnSelling.UseVisualStyleBackColor = true;
            btnSelling.Click += btnSelling_Click;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.Red;
            btnLogout.Location = new Point(41, 400);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(127, 35);
            btnLogout.TabIndex = 15;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // button1
            // 
            button1.Location = new Point(951, 9);
            button1.Name = "button1";
            button1.Size = new Size(43, 40);
            button1.TabIndex = 16;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Category
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 520);
            Controls.Add(button1);
            Controls.Add(btnLogout);
            Controls.Add(btnSelling);
            Controls.Add(btnProducts);
            Controls.Add(btnSellers);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Category";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        /*
         * // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Category";
            this.Text = "Category";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }*/

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label1;
        private Button btnSellers;
        private Button btnProducts;
        private Button btnSelling;
        private Label label5;
        private Label label3;
        private Label label2;
        private Button btnLogout;
        private TextBox txtCategoryID;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtCategoryDesc;
        private TextBox txtCategoryName;
        private DataGridView dataGridView1;
        private Button button1;
    }
}
















































































































