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
    public partial class UserInfoUpdate : Form
    {
        string tGender;
        public UserInfoUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { tGender = "Male"; }
            else if (radioButton2.Checked) { tGender = "Female"; }

            Add b = new Add();




          //  Add a = new Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, tGender, textBox9.Text, Date.Text,);
        }

        private void UserInfoUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
