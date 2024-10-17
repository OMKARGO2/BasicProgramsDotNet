using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//10.Write a C# program to input basic salary of an employee and calculate its  
//Gross salary according to following: Basic Salary <= 10000 : HRA = 20 %, DA = 80 % Basic Salary <= 20000 : HRA = 25 %, 
//DA = 90 % Basic Salary > 20000 : HRA = 30 %, DA = 95 %


namespace FirstDemo1
{
    internal class GrossSalary
    {
        static void Main(string[] args)
        {
            double bs = 15000;
            double hra;
            double da;
            double gross;

            if (bs <= 10000)
            {
                hra = bs * 0.2;
                da = bs * 0.8;
            }
            else if (bs <= 20000)
            {
                hra = bs * 0.25;
                da = bs * 0.9;
            }
            else
            {
                hra = bs * 0.3;
                da = bs * 0.95;
            }

            gross = bs + hra + da;
            Console.WriteLine("Gross Salary is "+gross);
        }
    }
}
