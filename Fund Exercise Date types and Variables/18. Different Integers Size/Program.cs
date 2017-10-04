using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string input =  (Console.ReadLine());

            try
            {
                long num2 = long.Parse(input);
                //long num2 = long.Parse(input);
                Console.WriteLine($"{input} can fit in:");
                
                if (num2 >= sbyte.MinValue && num2 <= sbyte.MaxValue)
                {
                    Console.WriteLine($"* sbyte");
                }
                if (num2 >= byte.MinValue && num2 <= byte.MaxValue)
                {
                    Console.WriteLine($"* byte");
                }
                if (num2 >= short.MinValue && num2 <= short.MaxValue)
                {
                    Console.WriteLine($"* short");
                }
                if (num2 >= ushort.MinValue && num2 <= ushort.MaxValue)
                {
                    Console.WriteLine($"* ushort");
                }
                if (num2 >= int.MinValue && num2 <= int.MaxValue)
                {
                    Console.WriteLine($"* int");
                }
                if (num2 >= uint.MinValue && num2 <= uint.MaxValue)
                {
                    Console.WriteLine($"* uint");
                }
                if (num2 >= long.MinValue && num2 <= long.MaxValue)
                {
                    Console.WriteLine($"* long");
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine($"{input} can't fit in any type");
            }
        }
    }
}
