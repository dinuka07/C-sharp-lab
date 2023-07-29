namespace Lab_Sheet_03___Question_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number :");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}