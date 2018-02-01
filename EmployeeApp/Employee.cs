using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    partial class Employee
    {
        //variables
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        private string empSSN;

   

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
