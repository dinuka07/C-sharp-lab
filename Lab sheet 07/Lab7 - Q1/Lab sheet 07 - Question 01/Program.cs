namespace Lab_sheet_07___Question_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the size of the arrays: ");
            int size = int.Parse(Console.ReadLine());

            
            int[] array1 = new int[size];
            int[] array2 = new int[size];

            
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter element {0} of array1: ", i + 1);
                array1[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter element {0} of array2: ", i + 1);
                array2[i] = int.Parse(Console.ReadLine());
            }

           
            int scalar_sum = 0;
            for (int i = 0; i < size; i++)
            {
                scalar_sum += array1[i] + array2[i];
            }

            
            int[] vector_sum = new int[size];
            for (int i = 0; i < size; i++)
            {
                vector_sum[i] = array1[i] + array2[i];
            }

           
            int[] vector_product = new int[size];
            for (int i = 0; i < size; i++)
            {
                vector_product[i] = array1[i] * array2[i];
            }

            
            int scalar_product = 0;
            for (int i = 0; i < size; i++)
            {
                scalar_product += vector_product[i];
            }

            
            Console.WriteLine("Scalar sum: {0}\n", scalar_sum);
            Console.WriteLine("Vector sum: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write("{0} ", vector_sum[i]);
            }
            Console.WriteLine("\nVector product: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write("{0} ", vector_product[i]);
            }
            Console.WriteLine("\nScalar product: {0}\n", scalar_product);
        }
    }
}