using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Windows.Forms;
using Tyrizm.DataBases;

namespace Tyrizm.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Password.PasswordChar = '*';
           
        }
  
        public  static int Counter {get; private set; }

        private void Enter_Click(object sender, EventArgs e)
        {

             InsertLinq insertLinq = new InsertLinq();
             var persons = insertLinq.GetPeople();
            Exception error = new Exception();

            #region Сhecking the existence of the account
            try
            {
              
                foreach (var person in persons)
                {
                    if ((Login.Text + Password.Text).GetHashCode() == person.Hash)
                    {
                        Counter = (Login.Text + Password.Text).GetHashCode();
                         MenuForm menuform = new MenuForm();
                        Hide();
                        menuform.Show();
                    }
                }
                
                throw error;
            }
            catch
            {
                ErrorUser.Visible = true;
                ErrorUser.Text = ("Користувача з таким логіном і паролем не знайдено");
                Login.Text = "";                
            }
            #endregion
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            Hide();
            registrationForm.Show();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
