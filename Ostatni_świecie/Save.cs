using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

// plik z statystykami najduje się w Ostatni_swiecie >> bin >> Debug >> netcoreapp3.1

namespace Ostatni_świecie
{
    class Save
    {
        public static void SaveStats()
        {

            string path = @"stats.txt";
             using (StreamWriter sw = File.CreateText(path))
             {

                sw.WriteLine(Stats.Battery);
                sw.WriteLine(Stats.Km);
                sw.WriteLine(Stats.Strength);
                sw.WriteLine(Stats.RepairCost);
                sw.WriteLine(Stats.WitchEvent);
             } 
        
            
            Console.WriteLine("Pomyślnie zapisano naciśnij dowolny klawisz aby kontynuować");
            Console.ReadKey(true);
            Console.Clear();

          
                
            
        }
    }
}
