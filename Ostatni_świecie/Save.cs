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
        int battery;
        int km;
        int strenght;
        int repairCost;
        string witchEvent;
        public void SaveStats()
        {

            Stats stats = new Stats();
            Menu game = new Menu();
            stats.UnloadAll(battery,km,strenght,repairCost,witchEvent);
            string path = @"stats.txt";
             using (StreamWriter sw = File.CreateText(path))
             {

                sw.WriteLine(battery);
                sw.WriteLine(km);
                sw.WriteLine(strenght);
                sw.WriteLine(repairCost);
                sw.WriteLine(witchEvent);
             } 
        
            
            Console.WriteLine("Pomyślnie zapisano naciśnij dowolny klawisz aby kontynuować");
            Console.ReadKey(true);
            Console.Clear();

          
                
            
        }
    }
}
