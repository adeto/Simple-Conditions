﻿using System;

namespace _11.Number_Betwen_100_And_200
{
    class Number_100_And_200
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            if (num < 100)
            {
                Console.WriteLine("Less than 100");
            }

            else if (num >= 100 && num <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (num > 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
