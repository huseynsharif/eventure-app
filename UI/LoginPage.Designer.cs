﻿namespace EventureApp.UI
{
    partial class LoginPage
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
            tb_username = new TextBox();
            label_username = new Label();
            label_password = new Label();
            btn_login = new Button();
            tb_password = new TextBox();
            to_sign_up_page = new Label();
            SuspendLayout();
            // 
            // tb_username
            // 
            tb_username.Location = new Point(67, 121);
            tb_username.Margin = new Padding(3, 4, 3, 4);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(156, 23);
            tb_username.TabIndex = 0;
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Location = new Point(64, 102);
            label_username.Name = "label_username";
            label_username.Size = new Size(60, 15);
            label_username.TabIndex = 1;
            label_username.Text = "Username";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Location = new Point(67, 178);
            label_password.Name = "label_password";
            label_password.Size = new Size(57, 15);
            label_password.TabIndex = 3;
            label_password.Text = "Password";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.MediumBlue;
            btn_login.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_login.ForeColor = SystemColors.ButtonFace;
            btn_login.Location = new Point(79, 249);
            btn_login.Margin = new Padding(3, 4, 3, 4);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(129, 54);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(67, 197);
            tb_password.Margin = new Padding(3, 4, 3, 4);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.Size = new Size(156, 23);
            tb_password.TabIndex = 2;
            // 
            // to_sign_up_page
            // 
            to_sign_up_page.AutoSize = true;
            to_sign_up_page.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            to_sign_up_page.ForeColor = Color.Blue;
            to_sign_up_page.Location = new Point(74, 311);
            to_sign_up_page.Name = "to_sign_up_page";
            to_sign_up_page.Size = new Size(136, 15);
            to_sign_up_page.TabIndex = 5;
            to_sign_up_page.Text = "Don't have an account?";
            to_sign_up_page.Click += to_sign_up_page_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 381);
            Controls.Add(to_sign_up_page);
            Controls.Add(btn_login);
            Controls.Add(label_password);
            Controls.Add(tb_password);
            Controls.Add(label_username);
            Controls.Add(tb_username);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginPage";
            Text = "Eventure Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_password;
        private Label to_sign_up_page;
    }
}