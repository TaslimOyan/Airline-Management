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
    public partial class FlightList : Form
    {
        MydbDataContext cnt = new MydbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Desktop\Project\Project\Forms\Mydb.mdf;Integrated Security=True");
       // MydbDataContext cnt = new MydbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Oyan Computer\Desktop\Project\Project\Forms\Mydb.mdf;Integrated Security=True");
        string prof;

        public void FLGetData()
        {

            var str = from a in cnt.Flights
                      select a;


            dataGridView1.DataSource = str;

        }
        public void FuncProfession(string prof)
        {
            this.prof = prof;
        }
        string ps;
        public FlightList(string s)
        {
            InitializeComponent();
            ps = s;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            Flight F = new Flight();
            F.Flight_Name = textBox1.Text;
            F.Departure_Time = textBox2.Text;
            F.Departure_Date = dateTimePicker1.Value.ToShortDateString().ToString();
            F.From = textBox4.Text;
            F.To = textBox5.Text;
            F.FlighCost = textBox6.Text.ToString();
            F.TotalSeatLeft = int.Parse(textBox3.Text);
            


            cnt.Flights.InsertOnSubmit(F);

            cnt.SubmitChanges();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

            FLGetData();

            
        }

        public void ErrorMassage(string msg)
        {
            DialogResult result2 = MessageBox.Show(msg,
      "Important Query",
      MessageBoxButtons.OKCancel,
      MessageBoxIcon.Question);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var str = from a in cnt.Flights

                      where a.Flight_No == int.Parse(textBox7.Text)
                      select a;
            // Person p = new Person();
            Flight f = str.First();
            if (f != null)
            {
                cnt.Flights.DeleteOnSubmit(f);
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
          //  textBox8.Text = "";



            FLGetData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var str = from a in cnt.Flights

                      where a.Flight_No == int.Parse(textBox7.Text)
                      select a;

            Flight F = str.First();

            if (F != null)
            {
                textBox1.Text = F.Flight_Name;

                textBox2.Text = F.Departure_Time;
             //   textBox3.Text = F.Departure_Date;
                textBox4.Text = F.From;
                textBox5.Text = F.To;
                textBox6.Text = F.FlighCost.ToString();
                textBox3.Text = F.TotalSeatLeft.ToString();

                cnt.SubmitChanges();

           //     MessageBox.Show("One Row Updated");

             /*   textBox1.Text = "";
                textBox2.Text= "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
              //  textBox8.Text = "";*/
            }
            else
            {
                MessageBox.Show("Data not found");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var str = from a in cnt.Flights

                      where a.Flight_No == int.Parse(textBox7.Text)
                      select a;
            Flight Fo = str.First();
            if (Fo != null)
            {

                textBox1.Text = Fo.Flight_Name;

                Fo.Departure_Time=textBox2.Text;
                Fo.Departure_Date=dateTimePicker1.Text;
                Fo.From=textBox4.Text;
               Fo.To= textBox5.Text ;
                Fo.FlighCost = textBox6.Text ;
                Fo.TotalSeatLeft=int.Parse(textBox3.Text) ;

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
            FLGetData();
        }

        private void FlightList_Load(object sender, EventArgs e)
        {
            FLGetData();
        }

        private void FlightList_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
