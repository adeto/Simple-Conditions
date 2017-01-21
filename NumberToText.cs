using System;

namespace _04.Number_0_9_To_Text
{
    class NumberToText
    {
        static void Main()
        {
            var i = int.Parse(Console.ReadLine());

            if (i == 0)
            {
                Console.WriteLine("zero");
            }

            else if (i == 1)
            {
                Console.WriteLine("one");
            }
           
            else if (i == 2)
            {
                Console.WriteLine("two");
            }
            
            else if (i == 3)
            {
                Console.WriteLine("three");
            }
            
            else if (i ==4)
            {
                Console.WriteLine("four");
            }
            
            else if (i == 5)
            {
                Console.WriteLine("five");
            }
            
            else if (i == 6)
            {
                Console.WriteLine("six");
            }
            
            else if (i == 7)
            {
                Console.WriteLine("seven");
            }
            
            else if (i == 8)
            {
                Console.WriteLine("eight");
            }
            
            else if (i == 9)
            {
                Console.WriteLine("nine");
            }
            else
            {
                Console.WriteLine("number too big");
            }
        }
    }
}
