using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis numbri ära arvata, siis ta on võitnud;
            //katsete arv 3;
            //programm genereerib juhusliku numbri ühe korra;

            Random rnd = new Random();
                {
                int i = 0;
                while (i < 3)
                {
                    {
                        int cpuNumber = rnd.Next(1, 11);
                        Console.WriteLine("Arva number:");

                        int userNumber = Convert.ToInt32(Console.ReadLine());
                        if (userNumber == cpuNumber)
                        {
                            Console.WriteLine("Palju õnne! Oled võitnud.");
                            break;
                        }
                        else
                        {
                            i++;
                            Console.WriteLine($"{3 - i} katset jäänud! Proovi uuesti!");
                        }
                    }
            }
                Console.WriteLine("Game Over!");
           
            
            
            }
        }
    }
}
