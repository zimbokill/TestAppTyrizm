namespace Tyrizm.Forms
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
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Enterbut = new System.Windows.Forms.Button();
            this.Registration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(137, 180);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 22);
            this.Login.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(137, 243);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 22);
            this.Password.TabIndex = 1;
            // 
            // Enterbut
            // 
            this.Enterbut.Location = new System.Drawing.Point(216, 319);
            this.Enterbut.Name = "Enterbut";
            this.Enterbut.Size = new System.Drawing.Size(75, 23);
            this.Enterbut.TabIndex = 2;
            this.Enterbut.Text = "Увійти";
            this.Enterbut.UseVisualStyleBackColor = true;
            this.Enterbut.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Registration
            // 
            this.Registration.Location = new System.Drawing.Point(21, 319);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(130, 23);
            this.Registration.TabIndex = 3;
            this.Registration.Text = "Зареєструватися";
            this.Registration.UseVisualStyleBackColor = true;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логін";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // ErrorUser
            // 
            this.ErrorUser.AutoSize = true;
            this.ErrorUser.Location = new System.Drawing.Point(50, 150);
            this.ErrorUser.Name = "ErrorUser";
            this.ErrorUser.Size = new System.Drawing.Size(46, 17);
            this.ErrorUser.TabIndex = 6;
            this.ErrorUser.Text = "label3";
            this.ErrorUser.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 398);
            this.Controls.Add(this.ErrorUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.Enterbut);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.HelpButton = true;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Enterbut;
        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ErrorUser;
    }
}