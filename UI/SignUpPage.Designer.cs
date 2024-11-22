namespace EventureApp.UI
{
    partial class SignUpPage
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
            btn_sign_up = new Button();
            tb_password = new TextBox();
            to_login_page = new Label();
            label2 = new Label();
            tb_cpassword = new TextBox();
            SuspendLayout();
            // 
            // tb_username
            // 
            tb_username.Location = new Point(63, 85);
            tb_username.Margin = new Padding(3, 4, 3, 4);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(156, 23);
            tb_username.TabIndex = 0;
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Location = new Point(60, 66);
            label_username.Name = "label_username";
            label_username.Size = new Size(60, 15);
            label_username.TabIndex = 1;
            label_username.Text = "Username";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Location = new Point(63, 133);
            label_password.Name = "label_password";
            label_password.Size = new Size(57, 15);
            label_password.TabIndex = 3;
            label_password.Text = "Password";
            // 
            // btn_sign_up
            // 
            btn_sign_up.BackColor = Color.MediumBlue;
            btn_sign_up.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_sign_up.ForeColor = SystemColors.ButtonFace;
            btn_sign_up.Location = new Point(79, 263);
            btn_sign_up.Margin = new Padding(3, 4, 3, 4);
            btn_sign_up.Name = "btn_sign_up";
            btn_sign_up.Size = new Size(129, 54);
            btn_sign_up.TabIndex = 4;
            btn_sign_up.Text = "Sign up";
            btn_sign_up.UseVisualStyleBackColor = false;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(63, 152);
            tb_password.Margin = new Padding(3, 4, 3, 4);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.Size = new Size(156, 23);
            tb_password.TabIndex = 2;
            // 
            // to_login_page
            // 
            to_login_page.AutoSize = true;
            to_login_page.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            to_login_page.ForeColor = Color.Blue;
            to_login_page.Location = new Point(72, 325);
            to_login_page.Name = "to_login_page";
            to_login_page.Size = new Size(147, 15);
            to_login_page.TabIndex = 5;
            to_login_page.Text = "Already have an account?";
            to_login_page.Click += to_login_page_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 199);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 7;
            label2.Text = "Confirm Password";
            // 
            // tb_cpassword
            // 
            tb_cpassword.Location = new Point(63, 218);
            tb_cpassword.Margin = new Padding(3, 4, 3, 4);
            tb_cpassword.Name = "tb_cpassword";
            tb_cpassword.PasswordChar = '*';
            tb_cpassword.Size = new Size(156, 23);
            tb_cpassword.TabIndex = 6;
            // 
            // SignUpPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 381);
            Controls.Add(label2);
            Controls.Add(tb_cpassword);
            Controls.Add(to_login_page);
            Controls.Add(btn_sign_up);
            Controls.Add(label_password);
            Controls.Add(tb_password);
            Controls.Add(label_username);
            Controls.Add(tb_username);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SignUpPage";
            Text = "Eventure Signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button btn_sign_up;
        private System.Windows.Forms.TextBox tb_password;
        private Label to_login_page;
        private Label label2;
        private TextBox tb_cpassword;
    }
}