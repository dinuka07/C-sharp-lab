using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Sheet_04___Question_01_part_02
{
    internal class kilometerTOmeter
    {
        public void ConvertValues(double km)
        {
            Console.Write("Enter the Kilometer Value :");
            double meter = km * 1000;
            Console.WriteLine("{0} km = {1} m", km, meter);
        }
    }
}
