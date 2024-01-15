using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace kartya_memoria
{
    public partial class Form1 : Form
    {
        Label[] kartyak;
        int hossz, szelesseg;
        string felirat1 = "";
        string felirat2 = "";
        int ellSzamlalo = 0;
        int parSzamlalo;
        Label par;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            par = new Label()
            {
                Parent = this,
                Text = "Megtalált párok: ",
                AutoSize = true,
                Size = new Size(50, 20),
                Location = new Point(10, 25),
            };
        }
        private void vezerlokMegjelenit(int hossz, int szelesseg)
        {
            int szamlalo = 0;
            int osszes = hossz * szelesseg;

            kartyak = new Label[osszes];
            List<int> feliratok = new List<int>();
            List<int> feliratok1 = new List<int>();
            List<int> feliratok2 = new List<int>();
            for (int i = 1; i < (osszes+2)/2; i++)
            {
                feliratok1.Add(i);
                feliratok2.Add(i);
            }
            feliratok.AddRange(feliratok1);
            feliratok.AddRange(feliratok2);
            listaKever(feliratok);

            for (int i = 0; i < hossz; i++)
            {
                for (int j = 0; j < szelesseg; j++)
                {
                    kartyak[i] = new Label()
                    {
                        Parent = this,
                        Text = feliratok[szamlalo].ToString(),
                        BorderStyle = BorderStyle.FixedSingle,
                        Size = new Size(50, 50),
                        Location = new Point(i * 55 + 10, j * 55 + 70),
                    };
                    szamlalo++;

                    kartyak[i].Click += Ell;
                }
            }
        }
        private void listaKever(List<int> t)
        {
            for (int i = t.Count - 1; i > 0; i--)
            {
                int j = r.Next(0, i + 1);

                int temp = t[i];
                t[i] = t[j];
                t[j] = temp;
            }
        }

        private void Ell(object sender, EventArgs e)
        {
            ellSzamlalo++;
            Label label1 = new Label();
            Label label2 = new Label();
            Label label = sender as Label;

            if (ellSzamlalo == 1)
            {
                label1 = label;
                felirat1 = label1.Text.ToString();
                label1.BackColor = Color.LightBlue;
            }
            else if (ellSzamlalo == 2)
            {
                label2 = label;
                felirat2 = label2.Text.ToString();
                label2.BackColor = Color.LightBlue;

                if (felirat1 == felirat2)
                {
                    ellSzamlalo = 0;
                    parSzamlalo++;
                    label1.BackColor = Color.Green;
                    label2.BackColor = Color.Green;
                    par.Text = "Megtalált párok: " + parSzamlalo;

                    if (parSzamlalo == 8)
                    {
                        MessageBox.Show("WIN!");
                    }
                }
                else
                {
                    ellSzamlalo = 0;
                    label1.BackColor = Color.White;
                    label2.BackColor = Color.White;
                }
            }
        }
        private void x4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hossz = 4;
            szelesseg = 4;
            vezerlokMegjelenit(hossz, szelesseg);
        }
        private void x6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hossz = 4;
            szelesseg = 6;
            vezerlokMegjelenit(hossz, szelesseg);
        }
        private void x6ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            hossz = 6;
            szelesseg = 6;
            vezerlokMegjelenit(hossz, szelesseg);
        }
        private void x8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hossz = 6;
            szelesseg = 8;
            vezerlokMegjelenit(hossz, szelesseg);
        }


    }
}
