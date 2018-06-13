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
    public partial class Customer_List : Form
    {
        //MydbDataContext cnt = new MydbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Desktop\Project\Project\Forms\Mydb.mdf;Integrated Security=True");
        MydbDataContext cnt = new MydbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Desktop\Project\Project\Forms\Mydb.mdf;Integrated Security=True");
        string prof;
        public void CGetData()
        {

            var str = from a in cnt.Persons
                      select a;


            dataGridView1.DataSource = str;

        }
        public void FuncProfession(string prof)
        {
            this.prof = prof;
        }
        string ps;
        public Customer_List(string s)
        {
            InitializeComponent();
            ps = s;
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (this.prof == "Manager")
            {
                ManagerPanel m = new ManagerPanel(ps);
                m.Show();
                this.Dispose();

            }
            else if (this.prof == "Admin")
            {
                Admin_Panel A = new Admin_Panel(ps);
                A.Show();
                this.Dispose();


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
         /*   string gen;
            if (radioButton1.Checked) { gen = "Male"; }
            else { gen = "Female"; }
            */
            string Birth = Date.Value.ToShortDateString();
            
            var str = from a in cnt.Persons

                      where a.Id == int.Parse(textBox9.Text)
                      select a;

            Person p = new Person();
           

            if (p != null)
            {

               

                textBox1.Text = p.FirstName;

                textBox2.Text = p.MiddleName;
                textBox3.Text = p.LastName;
                textBox4.Text = p.UserName;
                textBox5.Text = p.Password;
                textBox6.Text = p.Email;
                //gen = p.Gender;
                textBox7.Text = p.Address;
                //Birth = p.BirthDate.ToString();

                cnt.Persons.InsertOnSubmit(p);

                cnt.SubmitChanges();

            }
                            else
                            {
                                MessageBox.Show("Data not found");
                            }
            }
        
                
        private void button2_Click(object sender, EventArgs e)
        {
            var str = from a in cnt.Persons

                      where a.Id == int.Parse(textBox9.Text)
                      select a;
            
            Person ps = str.First();
            if (ps != null)
            {
                cnt.Persons.DeleteOnSubmit(ps);
                MessageBox.Show("Data Deleted");
                cnt.SubmitChanges();

            }
            else
            {
                MessageBox.Show("Data not found");
            }
            textBox1.Text = "";

            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox9.Text = "";
            //  textBox8.Text = "";



            CGetData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var str = from a in cnt.Persons

                      where a.Id == int.Parse(textBox9.Text)
                      select a;
            Person po = str.First();
            if (po != null)
            {

                textBox1.Text = po.FirstName;

                textBox2.Text = po.MiddleName;
                
                textBox3.Text = po.LastName;
                textBox4.Text = po.UserName;
                textBox5.Text = po.Password;
                textBox6.Text = po.Email;
                textBox7.Text = po.Address;
                Date.Text = po.BirthDate.ToString();
                

                cnt.SubmitChanges();
                MessageBox.Show("Data Updated");



                dataGridView1.DataSource = str;
            }
            else
            {
                MessageBox.Show("Data not found");
            }
            textBox1.Text = "";

            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox2.Text = "";
            CGetData();
        }

        private void Customer_List_Load(object sender, EventArgs e)
        {
            CGetData();
        }

        private void Customer_List_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
