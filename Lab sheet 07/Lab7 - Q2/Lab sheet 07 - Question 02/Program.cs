using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_sheet_07___Question_02
{
    public class Animal
    {
        public void IAmAnimal()
        {
            Console.WriteLine("I am Animal");
        }
    }

    public class Dog : Animal
    {
        public void IHaveFourLegs()
        {
            Console.WriteLine("I have four legs");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            dog.IAmAnimal();

            dog.IHaveFourLegs();
            Console.ReadKey();
        }
    }
}
