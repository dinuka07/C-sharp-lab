using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_sheet_05___Question_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateValues objCAl = new CalculateValues();

            int choice;


            Console.WriteLine("Enter 1 for Addition");
            Console.WriteLine("Enter 2 for Subtraction");
            Console.WriteLine("Enter 3 For Multiplication");
            Console.WriteLine("Enter 4 for Division");

            Console.WriteLine("Enter Your Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    objCAl.Addition(num1, num2);
                    break;
                case 2:
                    objCAl.Subtraction(num1, num2);
                    break;
                case 3:
                    objCAl.Multiplication(num1, num2);
                    break;
                case 4:
                    objCAl.Division(num1, num2);
                    break;
                default:
                    Console.Write("Enter a Valid Operation Option");
                    break;
            }
        }
    }
}
