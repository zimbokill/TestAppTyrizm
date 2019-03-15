namespace Tyrizm.Forms
{
    partial class FlightForm
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
            this.NameField = new System.Windows.Forms.TextBox();
            this.SurnameField = new System.Windows.Forms.TextBox();
            this.From = new System.Windows.Forms.TextBox();
            this.To = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ClassField = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.З = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Registration = new System.Windows.Forms.Button();
            this.TCompany = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(246, 59);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(100, 22);
            this.NameField.TabIndex = 0;
            // 
            // SurnameField
            // 
            this.SurnameField.Location = new System.Drawing.Point(246, 101);
            this.SurnameField.Name = "SurnameField";
            this.SurnameField.Size = new System.Drawing.Size(100, 22);
            this.SurnameField.TabIndex = 1;
            // 
            // From
            // 
            this.From.Location = new System.Drawing.Point(112, 162);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(100, 22);
            this.From.TabIndex = 2;
            // 
            // To
            // 
            this.To.Location = new System.Drawing.Point(292, 162);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(100, 22);
            this.To.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(212, 283);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // ClassField
            // 
            this.ClassField.FormattingEnabled = true;
            this.ClassField.Items.AddRange(new object[] {
            "A",
            "B"});
            this.ClassField.Location = new System.Drawing.Point(225, 348);
            this.ClassField.Name = "ClassField";
            this.ClassField.Size = new System.Drawing.Size(121, 24);
            this.ClassField.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ім\'я";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Прізвище";
            // 
            // З
            // 
            this.З.AutoSize = true;
            this.З.Location = new System.Drawing.Point(52, 162);
            this.З.Name = "З";
            this.З.Size = new System.Drawing.Size(17, 17);
            this.З.TabIndex = 8;
            this.З.Text = "З";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "В";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дата Вильоту";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Класс комфорту";
            // 
            // Registration
            // 
            this.Registration.Location = new System.Drawing.Point(572, 388);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(75, 23);
            this.Registration.TabIndex = 12;
            this.Registration.Text = "Зареєструвати";
            this.Registration.UseVisualStyleBackColor = true;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // TCompany
            // 
            this.TCompany.FormattingEnabled = true;
            this.TCompany.Location = new System.Drawing.Point(280, 218);
            this.TCompany.Name = "TCompany";
            this.TCompany.Size = new System.Drawing.Size(121, 24);
            this.TCompany.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Компанія";
            // 
            // FlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TCompany);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.З);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClassField);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.To);
            this.Controls.Add(this.From);
            this.Controls.Add(this.SurnameField);
            this.Controls.Add(this.NameField);
            this.Name = "FlightForm";
            this.Text = "FlightForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FlightForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.TextBox SurnameField;
        private System.Windows.Forms.TextBox From;
        private System.Windows.Forms.TextBox To;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox ClassField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label З;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.ComboBox TCompany;
        private System.Windows.Forms.Label label3;
    }
}