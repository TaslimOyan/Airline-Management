using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
    class AdminOperation
    {

        public AdminOperation(){}
        public void AddManager(string mname, string mpassword, string memail, string mcontact, int msalary, ManagerList M) {

            if (mname.Equals("") || mpassword.Equals("") || memail.Equals("") || mcontact.Equals("") || msalary.Equals(""))
            {
                M.ErrorMassage("Fill all the entries correctly");
            }

            else
            {
                NAME = mname; PASSWORD = mpassword; PASSWORD = mpassword;EMAIL = memail; CONTACT = mcontact; SALARY=msalary;
                new DataAccess().NewManager(mname, mpassword, memail, mcontact, msalary, M);
            }
        
        }

      
        
        public void AddEmployee(string ename, string contact, string email, string role, int esalary,int workingHour,string offday, Employee_List E)
        {

            if (ename.Equals("") || role.Equals("") || esalary.Equals("") || workingHour.Equals(""))
            {
                E.ErrorMassage("Fill all the entries correctly");
            }

            else
            {
                NAME = ename; EMAIL = email; CONTACT = contact; SALARY = esalary; ROLE = role; HOUR = workingHour; OFF = offday;
                new DataAccess().NewEmployee(ename,contact,email,role,esalary,workingHour,offday,E);
            }

        }

    
        
        
        public void SearchMan(int s,string mname, string mpassword, string memail, string mcontact, int msalary, ManagerList m) {

           ID = s; NAME = mname;PASSWORD = mpassword; EMAIL = memail; CONTACT = mcontact; SALARY = msalary;
      
         /*   if (ID == a) {

                m.ErrorMassage("No data found");
            } */
         //  new DataAccess().SearchManager(ID,NAME,PASSWORD,EMAIL,CONTACT,SALARY,this,m);
         //  new DataAccess().SearchManager(s,mname, mpassword, memail, mcontact, msalary,this, m);
         //  new DataAccess().GetManagerData(s, mname, mpassword, memail, mcontact, msalary, m);
        }

      
        
        public void RemoveMan(int s, string mname, string mpassword, string memail, string mcontact, int msalary, ManagerList me) {

            NAME = mname; PASSWORD = mpassword; PASSWORD = mpassword; EMAIL = memail; CONTACT = mcontact; SALARY = msalary;
            new DataAccess().DeleteManager(s, mname, mpassword, memail, mcontact, msalary, me);
            me.ErrorMassage2("One Row deleted");
        
        }
        public void EditMan(int s, string mname, string mpassword, string memail, string mcontact, int msalary, ManagerList me) {

            NAME = mname; PASSWORD = mpassword; PASSWORD = mpassword; EMAIL = memail; CONTACT = mcontact; SALARY = msalary;
            new DataAccess().UpdateManager(s, mname, mpassword, memail, mcontact, msalary, me);
            me.ErrorMassage3("One Row Updated");
        
        }


        public int ID
        {
            get;
            set;
        }

        public string NAME
        {
            get;
            set;
        }
        public string PASSWORD
        {
            get;
            set;
        }
        public string EMAIL

        {
            get;
            set;
        }
        public string CONTACT
        {
            get;
            set;
        }
        public int SALARY
        {
            get;
            set;
        }
        public int HOUR
        {
            get;
            set;
        }
        public string OFF
        {
            get;
            set;
        }
        public string ROLE
        {
            get;
            set;
        }
       
    }



   
}

