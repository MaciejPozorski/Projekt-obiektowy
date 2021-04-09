using System;
using System.Collections.Generic;
using System.Text;

namespace Ostatni_świecie
{
    class Travel
    {
        
        public void Traveling()
        {
            bool start = true;

            while(start == true)
            {
                Console.Clear();
                Console.WriteLine("|===============================|");
                Console.WriteLine("|      Podaj czas podróży:      |");
                Console.WriteLine("|===============================|");

                try
                {
                    int time = Convert.ToInt32(Console.ReadLine());

                    Random();

                    start = false;
                }
                catch (System.FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Tak to się nie uda! Podaj ile godzin.");
                    Console.ReadKey();
                    Console.Clear();
                }


            }
        }
        public void Animation()
        {
            
        }
        public void Random()
        {
            Random random = new Random();
            Events events = new Events();

            int draw = random.Next(2);

            if(draw != 0)
            {
                events.DrawEvent(draw);
            }
        }
    }
}
