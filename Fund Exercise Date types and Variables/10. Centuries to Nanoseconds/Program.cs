using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = (days * 24);
            decimal minutes = hours * 60;
            decimal seconds =  (minutes * 60);
            decimal milisecons =  (seconds * 1000);
            decimal microseconds = milisecons * 1000;
            decimal nanoseconds =  (microseconds * 1000);

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milisecons} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
