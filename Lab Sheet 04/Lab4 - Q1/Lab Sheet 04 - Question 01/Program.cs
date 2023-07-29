using static Lab_Sheet_04___Question_01.kilometerTOmeter;

namespace Lab_Sheet_04___Question_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Kilometer Value : ");
            double km = double.Parse(Console.ReadLine());
            ConvertValues.kilometerTOmeter(km);
        }

    }
}