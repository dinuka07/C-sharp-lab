namespace Lab_Sheet_04___Question_01_part_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Km Value : ");
            double km = double.Parse(Console.ReadLine());
            ConvertValues cv = new ConvertValues();
            double meter = cv.kilometerTOmeter(km);
            Console.WriteLine("{0} km = {1} m", km, meter);
        }
    }
}