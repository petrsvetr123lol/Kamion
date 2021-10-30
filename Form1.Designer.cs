
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
            this.vaha = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radio_nalozit = new System.Windows.Forms.RadioButton();
            this.radio_vylozit = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.naklad = new System.Windows.Forms.Label();
            this.textbox_naklad = new System.Windows.Forms.TextBox();
            this.label_udaje = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nakládka";
            // 
            // textbox_znacka
            // 
            this.textbox_znacka.Location = new System.Drawing.Point(160, 84);
            this.textbox_znacka.Name = "textbox_znacka";
            this.textbox_znacka.Size = new System.Drawing.Size(177, 20);
            this.textbox_znacka.TabIndex = 1;
            // 
            // textbox_nosnost
            // 
            this.textbox_nosnost.Location = new System.Drawing.Point(160, 110);
            this.textbox_nosnost.Name = "textbox_nosnost";
            this.textbox_nosnost.Size = new System.Drawing.Size(177, 20);
            this.textbox_nosnost.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(28, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Značka kamionu\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(15, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Maximální nosnost\r\n";
            // 
            // button_nastavit
            // 
            this.button_nastavit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_nastavit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_nastavit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_nastavit.ForeColor = System.Drawing.Color.Black;
            this.button_nastavit.Location = new System.Drawing.Point(357, 82);
            this.button_nastavit.Name = "button_nastavit";
            this.button_nastavit.Size = new System.Drawing.Size(75, 48);
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
            this.button2.Location = new System.Drawing.Point(438, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 48);
            this.button2.TabIndex = 6;
            this.button2.Text = "Resetovat";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(24, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kamion:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.vaha);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.radio_nalozit);
            this.panel1.Controls.Add(this.radio_vylozit);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.naklad);
            this.panel1.Controls.Add(this.textbox_naklad);
            this.panel1.Controls.Add(this.label_udaje);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(26, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 108);
            this.panel1.TabIndex = 10;
            // 
            // vaha
            // 
            this.vaha.AutoSize = true;
            this.vaha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vaha.Location = new System.Drawing.Point(272, 47);
            this.vaha.Name = "vaha";
            this.vaha.Size = new System.Drawing.Size(19, 13);
            this.vaha.TabIndex = 16;
            this.vaha.Text = "kg";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(23, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Stav kamoinu:";
            // 
            // radio_nalozit
            // 
            this.radio_nalozit.AutoSize = true;
            this.radio_nalozit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_nalozit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radio_nalozit.Location = new System.Drawing.Point(307, 45);
            this.radio_nalozit.Name = "radio_nalozit";
            this.radio_nalozit.Size = new System.Drawing.Size(57, 17);
            this.radio_nalozit.TabIndex = 14;
            this.radio_nalozit.TabStop = true;
            this.radio_nalozit.Text = "Naložit";
            this.radio_nalozit.UseVisualStyleBackColor = true;
            // 
            // radio_vylozit
            // 
            this.radio_vylozit.AutoSize = true;
            this.radio_vylozit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_vylozit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radio_vylozit.Location = new System.Drawing.Point(370, 45);
            this.radio_vylozit.Name = "radio_vylozit";
            this.radio_vylozit.Size = new System.Drawing.Size(55, 17);
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
            this.button5.Location = new System.Drawing.Point(307, 68);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Nalož/vylož";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // naklad
            // 
            this.naklad.AutoSize = true;
            this.naklad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.naklad.Location = new System.Drawing.Point(24, 44);
            this.naklad.Name = "naklad";
            this.naklad.Size = new System.Drawing.Size(44, 13);
            this.naklad.TabIndex = 12;
            this.naklad.Text = "Náklad:";
            // 
            // textbox_naklad
            // 
            this.textbox_naklad.Location = new System.Drawing.Point(90, 44);
            this.textbox_naklad.Name = "textbox_naklad";
            this.textbox_naklad.Size = new System.Drawing.Size(176, 20);
            this.textbox_naklad.TabIndex = 11;
            // 
            // label_udaje
            // 
            this.label_udaje.AutoSize = true;
            this.label_udaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_udaje.Location = new System.Drawing.Point(87, 14);
            this.label_udaje.Name = "label_udaje";
            this.label_udaje.Size = new System.Drawing.Size(104, 13);
            this.label_udaje.TabIndex = 10;
            this.label_udaje.Text = "Nastavte údaje výše";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(550, 277);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_nastavit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_nosnost);
            this.Controls.Add(this.textbox_znacka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }
}

