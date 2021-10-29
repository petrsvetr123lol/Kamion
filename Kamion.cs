using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kamion_oop_form
{
    class Kamion
    {
        public string znacka_kamionu;
        public int maximalni_nosnost;

        public Kamion(string znacka, int nosnost)
        {
            znacka_kamionu = znacka;
            maximalni_nosnost = nosnost;
        }
        public string info()
        {
            return "Kamion znacky " +znacka_kamionu +  " o maximální nosnosti " + maximalni_nosnost ;
        }
        public string cistic()
        {
            return "";
        }

     
    }


}
