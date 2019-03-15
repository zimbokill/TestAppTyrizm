using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Tyrizm.DataBases;

namespace Tyrizm.Forms
{
    public partial class FlightForm : Form
    {
        InsertLinq insertLinq = new InsertLinq();
        public static string Counter;
        Random random = new Random();


        public FlightForm()
        {
            InitializeComponent();
          
            var companys = insertLinq.GetCompany();
            var persons = insertLinq.GetPeople();

            //Загрузка доступеих компаній та типів номерів з БД
            foreach (var company in companys)
            {
                TCompany.Items.Add(company.Company);
            }
            foreach (var person in persons)
            {
                if (person.Hash == LoginForm.Counter)
                {
                    SurnameField.Text = person.SurName;
                    NameField.Text = person.Name;
                    From.Text = person.City;
                }
            }

        }
        private void Registration_Click(object sender, EventArgs e)
        {
            try
            {
                //Створення нового квитка
                Tickets f = new Tickets()
                {
                    Hash=LoginForm.Counter,
                    TName = NameField.Text + " " + SurnameField.Text,
                    TFrom = From.Text,
                    TTo = To.Text,
                    TDateFlight = dateTimePicker1.Text.ToString(),
                    TConveniense = ClassField.SelectedItem.ToString(),
                    TSeat = Convert.ToString(random.Next(1, 6) + "" + (char)random.Next(0x0041, 0x0044)),
                    TGate = Convert.ToString(random.Next(1, 6) + "" + (char)random.Next(0x0041, 0x0044)),
                    TFlightNumber = Convert.ToString((char)random.Next(0x0041, 0x005A) + "" + (char)random.Next(0x0041, 0x005A) + " " + random.Next(1000, 9999)),
                    TCompany = TCompany.Text,
                    TBoardingTime = "14:30"
                };
                insertLinq.Insert(f);

                //Використовується для відображення щойно зареєстрованого квитка в ValidationTIcket
                Counter = NameField.Text + " " + SurnameField.Text+ From.Text + To.Text+ dateTimePicker1.Text.ToString();
                   
                ValidationTicket validationTicket = new ValidationTicket();
                Hide();
                validationTicket.Show();
            }
            catch { }


        }

        private void FlightForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
