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
        public void SaveStats(ref int batery, ref int km)
        {
            Menu game = new Menu();
            string path = @"stats.txt";
             using (StreamWriter sw = File.CreateText(path))
             {

                     sw.Write(batery);
                     sw.WriteLine("");
                     sw.Write(km);

             } 
        
            
            Console.WriteLine("Pomyślnie zapisano naciśnij dowolny klawisz aby kontynuować");
            Console.ReadKey(true);
            Console.Clear();

          
                
            
        }
    }
}
