using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyrizm.DataBases;

namespace Tyrizm.Forms
{
    public partial class MyTickets : Form
    {
        InsertLinq insertLinq = new InsertLinq();
        public MyTickets()
        {
            InitializeComponent();

           

            var tickets = insertLinq.GetTickets();
            foreach(var ticket in tickets)
            {
                if (ticket.Hash == LoginForm.Counter)
                {
                   TimeList.Items.Add(ticket.TDateFlight);              
                }
            }
        }

        private void ShowInformation_Click(object sender, EventArgs e)
        {

            var tickets = insertLinq.GetTickets();
            foreach (var ticket in tickets)
            {
                if (ticket.Hash == LoginForm.Counter)
                    if (ticket.TDateFlight.ToString()+(ticket.TFrom + "-" + ticket.TTo).ToString() == TimeList.SelectedItem.ToString()+FromToList.SelectedItem.ToString())
                {
                    FlightNumber.Text ="Flight №"+ ticket.TFlightNumber;
                    FromTo.Text = "From-To: "+(ticket.TFrom + "-" + ticket.TTo).ToString();
                    DateBoarding.Text ="Date Flight:"+ (ticket.TDateFlight+" "+ticket.TBoardingTime).ToString();
                    SeatCLass.Text ="Seat:"+ticket.TSeat+"  Class:"+ticket.TConveniense;
                    NamePasenger.Text ="Name pasenger:"+ ticket.TName;
                   
                }
            }
        }

        private void TimeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FromToList.Items.Clear();
            FromToList.Text = "";
            var tickets = insertLinq.GetTickets();
            foreach (var ticket in tickets)
            {
                if (ticket.Hash == LoginForm.Counter)
                    if (ticket.TDateFlight.ToString() == TimeList.SelectedItem.ToString())
                {
                    FromToList.Items.Add((ticket.TFrom + "-" + ticket.TTo).ToString());
                }
            }
        }

        private void ReturnMenu_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            Hide();
            menuForm.Show();
        }
    }
    
}
