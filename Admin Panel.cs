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
    public partial class Admin_Panel : Form
    {
        string ps;
        public Admin_Panel(){}
        public Admin_Panel(string s)
        {
            InitializeComponent();
            ps = s;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FlightList F2 = new FlightList(ps);
            F2.FuncProfession("Admin");
            F2.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Customer_List C2 = new Customer_List(ps);
            C2.FuncProfession("Admin");
            C2.Show();
            this.Dispose();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Employee_List E2 = new Employee_List(ps);
            E2.FuncProfession("Admin");
            E2.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Booking_List B2 = new Booking_List();
            B2.FuncProfession("Admin");
            B2.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ManagerList M = new ManagerList();
            M.Show();
            this.Hide();

        }

        private void back_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Dispose();
        }

        private void Admin_Panel_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
