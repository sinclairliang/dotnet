using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Calculator()
        {
            Console.WriteLine("Hello C#");
            int mode;
            Console.WriteLine("Enter Mode, 1 for addition, 2 for subtraction, 3 for Multiplicatation and 4 for division.");
            mode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Two Numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (mode == 1)
            {
                Console.WriteLine(Convert.ToString(num1+num2));
                return;
            }

            if(mode == 2)
            {
                Console.WriteLine(Convert.ToString(num1 - num2));
                return;
            }
            if(mode == 3)
            {
                Console.WriteLine(Convert.ToString(num1 * num2));
                return;

            }
            if (mode == 4)
            {
                Console.WriteLine(Convert.ToString(num1 / num2));
                return;
            }
            else
            {
                Console.WriteLine("Not Supported");
                return;
            }
        }

        static void Main(string[] args)
        {
            List<int> luckyNumbers = new List<int>();
            luckyNumbers.Add(1);
            luckyNumbers.Add(40);

            foreach (int item in luckyNumbers)
            {
                Console.WriteLine(item);
            }
            //Calculator();
        }
    }
}
