﻿using System;

namespace _04.Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string decValue = (Console.ReadLine());

            Console.WriteLine(Convert.ToInt32(decValue, 16));
        }
    }
}
