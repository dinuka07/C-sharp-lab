namespace Lab_Sheet_03___Question_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            Console.Write("Enter the number:");
            int no = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= no; i += 2)
            {
                sum += i;
            }
            Console.WriteLine("The sum of the odd numbers from 0 to {0} is: {1}", no, sum);
        }
    }
}