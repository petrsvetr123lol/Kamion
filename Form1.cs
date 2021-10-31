﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kamion_oop_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        

        public string Cistic()
        {
            return "";
        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
            string znacka = textbox_znacka.Text;
            int nosnost = int.Parse(textbox_nosnost.Text);
            Kamion kamion = new Kamion(znacka, nosnost);
            label_udaje.Text = kamion.Info();
            button_nastavit.Enabled = false;
            textbox_nosnost.Enabled = false;
            textbox_znacka.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Nenastavil jste žádný kamion!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_nastavit.Enabled = true;
            textbox_znacka.Enabled = true;
            textbox_nosnost.Enabled = true;
            textbox_nosnost.Text = "";
            textbox_znacka.Text = "";
            label_udaje.Text = Cistic();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool chyba = true;
            try
            {
                int hodnota = int.Parse(textbox_naklad.Text);
                if (radio_nalozit.Checked == true)
                {
                    int stav = Kamion.Nakladka(hodnota);
                    if (stav == 0)
                    {
                        MessageBox.Show("Nenaložilo se nic z důvodu zadání nelogické hodnoty!");
                    }
                    else
                    {
                        label_stav.Text = stav.ToString();
                    }
                    textbox_naklad.Text = "";
                }
                else if (radio_vylozit.Checked == true) 
                {
                    int stav = Kamion.Vykladka(hodnota);
                    if(stav == 0)
                    {
                        MessageBox.Show("Nevyložilo se nic z důvodu zadání nelogické hodnoty!");
                    }
                    else
                    {
                        label_stav.Text = stav.ToString();
                    }
                    textbox_naklad.Text = "";
                }
                if (radio_vylozit.Checked == false && radio_nalozit.Checked == false)
                {
                    MessageBox.Show("Nezaškrtnuté políčko s naložením/vyložením. Zaškrtni ho.");
                }   
               
            }
            catch
            {
                MessageBox.Show("Nezadané nebo chyně zadané hodnoty! Zadej hodnoty znovu.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label_stav.Text = "";
            Kamion.Zaparkovat();
            MessageBox.Show("Kamion byl zaparkován a zboží bylo vyloženo!");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int stav = Kamion.Stav();
            MessageBox.Show($"Aktuálně je naloženo {stav} kg.");
        }
    }
}
