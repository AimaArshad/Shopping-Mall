
  namespace supermarket_mangement_system
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            logout_button = new Button();
            ProductsDGV = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            TxtProductQuantity = new TextBox();
            TxtProductName = new TextBox();
            txtProductID = new TextBox();
            btnCategories = new Button();
            panel1 = new Panel();
            cbSearchcategory = new ComboBox();
            cbselectcategory = new ComboBox();
            btnrefresh = new Button();
            label6 = new Label();
            TxtProductPrice = new TextBox();
            label5 = new Label();
            labelPRDQUANTITY = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            btnSelling = new Button();
            btnSellers = new Button();
            pictureproduct = new PictureBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductsDGV).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureproduct).BeginInit();
            SuspendLayout();
            // 
            // logout_button
            // 
            logout_button.FlatAppearance.BorderSize = 0;
            logout_button.FlatStyle = FlatStyle.Flat;
            logout_button.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout_button.ForeColor = Color.Red;
            logout_button.Location = new Point(41, 387);
            logout_button.Name = "logout_button";
            logout_button.Size = new Size(123, 35);
            logout_button.TabIndex = 21;
            logout_button.Text = "LOGOUT";
            logout_button.UseVisualStyleBackColor = true;
            // 
            // ProductsDGV
            // 
            ProductsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDGV.Location = new Point(356, 100);
            ProductsDGV.Name = "ProductsDGV";
            ProductsDGV.RowHeadersWidth = 62;
            ProductsDGV.Size = new Size(610, 343);
            ProductsDGV.TabIndex = 21;
            ProductsDGV.CellContentClick += ProductsDGV_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(16, 386);
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
            btnUpdate.Location = new Point(16, 342);
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
            btnAdd.Location = new Point(16, 294);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(126, 42);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // TxtProductQuantity
            // 
            TxtProductQuantity.Location = new Point(162, 118);
            TxtProductQuantity.Margin = new Padding(2, 3, 2, 3);
            TxtProductQuantity.Name = "TxtProductQuantity";
            TxtProductQuantity.Size = new Size(150, 37);
            TxtProductQuantity.TabIndex = 17;
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(162, 75);
            TxtProductName.Margin = new Padding(2, 3, 2, 3);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(150, 37);
            TxtProductName.TabIndex = 16;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(162, 32);
            txtProductID.Margin = new Padding(2, 3, 2, 3);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(150, 37);
            txtProductID.TabIndex = 15;
            // 
            // btnCategories
            // 
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategories.ForeColor = Color.Red;
            btnCategories.Location = new Point(12, 148);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(188, 35);
            btnCategories.TabIndex = 19;
            btnCategories.Text = "CATEGORIES";
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(cbSearchcategory);
            panel1.Controls.Add(cbselectcategory);
            panel1.Controls.Add(btnrefresh);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(TxtProductPrice);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(ProductsDGV);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(TxtProductQuantity);
            panel1.Controls.Add(TxtProductName);
            panel1.Controls.Add(txtProductID);
            panel1.Controls.Add(labelPRDQUANTITY);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(221, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(1106, 484);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // cbSearchcategory
            // 
            cbSearchcategory.FormattingEnabled = true;
            cbSearchcategory.Location = new Point(623, 36);
            cbSearchcategory.Name = "cbSearchcategory";
            cbSearchcategory.Size = new Size(200, 38);
            cbSearchcategory.TabIndex = 27;
            cbSearchcategory.Text = "   select ";
            // 
            // cbselectcategory
            // 
            cbselectcategory.FormattingEnabled = true;
            cbselectcategory.Location = new Point(162, 199);
            cbselectcategory.Name = "cbselectcategory";
            cbselectcategory.Size = new Size(150, 38);
            cbselectcategory.TabIndex = 26;
            cbselectcategory.Text = "     select ";
            cbselectcategory.SelectedIndexChanged += cbselectcategory_SelectedIndexChanged;
            // 
            // btnrefresh
            // 
            btnrefresh.BackColor = Color.IndianRed;
            btnrefresh.FlatAppearance.BorderSize = 0;
            btnrefresh.FlatStyle = FlatStyle.Popup;
            btnrefresh.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnrefresh.ForeColor = Color.White;
            btnrefresh.Location = new Point(843, 34);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(161, 37);
            btnrefresh.TabIndex = 25;
            btnrefresh.Text = "REFRESH";
            btnrefresh.UseVisualStyleBackColor = false;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.RosyBrown;
            label6.Font = new Font("Century Gothic", 9.25F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 212);
            label6.Name = "label6";
            label6.Size = new Size(112, 23);
            label6.TabIndex = 24;
            label6.Text = "CATEGORY";
            // 
            // TxtProductPrice
            // 
            TxtProductPrice.Location = new Point(162, 161);
            TxtProductPrice.Margin = new Padding(2, 3, 2, 3);
            TxtProductPrice.Name = "TxtProductPrice";
            TxtProductPrice.Size = new Size(150, 37);
            TxtProductPrice.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.RosyBrown;
            label5.Font = new Font("Century Gothic", 9.25F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(16, 161);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 22;
            label5.Text = "PRICE";
            // 
            // labelPRDQUANTITY
            // 
            labelPRDQUANTITY.AutoSize = true;
            labelPRDQUANTITY.BackColor = Color.RosyBrown;
            labelPRDQUANTITY.Font = new Font("Century Gothic", 9.25F, FontStyle.Bold);
            labelPRDQUANTITY.ForeColor = Color.White;
            labelPRDQUANTITY.Location = new Point(16, 125);
            labelPRDQUANTITY.Name = "labelPRDQUANTITY";
            labelPRDQUANTITY.Size = new Size(100, 23);
            labelPRDQUANTITY.TabIndex = 14;
            labelPRDQUANTITY.Text = "QUANTITY";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RosyBrown;
            label3.Font = new Font("Century Gothic", 9.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 89);
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
            label2.Location = new Point(28, 48);
            label2.Name = "label2";
            label2.Size = new Size(28, 23);
            label2.TabIndex = 12;
            label2.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.RosyBrown;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(356, 44);
            label4.Name = "label4";
            label4.Size = new Size(199, 27);
            label4.TabIndex = 11;
            label4.Text = "Manage Product";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.25F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(520, 2);
            label1.Name = "label1";
            label1.Size = new Size(566, 37);
            label1.TabIndex = 17;
            label1.Text = "SUPERMARKET MANAGEMENT SYSTEM";
            // 
            // btnSelling
            // 
            btnSelling.FlatAppearance.BorderSize = 0;
            btnSelling.FlatStyle = FlatStyle.Flat;
            btnSelling.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelling.ForeColor = Color.Red;
            btnSelling.Location = new Point(41, 184);
            btnSelling.Name = "btnSelling";
            btnSelling.Size = new Size(123, 35);
            btnSelling.TabIndex = 20;
            btnSelling.Text = "SELLING";
            btnSelling.UseVisualStyleBackColor = true;
            btnSelling.Click += btnSelling_Click_1;
            // 
            // btnSellers
            // 
            btnSellers.FlatAppearance.BorderSize = 0;
            btnSellers.FlatStyle = FlatStyle.Flat;
            btnSellers.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSellers.ForeColor = Color.Red;
            btnSellers.Location = new Point(41, 107);
            btnSellers.Name = "btnSellers";
            btnSellers.Size = new Size(131, 35);
            btnSellers.TabIndex = 18;
            btnSellers.Text = "SELLERS";
            btnSellers.UseVisualStyleBackColor = true;
            btnSellers.Click += btnSellers_Click;
            // 
            // pictureproduct
            // 
            pictureproduct.Image = (Image)resources.GetObject("pictureproduct.Image");
            pictureproduct.Location = new Point(32, 14);
            pictureproduct.Name = "pictureproduct";
            pictureproduct.Size = new Size(100, 74);
            pictureproduct.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureproduct.TabIndex = 28;
            pictureproduct.TabStop = false;
            pictureproduct.Click += pictureBox1_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1217, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 45);
            btnClose.TabIndex = 0;
            btnClose.Text = "X\r\n";
            btnClose.Click += btnClose_Click;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1370, 560);
            Controls.Add(btnClose);
            Controls.Add(pictureproduct);
            Controls.Add(logout_button);
            Controls.Add(btnCategories);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnSelling);
            Controls.Add(btnSellers);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Product";
            Text = "Product";
            Load += Product_Load;
            ((System.ComponentModel.ISupportInitialize)ProductsDGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureproduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logout_button;
        private DataGridView ProductsDGV;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox TxtProductQuantity;
        private TextBox TxtProductName;
        private TextBox txtProductID;
        private Button btnCategories;
        private Panel panel1;
        private Label labelPRDQUANTITY;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label1;
        private Button btnSelling;
        private Button btnSellers;
        private Label label6;
        private TextBox TxtProductPrice;
        private Label label5;
        private Button btnrefresh;
        private ComboBox cbselectcategory;
        private ComboBox cbSearchcategory;
        private PictureBox pictureproduct;
        private Button btnClose;
    }
}















































































