namespace Prashant_Singh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my first git repo to practice");
            Class1 c1 = new Class1();
            c1.Class1Test1();
            Class2 c2 = new Class2();
            c2.Class2Test1();
            Console.WriteLine("Checking merge options");
            int a = 5;
            int b = 5;
            if (a ==b)
            {
                Console.WriteLine("Now merge and conflicts are working");
            }
        }
    }
}
