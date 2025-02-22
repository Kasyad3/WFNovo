namespace WFNovo
{
    partial class FrmLogin
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
            lblUserName = new Label();
            lblPassword = new Label();
            txtbUserName = new TextBox();
            txtbPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(83, 72);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(75, 17);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "User Name";
            lblUserName.Click += label1_Click_1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(92, 129);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(66, 17);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            lblPassword.Click += lblPassword_Click;
            // 
            // txtbUserName
            // 
            txtbUserName.Location = new Point(191, 66);
            txtbUserName.Name = "txtbUserName";
            txtbUserName.Size = new Size(100, 23);
            txtbUserName.TabIndex = 4;
            // 
            // txtbPassword
            // 
            txtbPassword.Location = new Point(191, 123);
            txtbPassword.Name = "txtbPassword";
            txtbPassword.PasswordChar = '*';
            txtbPassword.Size = new Size(100, 23);
            txtbPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(191, 186);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 23);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtbPassword);
            Controls.Add(txtbUserName);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Name = "FrmLogin";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private Label lblPassword;
        private TextBox txtbUserName;
        private TextBox txtbPassword;
        private Button btnLogin;
    }
}
