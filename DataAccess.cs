using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;

namespace Forms
{
    class DataAccess
    {
       List<string> Flightlist = new List<string>();
        public DataAccess() {}
        public void SignUp(string fName, string mName, string lName, string uName, string pass, string aPass, string email,  string gender, string address, string dOB, SignUp a)
        {

            MydbDataContext cntx = new MydbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Desktop\Project\Project\Forms\Mydb.mdf;Integrated Security=True");
            Person p = new Person();
            People po = new People();
            cntx.Persons.InsertOnSubmit(p);
            cntx.Peoples.InsertOnSubmit(po);
            
            p.FirstName = fName;
            p.MiddleName = mName;
            p.LastName = lName;
            p.UserName = uName;
            p.Password = pass;
            p.Email = email;
            
            p.Gender = gender;
            p.Address = address;
           
            p.BirthDate = dOB;

            po.UserName = uName;
            po.password = pass;
            po.UserType = "Customer";
            cntx.SubmitChanges();

          
         //   cntx.SubmitChanges();

           

            cntx.Dispose();
            new SignUp().ErrorMassage("successfully signed up");
            
        }
     
   /*     public void DataLogin(string User, string password,int b,Add add,Login l) {

            MydbDataContext cntx = new MydbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Oyan Computer\Desktop\Project\Project\Forms\Mydb.mdf;Integrated Security=True");


               b = l.a;
            
           

           

                if (b == 0)
                {
                    var str = from a2 in cntx.Admins
                              where a2.UserName == User

                              select a2;

                    Admin A = str.First();

                    add.UNAME = A.UserName;
                    add.PASS = A.Password;

                }
         
            
                if (b == 1)
                {
                    var str = from a2 in cntx.Managers
                              where a2.UserName == User

                              select a2;

                     Manager M = str.First();

                    add.UNAME = M.UserName;
                    add.PASS = M.Password;

                }
         
                if (b == 2)
                {
                    var str = from a2 in cntx.Persons
                              where a2.UserName == User

                              select a2;

                    Person p = str.First();

                    add.UNAME = p.UserName;
                    add.PASS = p.Password;
                    add.FNAME = p.FirstName;
                    add.MNAME = p.MiddleName;
                    add.LNAME = p.LastName;
                    add.DOB = p.BirthDate;
                    add.ADDRESS = p.Address;
                   
                    add.EMAIL = p.Email;
                    add.GENDER = p.Gender;
                    add.ID = p.Id;

               
                   //foreach(string k in flightlist)
                    var st = from a3 in cntx.Flights
                
                             select new { Flightlist =a3 };
               
                

                }


                cntx.Dispose();

        }
         
            
            */
            
            


      
        

        public void AddFlight(string flight, string dtime, string ddate, string route, FlightList F) {

            MydbDataContext cntx = new MydbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Oyan Computer\Desktop\Project\Project\Forms\Mydb.mdf;Integrated Security=True");
            Flight fl = new Flight();

            cntx.Flights.InsertOnSubmit(fl);

            fl.Flight_Name = flight;
            fl.Departure_Time = dtime;
            fl.Departure_Date = ddate;
           // fl.Route = route;

            cntx.Dispose();
          //  new ManagerList().ErrorMassage("New Flight Added");
        }
        public void DeleteFlight(int Fno, string flight, string dtime, string ddate, string route, FlightList F) {

            MydbDataContext cntx = new MydbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Oyan Computer\Desktop\Project\Project\Forms\Mydb.mdf;Integrated Security=True");
            var str = from a in cntx.Flights
                      where a.Flight_No==Fno
                      select a;


            Flight fl = str.First();
            cntx.Flights.DeleteOnSubmit(fl);
            cntx.SubmitChanges();

            cntx.Dispose();

        
        }
        public void NewManager(string name, string pass, string email, string contNo, int sal,ManagerList M)
        {

            MydbDataContext cntx = new MydbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Desktop\Project\Project\Forms\Mydb.mdf;Integrated Security=True");
            Manager Man = new Manager();
            People P = new People();


            cntx.Managers.InsertOnSubmit(Man);
            cntx.Peoples.InsertOnSubmit(P);

            Man.UserName = name;
            Man.Password = pass;
            Man.Email = email;
            Man.ContactNo = contNo;
            Man.Salary = sal;

            P.UserName = name;
            P.password = pass;
            P.UserType = "Manager";


            
            cntx.SubmitChanges();


            new ManagerList().ErrorMassage("Successfully added");

            cntx.Dispose();
        }
      /*  public void SearchManager(int ab,string name, string pass, string email, string contNo, int sal,AdminOperation A, ManagerList MO) {

          
        /*    foreach (var x in list)
            {
                productName = x.Item_name;
                quantity = x.Quantity.ToString();
                categoryName = x.Category.Category_name;
                price = x.Unit_price.ToString();
                details = x.Item_description;
                sellerId = x.Seller_id.ToString();
                sellerName = x.Customer.Customer_name;
                phn = x.Customer.Phone_number;
                email = x.Customer.Email;
                country = x.Customer.Addresses.Country.Country_name;

            }
           
            //Manager mo = str.First();
            foreach (var a in str)
            {
              //  ab = a.Id;
                name = a.UserName;
                pass = a.Password;
                email = a.Email;
                contNo = a.ContactNo;
                sal = a.Salary;
 
            }

           
            
            cnt.SubmitChanges();

         }*/

           
        public void DeleteManager(int id, string name, string pass, string email, string contNo, float sal, ManagerList MO) {

            MydbDataContext cntx = new MydbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Oyan Computer\Desktop\Project\Project\Forms\Mydb.mdf;Integrated Security=True");
            var str = from a in cntx.Managers
                      where a.Id == id
                      select a;
            Manager M = str.First();
            cntx.Managers.DeleteOnSubmit(M);
            cntx.SubmitChanges();

        
        }
        public void UpdateManager(int id, string name, string pass, string email, string contNo, int sal, ManagerList MO) {
            
            MydbDataContext cntx = new MydbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Oyan Computer\Desktop\Project\Project\Forms\Mydb.mdf;Integrated Security=True");
            var str = from a in cntx.Managers
                      where a.Id == id
                      select a;
            Manager M = str.First();

            M.Id = id;
            M.UserName = name;
            M.Password = pass;
            M.Email = email;
            M.ContactNo = contNo;
          //  M.Salary = sal;
            M.Salary = sal;

            cntx.SubmitChanges();

            name = M.UserName;
            pass = M.Password;
            email = M.Email;
            contNo = M.ContactNo;
            sal = Convert.ToInt32(M.Salary);

            cntx.SubmitChanges();

            

        
       
        }
        public void GetManagerData(int id, string name, string pass, string email, string contNo, float sal, ManagerList MO)
        {

            MydbDataContext cntx = new MydbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Oyan Computer\Desktop\Project\Project\Forms\Mydb.mdf;Integrated Security=True");

            var str = from a in cntx.Managers

                      where a.Id == id

                      select a;
            //  dataGridView1.DataSource = str;

        }

        public void NewEmployee(string ename, string contact, string email, string role, float esalary, int workingHour, string offday, Employee_List E) {


            MydbDataContext cntx = new MydbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Oyan Computer\Desktop\Project\Project\Forms\Mydb.mdf;Integrated Security=True");
           Employee em = new Employee();


            cntx.Employees.InsertOnSubmit(em);

            em.Name = ename; em.Email = email; em.Role = role; em.Salary = esalary; em.WorkingHour = workingHour; em.OffDay = offday;
        
        }

    }
}
