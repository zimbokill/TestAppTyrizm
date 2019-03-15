namespace Tyrizm.Forms
{
    partial class HotelForm
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
            this.HotelRegistration = new System.Windows.Forms.Button();
            this.HotelName = new System.Windows.Forms.ComboBox();
            this.DataTo = new System.Windows.Forms.DateTimePicker();
            this.DataFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RoomFormat = new System.Windows.Forms.ComboBox();
            this.Person = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HotelRegistration
            // 
            this.HotelRegistration.Location = new System.Drawing.Point(629, 387);
            this.HotelRegistration.Name = "HotelRegistration";
            this.HotelRegistration.Size = new System.Drawing.Size(146, 28);
            this.HotelRegistration.TabIndex = 0;
            this.HotelRegistration.Text = "Зареєструвати";
            this.HotelRegistration.UseVisualStyleBackColor = true;
            this.HotelRegistration.Click += new System.EventHandler(this.HotelRegistration_Click);
            // 
            // HotelName
            // 
            this.HotelName.FormattingEnabled = true;
            this.HotelName.Location = new System.Drawing.Point(496, 112);
            this.HotelName.Name = "HotelName";
            this.HotelName.Size = new System.Drawing.Size(194, 24);
            this.HotelName.TabIndex = 4;
            // 
            // DataTo
            // 
            this.DataTo.Location = new System.Drawing.Point(72, 402);
            this.DataTo.Name = "DataTo";
            this.DataTo.Size = new System.Drawing.Size(170, 22);
            this.DataTo.TabIndex = 5;
            // 
            // DataFrom
            // 
            this.DataFrom.Location = new System.Drawing.Point(90, 294);
            this.DataFrom.Name = "DataFrom";
            this.DataFrom.Size = new System.Drawing.Size(170, 22);
            this.DataFrom.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Назва готелю";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Варіанти номерів";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата заїзду";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Дата виїзду";
            // 
            // RoomFormat
            // 
            this.RoomFormat.FormattingEnabled = true;
            this.RoomFormat.Location = new System.Drawing.Point(496, 181);
            this.RoomFormat.Name = "RoomFormat";
            this.RoomFormat.Size = new System.Drawing.Size(194, 24);
            this.RoomFormat.TabIndex = 12;
            // 
            // Person
            // 
            this.Person.Location = new System.Drawing.Point(496, 47);
            this.Person.Name = "Person";
            this.Person.Size = new System.Drawing.Size(202, 22);
            this.Person.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "ПІБ особи";
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Person);
            this.Controls.Add(this.RoomFormat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataFrom);
            this.Controls.Add(this.DataTo);
            this.Controls.Add(this.HotelName);
            this.Controls.Add(this.HotelRegistration);
            this.Name = "HotelForm";
            this.Text = "HotelForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HotelForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HotelRegistration;
        private System.Windows.Forms.ComboBox HotelName;
        private System.Windows.Forms.DateTimePicker DataTo;
        private System.Windows.Forms.DateTimePicker DataFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox RoomFormat;
        private System.Windows.Forms.TextBox Person;
        private System.Windows.Forms.Label label2;
    }
}