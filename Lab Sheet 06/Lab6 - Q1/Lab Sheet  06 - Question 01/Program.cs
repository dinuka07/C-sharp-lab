namespace Lab_Sheet__06___Question_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());

            ArrayClass arrayClass = new ArrayClass();
            int[] array = arrayClass.CreateArray(size);
            Console.ReadKey();

            arrayClass.PrintArray(array);
            Console.ReadKey();
        }
    }
}