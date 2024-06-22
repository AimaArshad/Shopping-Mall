namespace supermarket_mangement_system
{
    partial class Login
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnClose = new Button();
            btnLogin = new Button();
            label4 = new Label();
            cbSelectRole = new ComboBox();
            guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.FillColor = Color.Red;
            guna2CircleButton1.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Location = new Point(-104, 159);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.PressedColor = Color.Blue;
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(408, 382);
            guna2CircleButton1.TabIndex = 0;
            guna2CircleButton1.Text = "                                         Supermarket Mangement System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.25F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(178, 7);
            label1.Name = "label1";
            label1.Size = new Size(566, 37);
            label1.TabIndex = 1;
            label1.Text = "SUPERMARKET MANAGEMENT SYSTEM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(286, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(432, 179);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(191, 37);
            txtUsername.TabIndex = 4;
            txtUsername.TextChanged += textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(433, 224);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(190, 37);
            txtPassword.TabIndex = 5;
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 182);
            label2.Name = "label2";
            label2.Size = new Size(133, 30);
            label2.TabIndex = 6;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F);
            label3.Location = new Point(293, 224);
            label3.Name = "label3";
            label3.Size = new Size(122, 30);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(772, 23);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(34, 34);
            btnClose.TabIndex = 8;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(469, 279);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(122, 55);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN\r\n";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(433, 65);
            label4.Name = "label4";
            label4.Size = new Size(158, 27);
            label4.TabIndex = 9;
            label4.Text = "LOGIN PANEL";
            label4.Click += label4_Click;
            // 
            // cbSelectRole
            // 
            cbSelectRole.AllowDrop = true;
            cbSelectRole.FormattingEnabled = true;
            cbSelectRole.Items.AddRange(new object[] { "Admin", "Seller" });
            cbSelectRole.Location = new Point(432, 126);
            cbSelectRole.Name = "cbSelectRole";
            cbSelectRole.Size = new Size(191, 38);
            cbSelectRole.TabIndex = 10;
            cbSelectRole.Text = "Select Role";
            cbSelectRole.SelectedIndexChanged += cbSelectRole_SelectedIndexChanged;
            // 
            // guna2CheckBox1
            // 
            guna2CheckBox1.AutoSize = true;
            guna2CheckBox1.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2CheckBox1.CheckedState.BorderRadius = 0;
            guna2CheckBox1.CheckedState.BorderThickness = 0;
            guna2CheckBox1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            guna2CheckBox1.Location = new Point(330, 361);
            guna2CheckBox1.Name = "guna2CheckBox1";
            guna2CheckBox1.Size = new Size(248, 34);
            guna2CheckBox1.TabIndex = 11;
            guna2CheckBox1.Text = "guna2CheckBox1";
            guna2CheckBox1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            guna2CheckBox1.UncheckedState.BorderRadius = 0;
            guna2CheckBox1.UncheckedState.BorderThickness = 0;
            guna2CheckBox1.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // btnReset
            // 
            btnReset.Location = new Point(632, 361);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 34);
            btnReset.TabIndex = 12;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 488);
            Controls.Add(btnReset);
            Controls.Add(guna2CheckBox1);
            Controls.Add(cbSelectRole);
            Controls.Add(label4);
            Controls.Add(btnLogin);
            Controls.Add(btnClose);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(guna2CircleButton1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private Button btnClose;
        private Button btnLogin;
        private Label label4;
        private ComboBox cbSelectRole;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Button btnReset;
    }
}