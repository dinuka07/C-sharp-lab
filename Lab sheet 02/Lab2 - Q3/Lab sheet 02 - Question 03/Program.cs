namespace Lab_sheet_02___Question_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius :");
            double r=Convert.ToInt32(Console.ReadLine());
            double Area = Math.PI* r * r;
            Console.WriteLine("The Area is " + Area);
            double circ = 2 * Math.PI* r;
            Console.WriteLine("The circumference is " + circ);
            Console.ReadKey();
            
        }
    }
}