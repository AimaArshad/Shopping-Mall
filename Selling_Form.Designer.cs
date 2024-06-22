
using System.Data;
using System.Data.SqlClient;

namespace supermarket_mangement_system
{
    partial class Selling_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selling_Form));
            pictureseller = new PictureBox();
            cbselectcategory = new ComboBox();
            label1 = new Label();
            btnProducts = new Button();
            SELLERS = new Button();
            btnrefresh = new Button();
            panel1 = new Panel();
            lBname = new Label();
            lbdate = new Label();
            RSLABEL = new Label();
            lbamount = new Label();
            SELLSLIST = new Label();
            btnAddproduct = new Button();
            prodDGV = new DataGridView();
            orderDGV = new DataGridView();
            prodID = new DataGridViewTextBoxColumn();
            Names = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            txtProductPrice = new TextBox();
            lbPRICE = new Label();
            BillsDGV = new DataGridView();
            btnDelete = new Button();
            btnprint = new Button();
            btnAdd = new Button();
            txtProductQuantity = new TextBox();
            txtProductName = new TextBox();
            txtBillID = new TextBox();
            labelPRDQUANTITY = new Label();
            nameOfProduct = new Label();
            lbBILLID = new Label();
            lbSellstatus = new Label();
            logout_button = new Button();
            bTNCATEGORIES = new Button();
            printPreviewDialog = new PrintPreviewDialog();
            PrintDocument = new System.Drawing.Printing.PrintDocument();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureseller).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prodDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BillsDGV).BeginInit();
            SuspendLayout();
            // 
            // pictureseller
            // 
            pictureseller.Image = (Image)resources.GetObject("pictureseller.Image");
            pictureseller.Location = new Point(32, 83);
            pictureseller.Name = "pictureseller";
            pictureseller.Size = new Size(110, 102);
            pictureseller.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureseller.TabIndex = 35;
            pictureseller.TabStop = false;
            // 
            // cbselectcategory
            // 
            cbselectcategory.FormattingEnabled = true;
            cbselectcategory.Location = new Point(37, 319);
            cbselectcategory.Name = "cbselectcategory";
            cbselectcategory.Size = new Size(330, 38);
            cbselectcategory.TabIndex = 26;
            cbselectcategory.Text = "  select category";
            cbselectcategory.SelectedIndexChanged += cbselectcategory_SelectedIndexChanged;
            cbselectcategory.SelectionChangeCommitted += cbselectcategory_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.25F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(438, 19);
            label1.Name = "label1";
            label1.Size = new Size(566, 37);
            label1.TabIndex = 30;
            label1.Text = "SUPERMARKET MANAGEMENT SYSTEM";
            label1.Click += label1_Click;
            // 
            // btnProducts
            // 
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProducts.ForeColor = Color.Red;
            btnProducts.Location = new Point(14, 323);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(128, 35);
            btnProducts.TabIndex = 33;
            btnProducts.Text = "PRODUCTS";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // SELLERS
            // 
            SELLERS.FlatAppearance.BorderSize = 0;
            SELLERS.FlatStyle = FlatStyle.Flat;
            SELLERS.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SELLERS.ForeColor = Color.Red;
            SELLERS.Location = new Point(19, 207);
            SELLERS.Name = "SELLERS";
            SELLERS.Size = new Size(110, 35);
            SELLERS.TabIndex = 31;
            SELLERS.Text = "SELLERS";
            SELLERS.UseVisualStyleBackColor = true;
            SELLERS.Click += SELLERS_Click;
            // 
            // btnrefresh
            // 
            btnrefresh.BackColor = Color.IndianRed;
            btnrefresh.FlatAppearance.BorderSize = 0;
            btnrefresh.FlatStyle = FlatStyle.Popup;
            btnrefresh.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnrefresh.ForeColor = Color.White;
            btnrefresh.Location = new Point(241, 256);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(126, 40);
            btnrefresh.TabIndex = 25;
            btnrefresh.Text = "REFRESH";
            btnrefresh.UseVisualStyleBackColor = false;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(lBname);
            panel1.Controls.Add(lbdate);
            panel1.Controls.Add(RSLABEL);
            panel1.Controls.Add(lbamount);
            panel1.Controls.Add(SELLSLIST);
            panel1.Controls.Add(btnAddproduct);
            panel1.Controls.Add(prodDGV);
            panel1.Controls.Add(orderDGV);
            panel1.Controls.Add(cbselectcategory);
            panel1.Controls.Add(btnrefresh);
            panel1.Controls.Add(txtProductPrice);
            panel1.Controls.Add(lbPRICE);
            panel1.Controls.Add(BillsDGV);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnprint);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtProductQuantity);
            panel1.Controls.Add(txtProductName);
            panel1.Controls.Add(txtBillID);
            panel1.Controls.Add(labelPRDQUANTITY);
            panel1.Controls.Add(nameOfProduct);
            panel1.Controls.Add(lbBILLID);
            panel1.Controls.Add(lbSellstatus);
            panel1.Location = new Point(188, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(1477, 659);
            panel1.TabIndex = 29;
            panel1.Paint += panel1_Paint;
            // 
            // lBname
            // 
            lBname.AutoSize = true;
            lBname.BackColor = Color.RosyBrown;
            lBname.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lBname.ForeColor = Color.White;
            lBname.Location = new Point(75, 22);
            lBname.Name = "lBname";
            lBname.Size = new Size(160, 28);
            lBname.TabIndex = 35;
            lBname.Text = "Seller Name ";
            // 
            // lbdate
            // 
            lbdate.AutoSize = true;
            lbdate.BackColor = Color.RosyBrown;
            lbdate.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lbdate.ForeColor = Color.White;
            lbdate.Location = new Point(904, 21);
            lbdate.Name = "lbdate";
            lbdate.Size = new Size(67, 28);
            lbdate.TabIndex = 34;
            lbdate.Text = "Date";
            // 
            // RSLABEL
            // 
            RSLABEL.AutoSize = true;
            RSLABEL.BackColor = Color.RosyBrown;
            RSLABEL.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            RSLABEL.ForeColor = Color.White;
            RSLABEL.Location = new Point(863, 328);
            RSLABEL.Name = "RSLABEL";
            RSLABEL.Size = new Size(37, 28);
            RSLABEL.TabIndex = 33;
            RSLABEL.Text = "Rs";
            // 
            // lbamount
            // 
            lbamount.AutoSize = true;
            lbamount.BackColor = Color.RosyBrown;
            lbamount.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lbamount.ForeColor = Color.White;
            lbamount.Location = new Point(918, 329);
            lbamount.Name = "lbamount";
            lbamount.Size = new Size(110, 28);
            lbamount.TabIndex = 32;
            lbamount.Text = "Amount ";
            // 
            // SELLSLIST
            // 
            SELLSLIST.AutoSize = true;
            SELLSLIST.BackColor = Color.RosyBrown;
            SELLSLIST.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            SELLSLIST.ForeColor = Color.White;
            SELLSLIST.Location = new Point(600, 323);
            SELLSLIST.Name = "SELLSLIST";
            SELLSLIST.Size = new Size(121, 34);
            SELLSLIST.TabIndex = 31;
            SELLSLIST.Text = "Sells List";
            // 
            // btnAddproduct
            // 
            btnAddproduct.BackColor = Color.IndianRed;
            btnAddproduct.FlatAppearance.BorderSize = 0;
            btnAddproduct.FlatStyle = FlatStyle.Popup;
            btnAddproduct.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddproduct.ForeColor = Color.White;
            btnAddproduct.Location = new Point(37, 255);
            btnAddproduct.Name = "btnAddproduct";
            btnAddproduct.Size = new Size(198, 42);
            btnAddproduct.TabIndex = 30;
            btnAddproduct.Text = "ADD PRODUCT";
            btnAddproduct.UseVisualStyleBackColor = false;
            btnAddproduct.Click += btnAddproduct_Click;
            // 
            // prodDGV
            // 
            prodDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            prodDGV.Location = new Point(35, 378);
            prodDGV.Name = "prodDGV";
            prodDGV.RowHeadersWidth = 62;
            prodDGV.Size = new Size(332, 256);
            prodDGV.TabIndex = 29;
            prodDGV.CellContentClick += prodDGV_CellContentClick;
            // 
            // orderDGV
            // 
            orderDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDGV.Columns.AddRange(new DataGridViewColumn[] { prodID, Names, Quantity, Price, Total });
            orderDGV.Location = new Point(398, 59);
            orderDGV.Name = "orderDGV";
            orderDGV.RowHeadersWidth = 62;
            orderDGV.Size = new Size(838, 261);
            orderDGV.TabIndex = 28;
            orderDGV.CellContentClick += orderDGV_CellContentClick;
            // 
            // prodID
            // 
            prodID.HeaderText = "ProdID";
            prodID.MinimumWidth = 8;
            prodID.Name = "prodID";
            prodID.Width = 150;
            // 
            // Names
            // 
            Names.HeaderText = "Name";
            Names.MinimumWidth = 8;
            Names.Name = "Names";
            Names.Width = 150;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 8;
            Quantity.Name = "Quantity";
            Quantity.Width = 150;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.Width = 150;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 8;
            Total.Name = "Total";
            Total.Width = 150;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(162, 198);
            txtProductPrice.Margin = new Padding(2, 3, 2, 3);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(165, 37);
            txtProductPrice.TabIndex = 23;
            // 
            // lbPRICE
            // 
            lbPRICE.AutoSize = true;
            lbPRICE.BackColor = Color.RosyBrown;
            lbPRICE.Font = new Font("Century Gothic", 9.25F, FontStyle.Bold);
            lbPRICE.ForeColor = Color.White;
            lbPRICE.Location = new Point(37, 212);
            lbPRICE.Name = "lbPRICE";
            lbPRICE.Size = new Size(62, 23);
            lbPRICE.TabIndex = 22;
            lbPRICE.Text = "PRICE";
            lbPRICE.Click += lbPRICE_Click;
            // 
            // BillsDGV
            // 
            BillsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BillsDGV.Location = new Point(398, 378);
            BillsDGV.Name = "BillsDGV";
            BillsDGV.RowHeadersWidth = 62;
            BillsDGV.Size = new Size(838, 208);
            BillsDGV.TabIndex = 21;
            BillsDGV.CellContentClick += BillsDGV_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(863, 592);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(119, 42);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnprint
            // 
            btnprint.BackColor = Color.IndianRed;
            btnprint.FlatAppearance.BorderSize = 0;
            btnprint.FlatStyle = FlatStyle.Popup;
            btnprint.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnprint.ForeColor = Color.White;
            btnprint.Location = new Point(743, 592);
            btnprint.Name = "btnprint";
            btnprint.Size = new Size(99, 42);
            btnprint.TabIndex = 19;
            btnprint.Text = "PRINT";
            btnprint.UseVisualStyleBackColor = false;
            btnprint.Click += btnprint_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.IndianRed;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(619, 592);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 42);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtProductQuantity
            // 
            txtProductQuantity.Location = new Point(162, 155);
            txtProductQuantity.Margin = new Padding(2, 3, 2, 3);
            txtProductQuantity.Name = "txtProductQuantity";
            txtProductQuantity.Size = new Size(165, 37);
            txtProductQuantity.TabIndex = 17;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(162, 108);
            txtProductName.Margin = new Padding(2, 3, 2, 3);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(165, 37);
            txtProductName.TabIndex = 16;
            txtProductName.TextChanged += TextProductName_TextChanged;
            // 
            // txtBillID
            // 
            txtBillID.Location = new Point(162, 65);
            txtBillID.Margin = new Padding(2, 3, 2, 3);
            txtBillID.Name = "txtBillID";
            txtBillID.Size = new Size(165, 37);
            txtBillID.TabIndex = 15;
            // 
            // labelPRDQUANTITY
            // 
            labelPRDQUANTITY.AutoSize = true;
            labelPRDQUANTITY.BackColor = Color.RosyBrown;
            labelPRDQUANTITY.Font = new Font("Century Gothic", 9.25F, FontStyle.Bold);
            labelPRDQUANTITY.ForeColor = Color.White;
            labelPRDQUANTITY.Location = new Point(35, 169);
            labelPRDQUANTITY.Name = "labelPRDQUANTITY";
            labelPRDQUANTITY.Size = new Size(100, 23);
            labelPRDQUANTITY.TabIndex = 14;
            labelPRDQUANTITY.Text = "QUANTITY";
            // 
            // nameOfProduct
            // 
            nameOfProduct.AutoSize = true;
            nameOfProduct.BackColor = Color.RosyBrown;
            nameOfProduct.Font = new Font("Century Gothic", 9.25F, FontStyle.Bold);
            nameOfProduct.ForeColor = Color.White;
            nameOfProduct.Location = new Point(37, 122);
            nameOfProduct.Name = "nameOfProduct";
            nameOfProduct.Size = new Size(65, 23);
            nameOfProduct.TabIndex = 13;
            nameOfProduct.Text = "NAME";
            nameOfProduct.Click += lBname_Click;
            // 
            // lbBILLID
            // 
            lbBILLID.AutoSize = true;
            lbBILLID.BackColor = Color.RosyBrown;
            lbBILLID.Font = new Font("Century Gothic", 9.25F, FontStyle.Bold);
            lbBILLID.ForeColor = Color.White;
            lbBILLID.Location = new Point(37, 74);
            lbBILLID.Name = "lbBILLID";
            lbBILLID.Size = new Size(65, 23);
            lbBILLID.TabIndex = 12;
            lbBILLID.Text = "BILL ID";
            // 
            // lbSellstatus
            // 
            lbSellstatus.AutoSize = true;
            lbSellstatus.BackColor = Color.RosyBrown;
            lbSellstatus.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            lbSellstatus.ForeColor = Color.White;
            lbSellstatus.Location = new Point(531, 16);
            lbSellstatus.Name = "lbSellstatus";
            lbSellstatus.Size = new Size(190, 34);
            lbSellstatus.TabIndex = 11;
            lbSellstatus.Text = "Selling Status";
            // 
            // logout_button
            // 
            logout_button.FlatAppearance.BorderSize = 0;
            logout_button.FlatStyle = FlatStyle.Flat;
            logout_button.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout_button.ForeColor = Color.Red;
            logout_button.Location = new Point(19, 605);
            logout_button.Name = "logout_button";
            logout_button.Size = new Size(117, 57);
            logout_button.TabIndex = 34;
            logout_button.Text = "LOGOUT";
            logout_button.UseVisualStyleBackColor = true;
            logout_button.Click += logout_button_Click;
            // 
            // bTNCATEGORIES
            // 
            bTNCATEGORIES.FlatAppearance.BorderSize = 0;
            bTNCATEGORIES.FlatStyle = FlatStyle.Flat;
            bTNCATEGORIES.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bTNCATEGORIES.ForeColor = Color.Red;
            bTNCATEGORIES.Location = new Point(7, 258);
            bTNCATEGORIES.Name = "bTNCATEGORIES";
            bTNCATEGORIES.Size = new Size(175, 50);
            bTNCATEGORIES.TabIndex = 32;
            bTNCATEGORIES.Text = "CATEGORIES";
            bTNCATEGORIES.UseVisualStyleBackColor = true;
            bTNCATEGORIES.Click += bTNCATEGORIES_Click;
            // 
            // printPreviewDialog
            // 
            printPreviewDialog.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.Document = PrintDocument;
            printPreviewDialog.Enabled = true;
            printPreviewDialog.Icon = (Icon)resources.GetObject("printPreviewDialog.Icon");
            printPreviewDialog.Name = "PrintPreviewDialog";
            printPreviewDialog.Visible = false;
            printPreviewDialog.Load += printPreviewDialog_Load;
            // 
            // PrintDocument
            // 
            PrintDocument.PrintPage += printDocument_PrintPage;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1227, 11);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 44);
            btnClose.TabIndex = 36;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Selling_Form
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1725, 759);
            Controls.Add(btnClose);
            Controls.Add(pictureseller);
            Controls.Add(label1);
            Controls.Add(btnProducts);
            Controls.Add(SELLERS);
            Controls.Add(panel1);
            Controls.Add(logout_button);
            Controls.Add(bTNCATEGORIES);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Selling_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selling_Form";
            Load += Selling_Form_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureseller).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)prodDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)BillsDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private PictureBox pictureseller;
        private ComboBox cbselectcategory;
        private Label label1;
        private Button btnProducts;
        private Button SELLERS;
        private Button btnrefresh;
        private Panel panel1;
        private TextBox txtProductPrice;
        private Label lbPRICE;
        private DataGridView BillsDGV;
        private Button btnDelete;
        private Button btnprint;
        private Button btnAdd;
        private TextBox txtProductQuantity;
        private TextBox txtProductName;
        private TextBox txtBillID;
        private Label labelPRDQUANTITY;
        private Label nameOfProduct;
        private Label lbBILLID;
        private Label lbSellstatus;
        private Button logout_button;
        private Button bTNCATEGORIES;
        private DataGridView prodDGV;
        private DataGridView orderDGV;
        private Button btnAddproduct;
        private Label SELLSLIST;
        private DataGridViewTextBoxColumn prodID;
        private DataGridViewTextBoxColumn Names;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Total;
        private Label lBname;
        private Label lbdate;
        private Label RSLABEL;
        private Label lbamount;
       // private printPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument PrintDocument;
        private Button btnClose;
    }
}