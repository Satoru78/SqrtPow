using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
   public  class Number
    {
        public double Nmbr(double firstNumber)
        {
        int degree = 2;
               Console.WriteLine(Math.Pow(firstNumber, degree));              
               Console.ReadKey();
            return firstNumber;
        }
        public double NmbrSqrt(double firstNumber)
        {
            Console.WriteLine(Math.Sqrt(firstNumber));
            Console.ReadKey();
            return firstNumber;
        }
    }
}
