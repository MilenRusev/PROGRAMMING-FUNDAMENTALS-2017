using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string some = (Console.ReadLine());

            if (some == "a" || some == "e" || some == "i" || some == "u" || some == "o")
            {
                Console.WriteLine("vowel");
            }
            else if (some == "1" || some == "2" || some == "3" || some == "4" || some == "5" || some == "6" || some == "7" || some == "8" || some == "9" || some == "0")
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
            
        }
    }
}
