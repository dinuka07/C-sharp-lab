using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_sheet_05__Question_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindMinMaxAverageReverse arrayClass = new FindMinMaxAverageReverse();
            int[] array = arrayClass.CreateArray();

            arrayClass.FindMinMaxAverage(array);
            arrayClass.ReverseArray(array);
        }
    }
}
