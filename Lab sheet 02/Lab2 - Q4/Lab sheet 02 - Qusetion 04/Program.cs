namespace Lab_sheet_02___Qusetion_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number :");
            int n= Convert.ToInt32(Console.ReadLine()); 
            if (n %2 == 0 )
            {
                Console.WriteLine("Entered number is an Even");
            }
            else
            {
                Console.WriteLine("Entered number is an Odd");
            }
        }
    }
}