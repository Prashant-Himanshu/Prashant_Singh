using System.Threading.Channels;

namespace Prashant_Singh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Line Number " + i);
            }
            int i = 0;
            do
            {
                Console.WriteLine("Hello I am from master branch" + i);
                i++;
            } while (i < 10);
        }
    }
}
