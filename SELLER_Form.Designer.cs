

namespace supermarket_mangement_system
{
    partial class SELLER_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SELLER_Form));
            pictureproduct = new PictureBox();
            label1 = new Label();
            btnselling = new Button();
            btnProducts = new Button();
            btncategory = new Button();
            label6 = new Label();
            txtSellerMobileNo = new TextBox();
            label5 = new Label();
            SellersDGV = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtSellerAge = new TextBox();
            txtSellerName = new TextBox();
            labelPRDQUANTITY = new Label();
            label3 = new Label();
            label2 = new Label();
            labelsellers = new Label();
            btnClose = new Button();
            txtSellerID = new TextBox();
            panel1 = new Panel();
            txtSellerPassword = new TextBox();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureproduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SellersDGV).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureproduct
            // 
            pictureproduct.BackgroundImageLayout = ImageLayout.None;
            pictureproduct.Image = (Image)resources.GetObject("pictureproduct.Image");
            pictureproduct.Location = new Point(15, 26);
            pictureproduct.Name = "pictureproduct";
            pictureproduct.Size = new Size(120, 89);
            pictureproduct.SizeMode = PictureBoxSizeMode.Zoom;
            pictureproduct.TabIndex = 35;
            pictureproduct.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.25F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(426, 26);
            label1.Name = "label1";
            label1.Size = new Size(566, 37);
            label1.TabIndex = 30;
            label1.Text = "SUPERMARKET MANAGEMENT SYSTEM";
            label1.Click += label1_Click;
            // 
            // btnselling
            // 
            btnselling.FlatAppearance.BorderSize = 0;
            btnselling.FlatStyle = FlatStyle.Flat;
            btnselling.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnselling.ForeColor = Color.Red;
            btnselling.Location = new Point(32, 403);
            btnselling.Name = "btnselling";
            btnselling.Size = new Size(124, 35);
            btnselling.TabIndex = 33;
            btnselling.Text = "SELLING";
            btnselling.UseVisualStyleBackColor = true;
            btnselling.Click += btnselling_Click;
            // 
            // btnProducts
            // 
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProducts.ForeColor = Color.Red;
            btnProducts.Location = new Point(23, 243);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(112, 35);
            btnProducts.TabIndex = 31;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btncategory
            // 
            btncategory.FlatAppearance.BorderSize = 0;
            btncategory.FlatStyle = FlatStyle.Flat;
            btncategory.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncategory.ForeColor = Color.Red;
            btncategory.Location = new Point(-3, 328);
            btncategory.Name = "btncategory";
            btncategory.Size = new Size(179, 35);
            btncategory.TabIndex = 32;
            btncategory.Text = "CATEGORIES";
            btncategory.UseVisualStyleBackColor = true;
            btncategory.Click += btncategory_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.RosyBrown;
            label6.Font = new Font("Century Gothic", 9.25F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(17, 195);
            label6.Name = "label6";
            label6.Size = new Size(96, 23);
            label6.TabIndex = 24;
            label6.Text = "Password";
            // 
            // txtSellerMobileNo
            // 
            txtSellerMobileNo.Location = new Point(176, 144);
            txtSellerMobileNo.Margin = new Padding(2, 3, 2, 3);
            txtSellerMobileNo.Name = "txtSellerMobileNo";
            txtSellerMobileNo.Size = new Size(116, 37);
            txtSellerMobileNo.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.RosyBrown;
            label5.Font = new Font("Century Gothic", 9.25F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(30, 144);
            label5.Name = "label5";
            label5.Size = new Size(105, 23);
            label5.TabIndex = 22;
            label5.Text = "Mobile No";
            // 
            // SellersDGV
            // 
            SellersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SellersDGV.Location = new Point(357, 72);
            SellersDGV.Name = "SellersDGV";
            SellersDGV.RowHeadersWidth = 62;
            SellersDGV.Size = new Size(709, 566);
            SellersDGV.TabIndex = 21;
            SellersDGV.CellContentClick += SellersDGV_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(30, 369);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 43);
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
            btnUpdate.Location = new Point(30, 325);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(126, 38);
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
            btnAdd.Location = new Point(30, 277);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(126, 42);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSellerAge
            // 
            txtSellerAge.Location = new Point(176, 101);
            txtSellerAge.Margin = new Padding(2, 3, 2, 3);
            txtSellerAge.Name = "txtSellerAge";
            txtSellerAge.Size = new Size(116, 37);
            txtSellerAge.TabIndex = 17;
            // 
            // txtSellerName
            // 
            txtSellerName.Location = new Point(176, 58);
            txtSellerName.Margin = new Padding(2, 3, 2, 3);
            txtSellerName.Name = "txtSellerName";
            txtSellerName.Size = new Size(116, 37);
            txtSellerName.TabIndex = 16;
            // 
            // labelPRDQUANTITY
            // 
            labelPRDQUANTITY.AutoSize = true;
            labelPRDQUANTITY.BackColor = Color.RosyBrown;
            labelPRDQUANTITY.Font = new Font("Century Gothic", 9.25F, FontStyle.Bold);
            labelPRDQUANTITY.ForeColor = Color.White;
            labelPRDQUANTITY.Location = new Point(30, 108);
            labelPRDQUANTITY.Name = "labelPRDQUANTITY";
            labelPRDQUANTITY.Size = new Size(50, 23);
            labelPRDQUANTITY.TabIndex = 14;
            labelPRDQUANTITY.Text = "AGE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RosyBrown;
            label3.Font = new Font("Century Gothic", 9.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 72);
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
            label2.Location = new Point(42, 31);
            label2.Name = "label2";
            label2.Size = new Size(28, 23);
            label2.TabIndex = 12;
            label2.Text = "ID";
            // 
            // labelsellers
            // 
            labelsellers.AutoSize = true;
            labelsellers.BackColor = Color.RosyBrown;
            labelsellers.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            labelsellers.ForeColor = Color.White;
            labelsellers.Location = new Point(370, 27);
            labelsellers.Name = "labelsellers";
            labelsellers.Size = new Size(184, 27);
            labelsellers.TabIndex = 11;
            labelsellers.Text = "Manage Sellers";
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Red;
            btnClose.Location = new Point(1158, 26);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(81, 35);
            btnClose.TabIndex = 34;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtSellerID
            // 
            txtSellerID.Location = new Point(176, 17);
            txtSellerID.Margin = new Padding(2, 3, 2, 3);
            txtSellerID.Name = "txtSellerID";
            txtSellerID.Size = new Size(116, 37);
            txtSellerID.TabIndex = 15;
            txtSellerID.TextChanged += textProductID_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(txtSellerPassword);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtSellerMobileNo);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(SellersDGV);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtSellerAge);
            panel1.Controls.Add(txtSellerName);
            panel1.Controls.Add(txtSellerID);
            panel1.Controls.Add(labelPRDQUANTITY);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(labelsellers);
            panel1.Location = new Point(182, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(1086, 690);
            panel1.TabIndex = 29;
            panel1.Paint += panel1_Paint;
            // 
            // txtSellerPassword
            // 
            txtSellerPassword.Location = new Point(176, 188);
            txtSellerPassword.Margin = new Padding(2, 3, 2, 3);
            txtSellerPassword.Name = "txtSellerPassword";
            txtSellerPassword.Size = new Size(116, 37);
            txtSellerPassword.TabIndex = 25;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.Red;
            btnLogout.Location = new Point(23, 511);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(123, 35);
            btnLogout.TabIndex = 36;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // SELLER_Form
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1280, 749);
            Controls.Add(btnLogout);
            Controls.Add(pictureproduct);
            Controls.Add(label1);
            Controls.Add(btnselling);
            Controls.Add(btnProducts);
            Controls.Add(btncategory);
            Controls.Add(btnClose);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "SELLER_Form";
            Text = "SELLER_Form";
            Load += SELLER_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureproduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)SellersDGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //throw new NotImplementedException();
        }



        #endregion

        private PictureBox pictureproduct;
        private Label label1;
        private Button btnselling;
        private Button btnProducts;
        private Button btncategory;
        private Label label6;
        private TextBox txtSellerMobileNo;
        private Label label5;
        private DataGridView SellersDGV;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtSellerAge;
        private TextBox txtSellerName;
        private Label labelPRDQUANTITY;
        private Label label3;
        private Label label2;
        private Label labelsellers;
        private Button btnClose;
        private TextBox txtSellerID;
        private Panel panel1;
        private TextBox txtSellerPassword;
        private Button btnLogout;
    }
}