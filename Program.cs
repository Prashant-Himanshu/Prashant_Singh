using System.Threading.Channels;

namespace Prashant_Singh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class3 c3 = new Class3 ();
            string str1 = c3.GetName();
            Console.WriteLine(str1);
        }
    }
}
