using System.Threading.Channels;

namespace Prashant_Singh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine("Hello I am from master branch" + i);
                i++;
            } while (i < 10);
        }
    }
}
