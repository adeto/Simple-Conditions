using System;

namespace _07.SumSeconds
{
    class Sum_Second
    {
        static void Main()
        {
            var firstTime = int.Parse(Console.ReadLine());
            var secondTime = int.Parse(Console.ReadLine());
            var thirdTime = int.Parse(Console.ReadLine());

            int result = (firstTime + secondTime + thirdTime) * 60;
            Console.WriteLine(result);

        }
    }
}
