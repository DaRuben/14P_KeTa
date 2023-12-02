using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace szinozon
{
    public partial class Form1 : Form
    {
        Label sz1, sz2, kitalal1, kitalal2, rejt1, rejt2;
        int sorokSzama = 1, ellSzam = 1, szin1Szamlalo = 0, szin2Szamlalo = 0;
        string szin1, szin2, bc1, bc2;
        List<Color> szinek, szinek2;
        Button ell;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            szinek = new List<Color>
            {
                Color.Red,
                Color.Green,
                Color.Blue,
                Color.Yellow,
                Color.Magenta,
                Color.Orange,
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            szinek2 = new List<Color>
            {
                Color.Red,
                Color.Green,
                Color.Blue,
                Color.Yellow,
                Color.Magenta,
                Color.Orange,
            };

            Text = "Színözön";
            Size = new Size(300, 600);

            int szin_i1 = r.Next(szinek2.Count);
            int szin_i2 = r.Next(szinek2.Count - 1);

            sz1 = new Label()
            {
                Parent = this,
                Location = new Point(50, 5),
                Size = new Size(40, 40),
                BackColor = szinek2[szin_i1],
                BorderStyle = BorderStyle.FixedSingle,
                Visible = false,
            };
            szinek2.Remove(szinek2[szin_i1]);
            szin1 = sz1.BackColor.ToString();

            sz2 = new Label()
            {
                Parent = this,
                Location = new Point(100, 5),
                Size = new Size(40, 40),
                BackColor = szinek2[szin_i2],
                BorderStyle = BorderStyle.FixedSingle,
                Visible = false,
            };
            szin2 = sz2.BackColor.ToString();

            rejt1 = new Label()
            {
                Parent = this,
                Location = new Point(50, 5),
                Size = new Size(40, 40),
                BorderStyle = BorderStyle.FixedSingle,
            };
            rejt2 = new Label()
            {
                Parent = this,
                Location = new Point(100, 5),
                Size = new Size(40, 40),
                BorderStyle = BorderStyle.FixedSingle,
            };


            labels();
            ell = new Button()
            {
                Parent = this,
                Location = new Point(170, 5),
                Size = new Size(70, 30),
                Text = "Ellenőrzés",
            };
            ell.Click += Ell_Click;
        }
        private void Ell_Click(object sender, EventArgs e)
        {
            // szin1 szin2
            //  bc1   bc2
            bool jo1 = false;
            bool jo2 = false;

            if (ellSzam < 8)
            {
                string szurke = Color.LightGray.ToString();
                if (bc1 != szurke)
                {
                    if (bc1 == szin1)
                    {
                        MessageBox.Show("1. van, jó helyen");
                        jo1 = true;
                    }
                    else if (bc1 == szin2)
                    {
                        MessageBox.Show("1. van, rossz helyen");
                    }
                    else if (bc1 != szin1)
                    {
                        MessageBox.Show("1. nincs");
                    }
                }
                if (bc2 != szurke)
                {
                    if (bc2 == szin2)
                    {
                        MessageBox.Show("2. van, jó helyen");
                        jo2 = true;
                    }
                    else if (bc2 == szin1)
                    {
                        MessageBox.Show("2. van, rossz helyen");
                    }
                    else if (bc2 != szin2)
                    {
                        MessageBox.Show("2. nincs");
                    }
                }
                labels();
                ellSzam++;
            }
            else
            {
                MessageBox.Show("Nem találta ki, nincs több lehetőség!");
            }
            if (jo1 && jo2)
            {
                MessageBox.Show("Kitalálta mindkét színt!");
                sz1.Visible = true;
                sz2.Visible = true;
            }
        }
        private void labels()
        {
            int meret = 40;
            kitalal1 = new Label()
            {
                Size = new Size(meret, meret),
                Location = new Point(10 + meret, sorokSzama * (meret + 15)),
                BackColor = Color.LightGray,
            };
            this.Controls.Add(kitalal1);
            kitalal2 = new Label()
            {
                Size = new Size(meret, meret),
                Location = new Point(20 + meret * 2, sorokSzama * (meret + 15)),
                BackColor = Color.LightGray,
            };
            this.Controls.Add(kitalal2);
            sorokSzama++;

            kitalal1.Click += kitalal1_Click;
            kitalal2.Click += kitalal2_Click;
        }
        private void kitalal1_Click(object sender, EventArgs e)
        {
            if (szin1Szamlalo >= 0 && szin1Szamlalo < szinek.Count)
            {
                kitalal1.BackColor = szinek[szin1Szamlalo];
                szin1Szamlalo++;

                if (szin1Szamlalo == szinek.Count)
                {
                    szin1Szamlalo = 0;
                }
            }
            bc1 = kitalal1.BackColor.ToString();
        }
        private void kitalal2_Click(object sender, EventArgs e)
        {
            if (szin2Szamlalo >= 0 && szin2Szamlalo < szinek.Count)
            {
                kitalal2.BackColor = szinek[szin2Szamlalo];
                szin2Szamlalo++;

                if (szin2Szamlalo == szinek.Count)
                {
                    szin2Szamlalo = 0;
                }
            }
            bc2 = kitalal2.BackColor.ToString();
        }


    }
}
