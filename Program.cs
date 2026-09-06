using System.Threading.Channels;

namespace Prashant_Singh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application started");

            string name = "Main User";
            int age = 30;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");

            int number1 = 10;
            int number2 = 20;

            int sum = number1 + number2;
            int difference = number2 - number1;
            int multiplication = number1 * number2;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Multiplication: {multiplication}");

            string department = "Development";
            string city = "Pune";

            Console.WriteLine($"Department: {department}");
            Console.WriteLine($"City: {city}");

            if (age >= 18)
            {
                Console.WriteLine("User is an adult");
            }
            else
            {
                Console.WriteLine("User is a minor");
            }

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Main loop value: {i}");
            }

            string[] skills = { "C#", "SQL", "Git", "Azure" };

            Console.WriteLine("Skills:");

            foreach (string skill in skills)
            {
                Console.WriteLine(skill);
            }

            Console.WriteLine("Application completed");
            Class1 c = new Class1();
            c.Class1Test1();
            Class2 c2 = new Class2();
            c2.Class2Test1();
            Console.WriteLine("Pull then push trying");
        }
    }
}
