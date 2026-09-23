namespace bt4._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtUserName = new TextBox();
            lblUserName = new Label();
            lblPassword = new Label();
            chkShowPassword = new CheckBox();
            btnExit = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            errorProvider2 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(110, 56);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(195, 23);
            txtUserName.TabIndex = 1;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(12, 64);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(85, 15);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "Tên đăng nhập";
            lblUserName.Click += label1_Click_1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 105);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(58, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Mật Khẩu";
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(358, 107);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(121, 19);
            chkShowPassword.TabIndex = 5;
            chkShowPassword.Text = "Hiển thị mật khẩu";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(230, 143);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(110, 143);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(110, 103);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(195, 23);
            txtPassword.TabIndex = 9;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnExit);
            Controls.Add(chkShowPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(txtUserName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUserName;
        private Label lblUserName;
        private Label lblPassword;
        private CheckBox chkShowPassword;
        private Button btnExit;
        private ErrorProvider errorProvider1;
        private Button btnLogin;
        private TextBox txtPassword;
        private ErrorProvider errorProvider2;
    }
}
