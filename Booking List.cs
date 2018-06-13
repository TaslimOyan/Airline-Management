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
    public partial class Booking_List : Form
    {
        MydbDataContext cntx = new MydbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Desktop\Project\Project\Forms\Mydb.mdf;Integrated Security=True");
        string ps;
        public void BookingGetData(string s)
        {
            ps = s;
           
            var str = from a in cntx.Booking_Histories
                      select a;


            dataGridView1.DataSource = str;

        }

        string prof;
        public Booking_List()
        {
            InitializeComponent();
        }
        public void FuncProfession(string prof)
        {
            this.prof = prof;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
         //   MydbDataContext cnt = new MydbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Desktop\Project\Project\Forms\Mydb.mdf;Integrated Security=True");
           // MydbDataContext cnt = new MydbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Oyan Computer\Desktop\Project\Project\Forms\Mydb.mdf;Integrated Security=True");
            var str = from a in cntx.Booking_Histories

                      where a.No == int.Parse(textBox1.Text)
                      select a;

            Booking_History B = str.First();

            if (B != null)
            {
                textBox2.Text = B.CustomerName;
                textBox3.Text = B.FlightName;
                textBox4.Text = B.No_Of_Orders.ToString();
                textBox5.Text = B.Cost_Per_Order_.ToString();
                textBox6.Text = B.Total_Cost.ToString();
              
                
                cntx.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Data not found");
            }
            //     Person p = str.Where(obj=>obj.Id==int.Parse(textBox1.Text)).First();





            //  dataGridView1.DataSource = str.Where(obj=>obj.Id==int.Parse(textBox1.Text));
            dataGridView1.DataSource = str;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            BookingGetData(ps);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MydbDataContext cntx = new MydbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Oyan Computer\Desktop\Project\Project\Forms\Mydb.mdf;Integrated Security=True");
            var str = from a in cntx.Booking_Histories

                      where a.No == int.Parse(textBox1.Text)
                      select a;
            // Person p = new Person();
            Booking_History B = str.First();
            if (B != null)
            {
                cntx.Booking_Histories.DeleteOnSubmit(B);
                MessageBox.Show("Data Deleted");
                cntx.SubmitChanges();

            }
            else
            {
                MessageBox.Show("Data not found");
            }



            BookingGetData(ps);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MydbDataContext cntx = new MydbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Oyan Computer\Desktop\Project\Project\Forms\Mydb.mdf;Integrated Security=True");


         
            
           

            var str = from a in cntx.Flights

                      where a.Flight_Name == textBox2.Text
                      select a;
            Flight F = str.First();

            var st = from b in cntx.Persons

                      where b.UserName == textBox3.Text
                      select b;
            Person P= st.First();
             Booking_History B=new Booking_History();
             if (F != null && P != null)
             {

                 B.CustomerName = textBox2.Text;
                 B.FlightName = textBox3.Text;
                 B.No_Of_Orders = int.Parse(textBox4.Text);
                 B.Cost_Per_Order_ = int.Parse(textBox5.Text);
                 B.Total_Cost = int.Parse(textBox6.Text);
                 cntx.Booking_Histories.InsertOnSubmit(B);
                 cntx.SubmitChanges();

                 MessageBox.Show("Successfully inserted");
             }
             else {
                 MessageBox.Show("Data not found");
             
             }
             BookingGetData(ps);

           
         
          
        }

        private void Booking_List_Load(object sender, EventArgs e)
        {
            BookingGetData(ps);
        }

        private void Booking_List_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
