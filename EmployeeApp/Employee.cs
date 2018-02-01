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
        public Employee(string name,int id,float pay)
        {
            empName = name;
            empID = id;
            currPay = pay;
        }

        //methods
      
        public void GiveBonus(float amount)
        {
            currPay += amount;
        }
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID:{0}", empID);
            Console.WriteLine("Pay: {0}", currPay);

        }
        
    }
}
