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
    public partial class ManagerList : Form
    {
       // MydbDataContext cnt = new MydbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Desktop\Project\Project\Forms\Mydb.mdf;Integrated Security=True");
        MydbDataContext cnt = new MydbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Desktop\Project\Project\Forms\Mydb.mdf;Integrated Security=True");
        public void ManagerGetData()
        {
         
            var str = from a in cnt.Managers
                      select a;
                      
                      
            dataGridView1.DataSource = str;

        }
        public ManagerList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminOperation Ad = new AdminOperation();
            Ad.AddManager(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, Convert.ToInt32(textBox6.Text), this);
        }
        public void ErrorMassage(string msg)
        {
            DialogResult result2 = MessageBox.Show(msg,
      "Important Query",
      MessageBoxButtons.OKCancel,
      MessageBoxIcon.Question);
        }

        private void button4_Click(object sender, EventArgs e)
        {
           /* AdminOperation a = new AdminOperation();
            a.SearchMan(Convert.ToInt32(textBox1.Text), this);
           // MessageBox.Show();*/

            
            var str = from a in cnt.Managers

                      where a.Id == int.Parse(textBox1.Text)
                      select a;

            Manager M = str.First();

            if (M != null)
            {
                textBox2.Text = M.UserName;
                textBox3.Text = M.Password;
                textBox4.Text = M.Email;
                textBox5.Text = M.ContactNo;
                textBox6.Text = M.Salary.ToString();
                cnt.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Data not found");
            }
            //     Person p = str.Where(obj=>obj.Id==int.Parse(textBox1.Text)).First();
           
            


          
            //  dataGridView1.DataSource = str.Where(obj=>obj.Id==int.Parse(textBox1.Text));
            dataGridView1.DataSource = str;

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
            var str = from a in cnt.Managers

                      where a.Id == int.Parse(textBox1.Text)
                      select a;
            // Person p = new Person();
            Manager M = str.First();
            if (M != null)
            {
                cnt.Managers.DeleteOnSubmit(M);
                MessageBox.Show("Data Deleted");
                cnt.SubmitChanges();
               
            }
            else
            {
                MessageBox.Show("Data not found");
            }

           
           
            ManagerGetData();
            


        }

        public void ErrorMassage2(string msg)
        {
            DialogResult result2 = MessageBox.Show(msg,
      "Important Query",
      MessageBoxButtons.OKCancel,
      MessageBoxIcon.Question);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            var str = from a in cnt.Managers

                      where a.Id == int.Parse(textBox1.Text)
                      select a;
            Manager M = str.First();
            if (M != null)
            {
             /*   textBox2.Text = M.UserName;
                textBox3.Text = M.Password;
                textBox4.Text = M.Email;
                textBox5.Text = M.ContactNo;
                textBox6.Text = M.Salary.ToString();
                cntx.SubmitChanges();
                */
                M.UserName = textBox2.Text;
                M.Password = textBox3.Text;
                M.Email = textBox4.Text;
                M.ContactNo = textBox5.Text;
                M.Salary = int.Parse(textBox6.Text);

                cnt.SubmitChanges();
                MessageBox.Show("Data Updated");

                dataGridView1.DataSource = str;
                textBox1.Text="";
                textBox2.Text="";
                textBox3.Text="";
                textBox4.Text="";
                textBox5.Text="";
                textBox6.Text="";
            }
            else
            {
                MessageBox.Show("Data not found");
            }
         //   ManagerGetData();

        }
        public void ErrorMassage3(string msg)
        {
            DialogResult result2 = MessageBox.Show(msg,
      "Important Query",
      MessageBoxButtons.OKCancel,
      MessageBoxIcon.Question);
        }

        private void ManagerList_Load(object sender, EventArgs e)
        {
            ManagerGetData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManagerGetData();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Admin_Panel M = new Admin_Panel();
            M.Show();
            this.Hide();
            
        }

        private void ManagerList_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
