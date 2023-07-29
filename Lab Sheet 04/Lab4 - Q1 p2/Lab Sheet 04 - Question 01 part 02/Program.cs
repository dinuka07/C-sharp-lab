namespace Lab_Sheet_04___Question_01_part_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
        kilometerTOmeter cv = new kilometerTOmeter();
        double km = double.Parse(Console.ReadLine());
        cv.ConvertValues(km);
        }
    }
}