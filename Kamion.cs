using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kamion_oop_form
{
    class Kamion
    {
        public string znacka_kamionu {get; set;}
        public int maximalni_nosnost {get; set;}

        public Kamion(string znacka, int nosnost)
        {
            this.znacka_kamionu = znacka;
            this.maximalni_nosnost = nosnost;
        }
        public string info()
        {
            return $"Kamion znacky {znacka_kamionu} o maximální nosnosti {maximalni_nosnost} kg" ;
        }
        public string cistic()
        {
            return "";
        }
        public string stav()
        {
            return "";
        }
        public int nakladka(int nakladka)
        {
            return nakladka;
        }
        public int vykladka()
        {
            return 0;
        }

     
    }


}
