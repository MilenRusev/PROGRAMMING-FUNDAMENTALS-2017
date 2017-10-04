using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            for (int number = 2; number <= inputNum; number++)
            {
                bool checker = true;
                for (int delio = 2; delio <= Math.Sqrt(number); delio++)
                {
                    if (number % delio == 0)
                    {
                        checker = false;
                        break;
                    }
                }
                Console.WriteLine($"{number} -> {checker}");
            }

        }
    }
}
