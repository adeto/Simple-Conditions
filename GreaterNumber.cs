using System;

namespace Greater_Number
{
    class GreaterNumber
    {
        static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)

            {
                Console.WriteLine("{0}", firstNumber);
            }
            else 
                    {
                       Console.WriteLine("{0}", secondNumber);
             }
        }
    }
}
