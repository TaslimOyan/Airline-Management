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
    public partial class Employee_List : Form
    {
        MydbDataContext cnt = new MydbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Desktop\Project\Project\Forms\Mydb.mdf;Integrated Security=True");
        string prof;
        public void EmpGetData()
        {

            var str = from a in cnt.Employees
                      select a;


            dataGridView1.DataSource = str;

        }
        public void FuncProfession(string prof)
        {
            this.prof = prof;
        }
        string ps;
        public Employee_List(string s)
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

        private void Employee_List_Load(object sender, EventArgs e)
        {
            EmpGetData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Employee E = new Employee();
            E.Name = textBox1.Text;
            E.Email = textBox3.Text;
            E.Role = textBox4.Text;
            E.Salary = float.Parse(textBox5.Text);
            E.WorkingHour = int.Parse(textBox6.Text);
            E.OffDay = textBox7.Text;

            cnt.Employees.InsertOnSubmit(E);
           
            cnt.SubmitChanges();
            textBox1.Text = "";

            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            EmpGetData();
            
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
            var str = from a in cnt.Employees

                      where a.Id == int.Parse(textBox8.Text)
                      select a;

            Employee E = str.First();

            if (E != null)
            {
                textBox1.Text = E.Name;
                
                textBox3.Text = E.Email;
                textBox4.Text = E.Role;
                textBox5.Text = E.Salary.ToString();
                textBox6.Text = E.WorkingHour.ToString();
                textBox7.Text = E.OffDay.ToString();

                cnt.SubmitChanges();

             //   MessageBox.Show("One Row Updated");

              /*  textBox1.Text = "";
            
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";*/
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
            var str = from a in cnt.Employees

                      where a.Id == int.Parse(textBox8.Text)
                      select a;
            // Person p = new Person();
            Employee E = str.First();
            if (E != null)
            {
                cnt.Employees.DeleteOnSubmit(E);
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
            textBox8.Text = "";



            EmpGetData();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var str = from a in cnt.Employees

                      where a.Id == int.Parse(textBox8.Text)
                      select a;
            Employee em = str.First();
            if (em != null)
            {
                /*   textBox2.Text = M.UserName;
                   textBox3.Text = M.Password;
                   textBox4.Text = M.Email;
                   textBox5.Text = M.ContactNo;
                   textBox6.Text = M.Salary.ToString();
                   cntx.SubmitChanges();
                   */

                em.Name = textBox1.Text;
                em.Email = textBox3.Text;
                em.Role = textBox4.Text;

                em.Salary = int.Parse(textBox5.Text);
                em.WorkingHour = int.Parse(textBox6.Text);

                em.OffDay = textBox7.Text;
               

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
            textBox8.Text = "";
            EmpGetData();

        }

        private void Employee_List_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
