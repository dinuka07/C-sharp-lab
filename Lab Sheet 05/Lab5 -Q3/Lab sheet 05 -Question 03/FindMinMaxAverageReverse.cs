using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_sheet_05__Question_03
{
    internal class FindMinMaxAverageReverse
    {
        public int[] CreateArray()
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter value for array index {0}: ", i);
                int value = int.Parse(Console.ReadLine());
                array[i] = value;
            }

            return array;
        }

        public void FindMinMaxAverage(int[] array)
        {
            int minValue = array[0];
            int maxValue = array[0];
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }

                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }

                sum += array[i];
            }

            float average = sum / array.Length;

            Console.Write("Minimum value is: {0}", minValue);
            Console.Write("Maximum value is: {0}", maxValue);
            Console.Write("Average value is: {0}", average);
        }

        public void ReverseArray(int[] array)
        {
            int[] reversedArray = new int[array.Length];

            for (int i = array.Length - 1; i >= 0; i--)
            {
                reversedArray[array.Length - 1 - i] = array[i];
            }

            Console.Write("Reversed array is: ");
            for (int i = 0; i < reversedArray.Length; i++)
            {
                Console.Write("{0} ", reversedArray[i]);
                
            }
            Console.ReadKey();
        }
        
    }
}
