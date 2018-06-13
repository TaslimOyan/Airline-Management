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
    public partial class Login : Form
    {
        MydbDataContext cntx = new MydbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Desktop\Project\Project\Forms\Mydb.mdf;Integrated Security=True");
     //   MydbDataContext cntx = new MydbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Oyan Computer\Desktop\Project\Project\Forms\Mydb.mdf;Integrated Security=True");
        public int a = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
            this.Hide();
        }
        
        private void Log1_Click(object sender, EventArgs e)
        {




            

            string s = textBox1.Text;
            string s2=textBox2.Text;
            var str = from a2 in cntx.Peoples
                      where a2.UserName == s && a2.password==s2

                      select a2;
            People pa = str.First();
            s2=pa.password.ToString();
            string s3=pa.UserType.ToString();
           

            if (s.Equals(textBox1.Text) &&  s2.Equals(textBox2.Text) && s3.Equals("Customer"))
            {

                UserPanel U = new UserPanel(s);
                U.Show();
                this.Hide();
            }

            else if (s.Equals(textBox1.Text) && s2.Equals(textBox2.Text) && s3.Equals("Manager"))
            {

                ManagerPanel U = new ManagerPanel(s);
                U.Show();
                this.Hide();
            }

            else if (s.Equals(textBox1.Text) && s2.Equals(textBox2.Text) && s3.Equals("Admin"))
            {

                Admin_Panel U = new Admin_Panel(s);
                U.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Invalid input");
            }
            
            
        }


        public void ErrorMassage(string msg)
        {
            DialogResult result2 = MessageBox.Show(msg,
      "Important Query",
      MessageBoxButtons.OKCancel,
      MessageBoxIcon.Question);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
