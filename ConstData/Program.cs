using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    class MyMathClass
    {
        public static readonly double PI;
        static MyMathClass()
        {
            PI = 3.14;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Fun with Const *****\n");
            Console.WriteLine("The value of PI is: {0}", MyMathClass.PI);


            Console.WriteLine("Constants:");
            Console.WriteLine("{0} &\n {1}", constRO.constant1, constRO.constant2);

            Console.ReadLine();
        }
    }
}
