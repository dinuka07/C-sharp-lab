using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Sheet_04___Question_01
{
    internal class kilometerTOmeter
    {
        public class ConvertValues
        {
            public static void kilometerTOmeter(double km)
            {
                double meter = km * 1000;
                Console.WriteLine("{0} km = {1} m", km, meter);
            }
        }
    }
}
