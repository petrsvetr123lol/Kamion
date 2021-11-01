namespace kamion_oop_form
{
    public class Kamion
    {
        public static string znacka_kamionu;
        public static int maximalni_nosnost;
        public static int minimalni_nosnost;
        public static int stav = 0;

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
        public static int Nakladka(int hodnota)
        {
            if (hodnota + stav >= maximalni_nosnost)
            {
                return 1;
            }
            else if (hodnota + stav <= maximalni_nosnost)
            {
                stav += hodnota;
                return stav;
                
            }
            return stav;
        }
        public static int Vykladka(int hodnota)
        {
            if (hodnota - stav >= minimalni_nosnost)
            {
                return 2;
            }
            else if (hodnota - stav <= minimalni_nosnost)
            {
                stav -= hodnota;
                return stav;
            }
            return stav;
        }
        public static int Zaparkovat()
        {
            stav = 0;
            return stav;
        }
        public static string Cistic()
        {
            return "";
        }
    }
}
