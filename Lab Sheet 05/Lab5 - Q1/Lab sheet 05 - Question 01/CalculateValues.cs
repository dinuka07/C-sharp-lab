using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_sheet_05___Question_01
{
    internal class CalculateValues
    {
        public void Addition(int num1, int num2)
        {
            Console.Write("Addition is : " + (num1 + num2));
            Console.ReadKey();
        }

        public void Subtraction(int num1, int num2)
        {
            Console.Write("Subtraction is : " + (num1 - num2));
            Console.ReadKey();
        }

        public void Multiplication(int num1, int num2)
        {
            Console.Write("Multiplication is : " + (num1 * num2));
            Console.ReadKey();
        }

        public void Division(int num1, int num2)
        {
            Console.Write("Division is : " + (num1 / num2));
            Console.ReadKey();
        }
    }
}
