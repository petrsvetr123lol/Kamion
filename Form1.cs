using System;
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
        public string cistic()
        {
            return "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            string znacka = textbox_znacka.Text;
            int nosnost = int.Parse(textbox_nosnost.Text);
            Kamion kamion = new Kamion(znacka, nosnost);
            label_udaje.Text = kamion.info();
            button_nastavit.Enabled = false;
            textbox_nosnost.Enabled = false;
            textbox_znacka.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Nenastavil jste žádnou hondotu");
            }
          
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_nastavit.Enabled = true;
            textbox_znacka.Enabled = true;
            textbox_nosnost.Enabled = true;
            textbox_nosnost.Text = "";
            textbox_znacka.Text = "";
            label_udaje.Text = cistic();
        }
    }
}
