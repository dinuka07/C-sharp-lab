namespace Lab_Sheet_02___Question_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("The sum is " + sum);
            int subtraction = num1 - num2;
            Console.WriteLine("The subtraction is " + subtraction);
            int multiplication = num1 * num2;
            Console.WriteLine("The subtraction is " + multiplication);
            float div = num1 / num2;
            Console.WriteLine("The division is " + div);
            Console.ReadKey();
        }
    }
}