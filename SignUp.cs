using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Forms
{
    public partial class SignUp : Form
    {
        //DataAccess Da = new DataAccess();

        string tGender;

        Add A = new Add();
        public SignUp()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sign2_Click(object sender, EventArgs e)
        {
           
            /*string email = textBox7.Text;
            if (email.IndexOf('@') == -1 || email.IndexOf('.') == -1) { 
            
                   
            
            }*/
           if(radioButton1.Checked){ tGender ="Male";}
            else if(radioButton2.Checked){ tGender= "Female";}


            Add b = new Add();

           string BirthDay = Date.Value.ToShortDateString();
            Add a=new Add(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,textBox6.Text,textBox7.Text,tGender,textBox9.Text,BirthDay,this);
           

        }
      
        public void ErrorMassage(string msg){
            DialogResult result2 = MessageBox.Show(msg,
      "Important Query",
      MessageBoxButtons.OKCancel,
      MessageBoxIcon.Question);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }

        
        
    }

