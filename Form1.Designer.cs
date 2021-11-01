
namespace kamion_oop_form
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_znacka = new System.Windows.Forms.TextBox();
            this.textbox_nosnost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_nastavit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label_stav = new System.Windows.Forms.Label();
            this.vaha = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radio_nalozit = new System.Windows.Forms.RadioButton();
            this.radio_vylozit = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.naklad = new System.Windows.Forms.Label();
            this.textbox_naklad = new System.Windows.Forms.TextBox();
            this.label_udaje = new System.Windows.Forms.Label();
            this.label_vysledek = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nakládka";
            // 
            // textbox_znacka
            // 
            this.textbox_znacka.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textbox_znacka.Location = new System.Drawing.Point(240, 123);
            this.textbox_znacka.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textbox_znacka.Name = "textbox_znacka";
            this.textbox_znacka.Size = new System.Drawing.Size(264, 27);
            this.textbox_znacka.TabIndex = 1;
            // 
            // textbox_nosnost
            // 
            this.textbox_nosnost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textbox_nosnost.Location = new System.Drawing.Point(240, 161);
            this.textbox_nosnost.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textbox_nosnost.Name = "textbox_nosnost";
            this.textbox_nosnost.Size = new System.Drawing.Size(264, 27);
            this.textbox_nosnost.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(42, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Značka kamionu\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(23, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Maximální nosnost\r\n";
            // 
            // button_nastavit
            // 
            this.button_nastavit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_nastavit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_nastavit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_nastavit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_nastavit.ForeColor = System.Drawing.Color.Black;
            this.button_nastavit.Location = new System.Drawing.Point(536, 120);
            this.button_nastavit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_nastavit.Name = "button_nastavit";
            this.button_nastavit.Size = new System.Drawing.Size(86, 70);
            this.button_nastavit.TabIndex = 5;
            this.button_nastavit.Text = "Nastavit";
            this.button_nastavit.UseVisualStyleBackColor = false;
            this.button_nastavit.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(630, 120);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 70);
            this.button2.TabIndex = 6;
            this.button2.Text = "Resetovat";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(36, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kamion:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label_vysledek);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label_stav);
            this.panel1.Controls.Add(this.vaha);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.radio_nalozit);
            this.panel1.Controls.Add(this.radio_vylozit);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.naklad);
            this.panel1.Controls.Add(this.textbox_naklad);
            this.panel1.Controls.Add(this.label_udaje);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(18, 219);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 158);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(510, 91);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "Zaparkovat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label_stav
            // 
            this.label_stav.AutoSize = true;
            this.label_stav.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_stav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_stav.Location = new System.Drawing.Point(156, 106);
            this.label_stav.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_stav.Name = "label_stav";
            this.label_stav.Size = new System.Drawing.Size(0, 19);
            this.label_stav.TabIndex = 17;
            // 
            // vaha
            // 
            this.vaha.AutoSize = true;
            this.vaha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vaha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vaha.Location = new System.Drawing.Point(338, 64);
            this.vaha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.vaha.Name = "vaha";
            this.vaha.Size = new System.Drawing.Size(29, 19);
            this.vaha.TabIndex = 16;
            this.vaha.Text = "kg";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(36, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Na kamionu je naloženo (kg)";
            // 
            // radio_nalozit
            // 
            this.radio_nalozit.AutoSize = true;
            this.radio_nalozit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_nalozit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radio_nalozit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radio_nalozit.Location = new System.Drawing.Point(393, 67);
            this.radio_nalozit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radio_nalozit.Name = "radio_nalozit";
            this.radio_nalozit.Size = new System.Drawing.Size(79, 23);
            this.radio_nalozit.TabIndex = 14;
            this.radio_nalozit.TabStop = true;
            this.radio_nalozit.Text = "Naložit";
            this.radio_nalozit.UseVisualStyleBackColor = true;
            // 
            // radio_vylozit
            // 
            this.radio_vylozit.AutoSize = true;
            this.radio_vylozit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_vylozit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radio_vylozit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radio_vylozit.Location = new System.Drawing.Point(393, 98);
            this.radio_vylozit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radio_vylozit.Name = "radio_vylozit";
            this.radio_vylozit.Size = new System.Drawing.Size(76, 23);
            this.radio_vylozit.TabIndex = 13;
            this.radio_vylozit.TabStop = true;
            this.radio_vylozit.Text = "Vyložit";
            this.radio_vylozit.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(510, 49);
            this.button5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 34);
            this.button5.TabIndex = 11;
            this.button5.Text = "Nalož/vylož";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // naklad
            // 
            this.naklad.AutoSize = true;
            this.naklad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.naklad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.naklad.Location = new System.Drawing.Point(36, 64);
            this.naklad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.naklad.Name = "naklad";
            this.naklad.Size = new System.Drawing.Size(71, 19);
            this.naklad.TabIndex = 12;
            this.naklad.Text = "Náklad:";
            // 
            // textbox_naklad
            // 
            this.textbox_naklad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textbox_naklad.Location = new System.Drawing.Point(111, 58);
            this.textbox_naklad.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textbox_naklad.Name = "textbox_naklad";
            this.textbox_naklad.Size = new System.Drawing.Size(216, 27);
            this.textbox_naklad.TabIndex = 11;
            // 
            // label_udaje
            // 
            this.label_udaje.AutoSize = true;
            this.label_udaje.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_udaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_udaje.Location = new System.Drawing.Point(131, 20);
            this.label_udaje.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_udaje.Name = "label_udaje";
            this.label_udaje.Size = new System.Drawing.Size(164, 19);
            this.label_udaje.TabIndex = 10;
            this.label_udaje.Text = "Nastavte údaje výše";
            // 
            // label_vysledek
            // 
            this.label_vysledek.AutoSize = true;
            this.label_vysledek.Location = new System.Drawing.Point(280, 116);
            this.label_vysledek.Name = "label_vysledek";
            this.label_vysledek.Size = new System.Drawing.Size(20, 19);
            this.label_vysledek.TabIndex = 19;
            this.label_vysledek.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(771, 405);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_nastavit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_nosnost);
            this.Controls.Add(this.textbox_znacka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kamion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_znacka;
        private System.Windows.Forms.TextBox textbox_nosnost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_nastavit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radio_nalozit;
        private System.Windows.Forms.RadioButton radio_vylozit;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label naklad;
        private System.Windows.Forms.TextBox textbox_naklad;
        private System.Windows.Forms.Label label_udaje;
        private System.Windows.Forms.Label vaha;
        private System.Windows.Forms.Label label_stav;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_vysledek;
    }
}

