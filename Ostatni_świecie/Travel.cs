using System;
using System.Collections.Generic;
using System.Text;

namespace Ostatni_świecie
{
    class Travel
    {
        
      
        public static void Traveling()
        {
            bool start = true;
            while (start == true)
            {
                Console.Clear();
                Console.WriteLine("|================================|");
                Console.WriteLine("| Podaj czas podróży (Exit = 0): |");
                Console.WriteLine("|================================|");

                try
                {
                     int time = Convert.ToInt32(Console.ReadLine());

                    if (time >= (Stats.Battery / 10))
                    {
                        Console.Clear();
                        Console.WriteLine("Nie masz wystarczająco energii! Wciśnij dowolny przycisk i spróbuj ponownie.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (time == 0)
                    {
                        start = false;
                        Console.Clear();
                    }
                    else
                    {
                        TravelLoop.tLoop(ref time);       //skaczemy do pętli od podróży razem z podanym przez nas czasem             
                        start = false;
                        Console.Clear();
                    }
                }
                catch (System.FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Tak to się nie uda! Podaj ile godzin. Wciśnij dowolny przycisk i spróbuj ponownie.");
                    Console.ReadKey();
                    Console.Clear();
                }


            }
        }

    }
}
