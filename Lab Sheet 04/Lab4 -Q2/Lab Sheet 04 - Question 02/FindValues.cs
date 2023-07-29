using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Sheet_04___Question_02
{
    internal class FindValues
    {
        public double findArea(double radius)
        {
           double area = Math.PI * radius * radius;
           return area;
        }
        public double findCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }

    }
}
