using static System.Console;
using Library;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World");
            WriteLine($"The answer is {new Thing().Get(17, 23)}");
        }
    }
}