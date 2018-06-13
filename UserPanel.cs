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
    
    public partial class UserPanel : Form
    {
        
        Add add = new Add();
        string ps,Lfrom,Lto,fl;
        MydbDataContext cnt = new MydbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Desktop\Project\Project\Forms\Mydb.mdf;Integrated Security=True");
       // MydbDataContext cnt = new MydbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Oyan Computer\Desktop\Project\Project\Forms\Mydb.mdf;Integrated Security=True");
        
        public UserPanel( string s )
        {
            
            InitializeComponent();
            label4.Text = s;
            ps = s;
        }
        public void manage_grid()
        {
            var str = from a in cnt.Flights
                      select a;

            dataGridView1.DataSource = str;
        }
        public void manage_grid2()
        {
            var str2 = from a in cnt.Booking_Histories
                      select a;

            dataGridView2.DataSource = str2;
        }
       
        public void GetData()
        {
            /*List<string> Flightlist = new List<string>();

            MydbDataContext cntx = new MydbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Raiyan Sharif\Desktop\Project\Project\Forms\Mydb.mdf;Integrated Security=True");
            var st = (from a3 in cntx.Flights

                      select new { a3.Flight_Name }).ToList();


            FNameCombo.DataSource = st;
            FNameCombo.DisplayMember = "Flight_Name";
            */
            
        }
        public void Initilizer(string fName, string mName, string lName, string uName, string pass, string email, string cNumber, string gender, string address, string dOB,int Id)
        {

            FNAME = fName; MNAME = mName; LNAME = lName; UNAME = uName; PASS = pass; EMAIL = email; CONT = cNumber; GENDER = gender; ADDRESS = address; DOB = dOB; //add = a;  
            label4.Text = UNAME;
      //      DialogResult result2 = MessageBox.Show(fName+" "+UNAME+" raiyan "+DOB,
      //"Important Query",
      //MessageBoxButtons.OKCancel,
      //MessageBoxIcon.Question);
            GetData();
        }
        private void lbUserName_Click(object sender, EventArgs e)
        {
            Profile P = new Profile(ps);
            P.Show();
            this.Hide();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
             Login L = new Login();
            L.Show();
            this.Hide();
        


          
        }

        private void UCancel_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Are you sure you want to cancel the booking ?",
            "Important Query",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question);
        }

        private void back_Click(object sender, EventArgs e)
        {

        }

        private void FNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        public string FNAME
        {
            get;
            set;
        }
        public string MNAME
        {
            get;
            set;
        }
        public string LNAME
        {
            get;
            set;
        }
        public string UNAME
        {
            get;
            set;
        }
        public string PASS
        {
            get;
            set;
        }
        public string APASS
        {
            get;
            set;
        }
        public string EMAIL
        {

            get;
            set;
        }
        public string CONT
        {

            get;
            set;
        }
        public string GENDER
        {

            get;
            set;
        }
        public string ADDRESS
        {

            get;
            set;
        }
        public string DOB
        {

            get;
            set;
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            manage_grid();
            manage_grid2();
            FormCbox1.BindingContext = new BindingContext();
            FormCbox1.DataSource = cnt.Places;
            FormCbox1.DisplayMember = "FLocation";

            ToCBox2.BindingContext = new BindingContext();
            ToCBox2.DataSource = cnt.Places;
            ToCBox2.DisplayMember = "TLocation";

            flightcombo.BindingContext = new BindingContext();
            flightcombo.DataSource = cnt.Flights;
            flightcombo.DisplayMember = "Flight_Name";

        }

        private void ToCBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lto = ToCBox2.Text;
        }

        private void FormCbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lfrom = FormCbox1.Text;

        }

        private void Orderbutton_Click(object sender, EventArgs e)
        {
            if (Lfrom.Equals(Lto)) {
                MessageBox.Show("From and to can not be same");
            }

            int s =int.Parse( SeatBox.Text);
            
            

            var str = from a in cnt.Flights

                      where a.Flight_Name == fl
                      select a;
            Flight F = str.First();

            string fo=F.TotalSeatLeft.ToString();

            string DD = F.Departure_Date.ToString();
            string TT = F.Departure_Time.ToString();

            int t =int.Parse( F.FlighCost.ToString());
            
            Booking_History B = new Booking_History();
            if (F != null)
            {

                B.CustomerName = ps;
                B.FlightName = fl;
                B.No_Of_Orders = s;
                B.Cost_Per_Order_ = t;
                B.Total_Cost = s*t;


                F.TotalSeatLeft = (int.Parse(fo)) - s;
                if (F.TotalSeatLeft < 0) {
                    MessageBox.Show("Invalid input");
                
                }
                
             //   B.De
                {     cnt.Booking_Histories.InsertOnSubmit(B);
                cnt.SubmitChanges();

                fo = F.TotalSeatLeft.ToString();
                cnt.SubmitChanges();

                MessageBox.Show("Successfully inserted");
            }
            else
            {
                MessageBox.Show("Data not found");

            }
            manage_grid2();
         //   dataGridView2.DataSource = str;
        }

        private void flightcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            fl = flightcombo.Text;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            manage_grid2();
        }

        private void UserPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
       
    }
}
