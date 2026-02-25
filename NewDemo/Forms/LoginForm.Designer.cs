namespace NewDemo.Forms
{
    partial class LoginForm
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
            lblLogin = new Label();
            lblPassword = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            checkBoxShowPassword = new CheckBox();
            buttonLogin = new Button();
            buttonGuest = new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(43, 56);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(45, 17);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Логин";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(43, 104);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(54, 17);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(43, 76);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(202, 25);
            textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(43, 124);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(202, 25);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Location = new Point(43, 155);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(135, 21);
            checkBoxShowPassword.TabIndex = 4;
            checkBoxShowPassword.Text = "Показать пароль";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(43, 182);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(202, 29);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonGuest
            // 
            buttonGuest.Location = new Point(43, 217);
            buttonGuest.Name = "buttonGuest";
            buttonGuest.Size = new Size(202, 29);
            buttonGuest.TabIndex = 6;
            buttonGuest.Text = "Войти как гость";
            buttonGuest.UseVisualStyleBackColor = true;
            buttonGuest.Click += buttonGuest_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(290, 314);
            Controls.Add(buttonGuest);
            Controls.Add(buttonLogin);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblLogin);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label lblPassword;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private CheckBox checkBoxShowPassword;
        private Button buttonLogin;
        private Button buttonGuest;
    }
}