using Lottery.moodle;
using System;
using System.Diagnostics.Tracing;
using System.Dynamic;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            LotteryTicket ticket = new LotteryTicket(random.Next(100000, 999999));
            string stringNumber = Convert.ToString(ticket.NumberCode);
            string[] numbers = new string[stringNumber.Length];
            string[] stars = new string[stringNumber.Length];
            Console.Write(stringNumber);
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = "*";
                numbers[i] = stringNumber.Substring(i, 1);
            }
            int counter = 0;
            int gameFinish = 0;
            while (counter < 10)
            {
                if(gameFinish == stringNumber.Length)
                {
                    break;
                }
                counter++;
                Console.WriteLine("Die geheime Zahl lautet: " + counter + "/10" );
                for (int i = 0; i < stars.Length; i++)
                {
                    Console.Write(stars[i]);
                }
                Console.WriteLine();
                Console.WriteLine("Bitte  6stellige Zahl eingeben: ");
                string insert = Console.ReadLine();
                
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (insert.Substring(i, 1) == numbers[i])
                    {
                        stars[i] = numbers[i];
                        gameFinish++;
                    }
                }
            }
            Console.WriteLine("Spiel beendet");
            

            







            Console.ReadKey();
        }
    }
}
