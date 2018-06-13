using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class ManagerPanel : Form
    {
        string ps;
        public ManagerPanel(string s)
        {
            InitializeComponent();
            ps = s;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FlightList F = new FlightList(ps);
            F.FuncProfession("Manager");
            F.Show();
            this.Hide();
        }

        private void lbUserName_Click(object sender, EventArgs e)
        {
            Profile P = new Profile(ps);
            P.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Customer_List C = new Customer_List(ps);
            C.FuncProfession("Manager");
            C.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Booking_List B = new Booking_List();
            B.FuncProfession("Manager");
            B.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Employee_List E = new Employee_List(ps);
            E.FuncProfession("Manager");
            E.Show();
            this.Dispose();
        }

        private void ManagerPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
