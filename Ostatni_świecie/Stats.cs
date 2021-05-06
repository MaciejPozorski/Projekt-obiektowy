using System;
using System.Collections.Generic;
using System.Text;

namespace Ostatni_świecie
{
    class Stats
    {
        // *pola są zapisane z dużej litery ;)*      

        //publiczne, statyczne, pola, z skróconą wersją deklaracji własności
        public static int Battery { get; set; }
        public static int Km { get; set; }
        public static int Strength { get; set; }
        public static int RepairCost { get; set; }
        public static string WitchEvent { get; set; }
        // kiedy wywoływane, ich wartości są zawsze wspóólne 
        // program niejawnie generuje prywatne pola



    }
}
