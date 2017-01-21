using System;

namespace _06.BonusScore
{
    class BonusScore
    {
        static void Main()
        {   
            //This solution will descibe how to calculate bonus score//

            var number = int.Parse(Console.ReadLine());
            var bonScore = 0.0;


            if (number <= 100)
                bonScore = 5;

            else 

            if (number > 100)
                bonScore = number * 0.20;

            else 
        
            if (number > 1000)
                bonScore = number * 0.10;
            
            else
                if (number % 10 == 5)
                    bonScore += 2;

            {
                Console.WriteLine("Bonus score: {0}", bonScore);
            }

            { 
                Console.WriteLine("Total score: {1}", number + bonScore);
            }
           
            }

    }
}
