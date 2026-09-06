using System.Threading.Channels;

namespace Prashant_Singh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prashant application started");

            string name = "Prashant";
            int age = 28;

            Console.WriteLine($"Employee Name: {name}");
            Console.WriteLine($"Employee Age: {age}");

            int number1 = 100;
            int number2 = 50;

            int sum = number1 + number2;
            int difference = number1 - number2;
            int multiplication = number1 * number2;

            Console.WriteLine($"Total Sum: {sum}");
            Console.WriteLine($"Total Difference: {difference}");
            Console.WriteLine($"Total Multiplication: {multiplication}");

            string department = "IT";
            string city = "Mumbai";

            Console.WriteLine($"Employee Department: {department}");
            Console.WriteLine($"Employee City: {city}");

            if (age >= 21)
            {
                Console.WriteLine("Employee is eligible");
            }
            else
            {
                Console.WriteLine("Employee is not eligible");
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Prashant loop value: {i}");
            }

            string[] skills = { "C#", "ASP.NET", "SQL Server", "GitHub" };

            Console.WriteLine("Technical Skills:");

            foreach (string skill in skills)
            {
                Console.WriteLine($"Skill: {skill}");
            }

            Console.WriteLine("Prashant application completed");

        }
    }
}
