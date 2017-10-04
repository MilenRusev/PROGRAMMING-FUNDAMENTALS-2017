using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            ushort timeInSecs = (ushort)(hours * 3600 + minutes * 60 + seconds);
            float metersPerSec = (float)distanceMeters / timeInSecs;
            float kilometersPerHour = ((float)distanceMeters / 1000) / ((float)timeInSecs / 3600);
            float milesPerHour = ((float)distanceMeters / 1609) / ((float)timeInSecs / 3600);

            Console.WriteLine($"{metersPerSec}");
            Console.WriteLine($"{kilometersPerHour}");
            Console.WriteLine($"{milesPerHour}");
        }
    }
}
