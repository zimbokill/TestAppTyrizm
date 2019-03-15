using System;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Tyrizm.DataBases;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Tyrizm.Forms
{
    public partial class RegistrationForm : Form
    {
       
        public RegistrationForm()
        {
            InitializeComponent();
            Password.PasswordChar = '*';
            Confirmpassword.PasswordChar = '*';
            Sex.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        LoginForm loginform = new LoginForm();

        private void Registration_Click(object sender, EventArgs e)
        {
            int Counter=0;
            Error.Text = "";
            InsertLinq insertLinq = new InsertLinq();
            Exception error = new Exception();

            //Geting all users
            var persons = insertLinq.GetPeople();
           
            try
            {
                foreach (var person in persons)
                {
                    if (Login.Text == person.Login)
                    {
                        Counter = 0;
                        throw error;
                    }
                }
                if (Password.Text == Confirmpassword.Text)
                {
                    #region Creating new user
                    Person p = new Person()
                    {
                        Login = Login.Text,
                        Hash = Convert.ToInt32((Login.Text + Password.Text).GetHashCode()),
                        SurName = Surname.Text,
                        Name = NamePerson.Text,
                        SecondName = SecondName.Text,
                        Age = Convert.ToInt32(Age.Text),
                        Sex = Sex.SelectedItem.ToString(),
                        PhoneNumber =PhoneNumber.Text,
                        City = CityField.Text,
                        Email = Email.Text
                    };
                    #endregion

                    #region Validation
                    //Валідація всіх заповнених полів
                    var results = new List<ValidationResult>();
                    var context = new ValidationContext(p);
                    if (!Validator.TryValidateObject(p, context, results, true))
                    {
                        foreach (var oo in results)
                        {
                            Error.Text += " *"+oo.ErrorMessage + "*\n";                          
                        }
                    }
                    else
                    {                      
                            insertLinq.Insert(p);                           
                            Hide();
                            loginform.Show();
                        
                    }
                        #endregion
                }
                else { Counter = 2; throw error; }


            }
            catch
            {
                if (Counter == 0)
                { Error.Text = "Користувач з таким іменем вже існує"; }
                else
                {if (Counter == 2)
                    { Error.Text = "Паролі не спывпадають"; }
                    else { Error.Text = ("Перевірте чи всі поля заповнені"); }                  
                }
            }
        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            Hide();
            loginform.Show();
        }
    }
}
