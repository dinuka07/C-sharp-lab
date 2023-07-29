using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Sheet__06___Question_01
{
    internal class ArrayClass
    {
        public int[] CreateArray(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter value for array index {0}: ", i);
                int value = Convert.ToInt32(Console.ReadLine());
                array[i] = value;
                array[i + 1] = 0;
            }

            return array;
        }

        public void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array[{0}] = {1}", i, array[i]);
            }
            Console.ReadKey();  
        }
    }
}
