using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kamion_oop_form
{
    public class Kamion
    {
        public static string znacka_kamionu;
        public static int maximalni_nosnost;
        public static int minimalni_nosnost;
        public static int stav;

        public Kamion(string znacka, int nosnost)
        {
            znacka_kamionu = znacka;
            maximalni_nosnost = nosnost;
        }
        public string Info()
        {
            return $"Kamion znacky {znacka_kamionu} o maximální nosnosti {maximalni_nosnost} kg";
        }
        public static int Stav()
        {
            return stav;
        }

        /// <pridat>
        /// pridat podminku na prekroceni limitu pri pridavani hodnot
        ///    
      

        public static int Nakladka(int hodnota)
        {
            if (hodnota < maximalni_nosnost)
            {
                stav += hodnota;
                return stav;
            }
            else if (stav + hodnota > maximalni_nosnost)
            {
                return 0;
            }
            return stav;
        }
        public static int Vykladka(int hodnota)
        {

            if (hodnota > minimalni_nosnost)
            {
                stav -= hodnota;
                return stav;
            }
            else if (stav - hodnota < minimalni_nosnost)
            {
                return 0;
            }
            return stav;
        }
        public static int Zaparkovat()
        {
            stav = 0;
            return stav;

        }

     
    }


}
