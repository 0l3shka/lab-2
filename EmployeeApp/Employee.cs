using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        //variables
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        private string empSSN;

        public string SocialSecurityNumber
        {
            get { return empSSN; }
        }
        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }
        public string Name
        {
            get {return empName;}
            set {
             if (value.Length > 15)
                Console.WriteLine("Error! Name must be less than 16 chars!");
            else
                empName = value;
            }
        }

        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }

        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        public Employee() { }
        public Employee(string name, int id, float pay)
            : this(name, 0, id, pay,"") { }
        public Employee(string name,int age,int id,float pay,string ssn)
        {
           Name = name;
           Age = age;
           ID = id;
           Pay = pay;
            empSSN = ssn;
        }

        //methods
      
        public void GiveBonus(float amount)
        {
           Pay += amount;
        }
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID:{0}", ID);
            Console.WriteLine("Age:{0}", Age);
            Console.WriteLine("Pay: {0}", Pay);

        }
        
    }
}
