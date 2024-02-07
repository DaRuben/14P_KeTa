using MyDatabaseMySQL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Dallos_Ruben_kepes_kviz
{
    public partial class jatek : Form
    {
        MyDB db;
        static Random r;
        int szamlalo = 0, pontszam = 0, mp;
        List<int> index, randomKerdeseknek = new List<int>();
        Stopwatch sw = new Stopwatch();

        public jatek()
        {
            InitializeComponent();
            r = new Random();
            db = new MyDB("localhost", "root", "", "kviz");
        }

        public Image ByteArrayToImage(byte[] d)
        {
            MemoryStream ms = new MemoryStream(d);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private void jatek_Load(object sender, System.EventArgs e)
        {
            randomKerdesek();
            if (szamlalo == 0)
            {
                Megjelenit();
            }
        }

        private void Megjelenit()
        {
            sw.Start();

            string sql = "SELECT kerdes FROM `kerdes` WHERE id=" + randomKerdeseknek[szamlalo];
            kerdesLabel.Text = db.SelectOneValue(sql).ToString();

            string sql2 = "SELECT kep FROM `kerdes` WHERE id=" + randomKerdeseknek[szamlalo];
            kepPB.Image = ByteArrayToImage(db.SelectOneValue(sql2));

            string sql3 = "SELECT valasz, helyes FROM `valasz` WHERE k_id=" + randomKerdeseknek[szamlalo];
            List<string[]> valaszok = db.SelectListTable(sql3);

            valasz1.Text = valaszok[0][0];
            valasz1.Tag = valaszok[0][1];

            valasz2.Text = valaszok[1][0];
            valasz2.Tag = valaszok[1][1];

            valasz3.Text = valaszok[2][0];
            valasz3.Tag = valaszok[2][1];

            valasz4.Text = valaszok[3][0];
            valasz4.Tag = valaszok[3][1];

            valasz1.Click += Ell;
            valasz2.Click += Ell;
            valasz3.Click += Ell;
            valasz4.Click += Ell;

            valasz1.BackColor = Color.White;
            valasz2.BackColor = Color.White;
            valasz3.BackColor = Color.White;
            valasz4.BackColor = Color.White;

            szamlalo++;
            if (szamlalo == 24)
            {
                MessageBox.Show("Összes kérdés megválaszolva, Pontszám: " + pontszam);
            }
        }
        private void tovabb_Click(object sender, EventArgs e)
        {
            Megjelenit();
            sw.Reset();
        }

        private void Ell(object sender, EventArgs e)
        {
            Button gomb = (Button)sender;
            sw.Stop();

            if (gomb.Tag.ToString() == "True")
            {
                gomb.BackColor = Color.Green;
                mp = (int)sw.ElapsedMilliseconds / 1000;
                MessageBox.Show(mp.ToString());

                sw.Reset();
                if (mp <= 10 && mp != 0)
                {
                    pontszam = pontszam + 1000;
                    pontszamLabel.Text = pontszam + " pontszám";
                    mp = 0;
                }
                else
                {
                    pontszam = 1000 - mp * 50;
                    pontszamLabel.Text = pontszam + " pontszám";
                    if (pontszam < 50)
                    {
                        pontszam = 50;
                    }
                }
            }
            else
            {
                gomb.BackColor = Color.Red;

            }
        }

        private void randomKerdesek()
        {
            index = new List<int>();
            for (int i = 0; i < 25; i++)
            {
                index.Add(i);
            }
            for (int j = 1; j < 25; j++)
            {
                int rIndex = r.Next(1, index.Count);
                int szam = index[rIndex];
                randomKerdeseknek.Add(szam);
                index.RemoveAt(rIndex);
            }
        }
    }
}


