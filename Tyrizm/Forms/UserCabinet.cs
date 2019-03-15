using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyrizm.DataBases;

namespace Tyrizm.Forms
{
    public partial class UserCabinet : Form
    {
        public UserCabinet()
        {
            InitializeComponent();
            Password .PasswordChar = '*';
            Oldpassword.PasswordChar = '*';
            Confirmpassword.PasswordChar = '*';
            Sex.DropDownStyle = ComboBoxStyle.DropDownList;

            InsertLinq insertLinq = new InsertLinq();

            var persons = insertLinq.GetPeople();
            #region Load User information
            foreach (var person in persons)
                {
                    if (person.Hash == LoginForm.Counter)
                    { 
                    Surname.Text = person.SurName;
                    NamePerson.Text = person.Name;
                    SecondName.Text = person.SecondName;
                    Age.Text = person.Age.ToString();
                    Sex.Text = person.Sex;
                    PhoneNumber.Text = person.PhoneNumber.ToString();
                    CityField.Text = person.City;
                    Login = person.Login;
                    Email.Text = person.Email;
                    }
                }
            #endregion

        }
        public string Login { get; set; }
        private void SaveChanges_Click(object sender, EventArgs e)
        {
            InsertLinq insertLinq = new InsertLinq();

            if (Oldpassword.Text != "")
            {
                int h= (Login+Oldpassword.Text).GetHashCode();
                if (h== LoginForm.Counter)
                {
                    if (Password.Text == Confirmpassword.Text)
                    {
                        int Hash = (Login + Password.Text).GetHashCode();
                        insertLinq.Change(Hash, Surname.Text, NamePerson.Text, SecondName.Text, Age.Text, Sex.Text, PhoneNumber.Text, CityField.Text, Email.Text);
                        MenuForm menuForm = new MenuForm();
                        Hide();
                        menuForm.Show();
                    }
                }
            }
            else
            {
                Person p = new Person()
                {
                    Login = "1111111",
                    Hash = 1,
                    SurName = Surname.Text,
                    Name = NamePerson.Text,
                    SecondName = SecondName.Text,
                    Age = Convert.ToInt32(Age.Text),
                    Sex = Sex.SelectedItem.ToString(),
                    PhoneNumber = PhoneNumber.Text,
                    City = CityField.Text,
                    Email = Email.Text
                };
                #region Validation
                //Валідація всіх заповнених полів
                var results = new List<ValidationResult>();
                var context = new ValidationContext(p);
                if (!Validator.TryValidateObject(p, context, results, true))
                {
                    foreach (var oo in results)
                    {
                        Error.Text += " *" + oo.ErrorMessage + "*\n";
                    }
                }
                else
                {
                    insertLinq.Change(Surname.Text, NamePerson.Text, SecondName.Text, Age.Text, Sex.Text, PhoneNumber.Text, CityField.Text, Email.Text);
                    MenuForm menuForm = new MenuForm();
                    Hide();
                    menuForm.Show();
                }
                #endregion

            }
        }

        private void UserCabinet_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
