using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tyrizm.DataBases;

namespace Tyrizm.Forms
{
    public partial class ValidationTicket : Form
    {
        public ValidationTicket()
        {
            InitializeComponent();
            InsertLinq insertLinq = new InsertLinq();

            var tickets = insertLinq.GetTickets();

            foreach (var ticket in tickets)
            {
                if ((ticket.TName+ ticket.TFrom + ticket.TTo + ticket.TDateFlight )== FlightForm.Counter)
                {
                    NameofPassenger.Text = ticket.TName;
                    From.Text = ticket.TFrom;
                    To.Text = ticket.TTo;
                    Date.Text = ticket.TDateFlight;
                    FlightNumber.Text = ticket.TFlightNumber;
                    Seat.Text = ticket.TSeat;
                    Gate.Text = ticket.TGate;
                }
            }         
        }

        private void returnMenu_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            Hide();
            menuForm.Show();
        }

        private void ValidationTicket_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
