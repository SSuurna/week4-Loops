using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis numbri ära arvata, siis ta on võitnud;
            //katsete arv piiramatu;
            //programm genereerib juhusliku numbri ühe korra;

            Random rnd = new Random();
            bool loopActive = true;
            
            while (loopActive)
            {
                int cpuNumber = rnd.Next(1, 11);
                Console.WriteLine("Arva number:");

                int userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Palju õnne! Oled võitnud.");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("Proovi uuesti!");
                }
            }
        }
    }
}
