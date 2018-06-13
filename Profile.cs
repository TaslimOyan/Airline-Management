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
    public partial class Profile : Form
    {
        MydbDataContext cnt = new MydbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Desktop\Project\Project\Forms\Mydb.mdf;Integrated Security=True");
        //  MydbDataContext cnt = new MydbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Oyan Computer\Desktop\Project\Project\Forms\Mydb.mdf;Integrated Security=True");
        string ps;
        public Profile(string s)
        {
            InitializeComponent();
            ps = s;
        }

        private void back_Click(object sender, EventArgs e)
        {
            UserPanel S = new UserPanel(ps);
            S.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             string Birth = dateTimePicker1.Value.ToShortDateString();
            var str = from a in cnt.Persons

                      where a.UserName == ps
                      select a;

            Person p = new Person();

            if (p != null)
            {

                p.FirstName = textBox1.Text;

                p.MiddleName = textBox2.Text;
                p.LastName = textBox3.Text;
                p.UserName = textBox4.Text;
                p.Email = textBox5.Text;
                p.Gender = textBox6.Text;

                p.Address = textBox7.Text;
                p.BirthDate = Birth;

                MessageBox.Show("Data updated");

                cnt.SubmitChanges();

            }
            else {

                MessageBox.Show("No data found");
            }








           
        
        
        }

        private void Profile_Load(object sender, EventArgs e)
        {
             var str = from a in cnt.Persons

                      where a.UserName == ps
                      select a;
            Person po = str.First();
           

                textBox1.Text = po.FirstName;

                textBox2.Text = po.MiddleName;

                textBox3.Text = po.LastName;
                textBox4.Text = po.UserName;
                textBox5.Text = po.Password;
                textBox6.Text = po.Email;
                textBox7.Text = po.Address;
                dateTimePicker1.Text = po.BirthDate.ToString();


             //   cnt.SubmitChanges();
            //    MessageBox.Show("Data Updated");



                //  dataGridView1.DataSource = str;
           // }
           // else
           // {
            //    MessageBox.Show("Data not found");
            
        
            }

        private void Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        }
    }

