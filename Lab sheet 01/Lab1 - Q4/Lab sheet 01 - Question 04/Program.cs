namespace Lab_sheet_01___Question_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary, tax,new_salary;
            Console.Write("Enter your salary:");
            salary=double.Parse(Console.ReadLine());
            Console.Write("Enter your tax rate:");
            tax=double.Parse(Console.ReadLine());
            new_salary = salary - (salary * tax / 100);
            Console.Write("Your new salary is " + new_salary);
            new_salary = double.Parse(Console.ReadLine());
        }
    }
}