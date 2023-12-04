using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace kaputelefon
{
    public partial class Form1 : Form
    {
        Button[] gombok = new Button[10];
        Button uj;
        List<int> szamok = new List<int>();
        int rsz, szamol = 0;
        string strKod = "";
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Font = new Font("Times", 14f);
            Size = new Size(800, 500);
            Text = "Kaputelefon";
            RandomSzamok();
            Gombok();

            uj = new Button()
            {
                Parent = this,
                Size = new Size(110, 30),
                Location = new Point(30, 240),
                Text = "Új bevitel",
            };
        }

        private void RandomSzamok()
        {
            for (int i = 0; i < 10; i++)
            {
                rsz = r.Next(1, 10);
                if (!szamok.Contains(rsz))
                {
                    szamok.Add(rsz);
                }
            }
        }

        private void Gombok()
        {
            for (int i = 0; i < 10; i++)
            {
                gombok[i] = new Button
                {
                    Parent = this,
                    Size = new Size(50, 50),
                    Location = new Point(i * 60, 60),
                    Text = szamok[i].ToString(),
                };
                gombok[i].Click += gomb1_Click;
            }

        }

        private void gomb1_Click(object sender, EventArgs e)
        {
            string kod = "7428";
            if (strKod.Length == 4)
            {
                if (strKod == kod)
                {
                    MessageBox.Show("Kód megfelelő");
                }
                else
                {
                    MessageBox.Show("Kód hibás");
                }
            }
            else
            {
                if (szamol < 4)
                {
                    Button aktualis = sender as Button;
                    strKod += aktualis.Text;
                    Text = strKod;
                    szamol++;
                }
                else
                {
                    MessageBox.Show("Csak négyet választhat ki!");
                }
                
            }
        }
    }
}
