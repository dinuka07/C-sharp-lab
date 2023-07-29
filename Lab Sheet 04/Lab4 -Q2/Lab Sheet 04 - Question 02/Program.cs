namespace Lab_Sheet_04___Question_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double radius = double.Parse(Console.ReadLine());
            FindValues fv = new FindValues();

            double area = fv.findArea(radius);

            double circumference = fv.findCircumference(radius);

            Console.WriteLine("The area of the circle is: {0}", area);
            Console.WriteLine("The circumference of the circle is: {0}", circumference);
        }
    
    }
}