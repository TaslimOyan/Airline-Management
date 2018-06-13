using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Text.RegularExpressions;

namespace Forms
{
    class Add
    {
        
        public Add() {}
        //checking in signup for user

        public bool ch(string email)
        {
            bool valid = false;
            Regex r = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (r.IsMatch(email))
            {
                valid = true;
            }
            return valid;
        }

        public Add(string fName, string mName, string lName, string uName, string pass, string aPass, string email,string gender, string address, string dOB,SignUp a)
        {
            if (fName.Equals("") || mName.Equals("") || lName.Equals("") || uName.Equals("") || pass.Equals("") || aPass.Equals("") || email.Equals("") || gender.Equals("") || address.Equals("") || dOB.Equals("") || !pass.Equals(aPass))
            {
                a.ErrorMassage("Fill all the entries correctly");
            }


            else
            {
                FNAME = fName; MNAME = mName; LNAME = lName; UNAME = uName; PASS = pass; APASS = aPass; EMAIL = email; GENDER = gender; DOB = dOB; ADDRESS = address;

                if (ch(email))
                {
                    new DataAccess().SignUp(fName, mName, lName, uName, pass, aPass, email, gender, address, dOB, a);
                }
                else
                {
                    a.ErrorMassage("check Email.");
                }
            }
            
        }

        /* Sending status to DataAccess class*/
    /*    public Add(string User, string password,int b, Login l) {

           

                if (b == 0) {
                    
                    new DataAccess().DataLogin(User, password,b,this, l);
                    if (UNAME == User && PASS == password)
                    {

                        Admin_Panel A = new Admin_Panel();
                        A.Show();
                    }
                    else
                    {
                        l.ErrorMassage("please give correct username & password");
                    }

                
                }
                else if (b == 1)
                {
                    
                    new DataAccess().DataLogin(User, password, b,this, l);
                    if (UNAME == User && PASS == password)
                    {
                        ManagerPanel M = new ManagerPanel();
                        M.Show();
                    }
                    else
                    {
                        l.ErrorMassage("please give correct username & password");
                    }

                }
                if (b == 2)
                {
                    
                    new DataAccess().DataLogin(User, password, b,this, l);
                    if (UNAME == User && PASS == password) 
                    {
                        UserPanel U = new UserPanel();
                       U.Initilizer(FNAME, MNAME, LNAME, UNAME, PASS, EMAIL, CONT, GENDER, ADDRESS, DOB,ID);
                        U.Show();
                       
                    }
                    else
                    {
                        l.ErrorMassage("please give correct username & password");
                    }
                    

                }
               

            
            
        
        }
        /**For Reciving from DataAccess class*/
        public Add(string User, string password, Add add, Login l)
        {

            

        }
        
        public Add(string FlName, string time, string Date, string Route, FlightList F) {

            if (FlName.Equals("") || time.Equals("") || Date.Equals("") || Route.Equals(""))
            {

                F.ErrorMassage("Fill all the entries correctly");
            }
            else {
                FLIGHT = FlName; DTIME = time; DATE = Date; ROUTE = Route;
            
            }
        
        
        }
        public int ID
        {
            get;
            set;
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
        public string FLIGHT
        {
            get;
            set;
        }
        public string DATE
        {
            get;
            set;
        }
        public string ROUTE
        {
            get;
            set;
        }
        public string DTIME
        {
            get;
            set;
        }

        

    }
}
