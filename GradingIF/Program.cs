using System;

namespace GradingIF
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib, mis hinde kasutaja sai
            //kui kasutaja sai 'A', konsool kuvab "Suurepärane!";
            //kui tulemus on 'B', konsool kuvab "Väga hea!";
            //kui tulemus on 'C', konsool kuvab "Hea!";
            //kui tulemus on 'D', konsool kuvab "Rahuldav";
            //kui tulemus on 'E', konsool kuvab "Kasin";
            //kui tulemus on 'F', konsool kuvab "Puudulik";
            //kui kasutaja sisestab midagi muud, siis konsool kuvab "vale väärtus"

            //kasutame IF

            Console.WriteLine("Sisesta oma eksami tulemus:");
            //char - character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());


            if(userResult == 'A')
            {
                Console.WriteLine("Suurepärane!");
            }
            
            else if (userResult == 'B') 
            {
                Console.WriteLine("Väga hea!");
            }
            else if (userResult == 'C') 
            {
                Console.WriteLine("Hea!");
            }
            else if (userResult == 'D') 
            {
                Console.WriteLine("Rahuldav!");
            }
            else if (userResult == 'E') 
            {
                Console.WriteLine("Kasin!");
            }
            else if (userResult == 'F') 
            {
                Console.WriteLine("Puudlik, peate töö uuesti sooritama!");
            }
            else
            {
                Console.WriteLine("Sisestatud väärtus on vale!");
            }

            Console.WriteLine("Kena päeva jätku teile!");







        }
    }
}
