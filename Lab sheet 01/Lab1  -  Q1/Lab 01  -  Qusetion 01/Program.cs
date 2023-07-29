namespace Lab_01_Q_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your batch:");
            string batch = Console.ReadLine();

            Console.WriteLine("\nYour name: " + name);
            Console.WriteLine("Your batch: " + batch);

            
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}