using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.LinkLabel;
using System.Net.NetworkInformation;


namespace emlosok_forms
{
    public partial class kep_adatai : Form
    {
        List<string[]> txt;
        List<string> fajok;
        string kivFaj;

        ComboBox CBfajok;
        Label fajAdatok, fajlnev, eleresi_ut, meret, letrehozas_ideje;
        PictureBox fajKep;

        public kep_adatai()
        {
            InitializeComponent();
        }

        private void kep_adatai_Load(object sender, EventArgs e)
        {
            Text = "Kiválasztott emlős adatai";
            Size = new Size(900, 500);

            beolvasEsFeltolt();
        }

        private void CBfajok_SelectedIndexChanged(object sender, EventArgs e)
        {
            fajlnev = new Label()
            {
                Parent = this,
                Location = new Point(20, 80),
                AutoSize = true,
            };
            eleresi_ut = new Label()
            {
                Parent = this,
                Location = new Point(20, 400),
                AutoSize = true,
            };
            meret = new Label()
            {
                Parent = this,
                Location = new Point(20, 110),
                AutoSize = true,
            };
            letrehozas_ideje = new Label()
            {
                Parent = this,
                Location = new Point(20, 140),
                AutoSize = true,
            };

            fajAdatok = new Label()
            {
                Parent = this,
                Location = new Point(20, 430),
                AutoSize = true,
            };
            fajKep = new PictureBox()
            {
                Parent = this,
                Location = new Point(310, 20),
                Size = new Size(400, 300),
                SizeMode = PictureBoxSizeMode.Zoom,
            };

            kivFaj = CBfajok.SelectedValue.ToString();
            string[] kivalasztottSor = null;

            for (int i = 0; i < txt.Count; i++)
            {
                if (txt[i][4] == kivFaj)
                {
                    kivalasztottSor = txt[i];
                }
            }

            if (kivalasztottSor != null)
            {
                fajAdatok.Text = string.Join(", ", kivalasztottSor);
            }
            else
            {
                fajAdatok.Text = "Nincs találat.";
            }
            fajKep.Image = Image.FromFile(@"képek\" + kivFaj + ".jpg");

            Text = kivFaj+" adatai";

            fajlnev.Text = kivFaj + ".jpg";
            eleresi_ut.Text = @"D:\boronkay\14p\keta\emlosok\emlosok_forms\emlosok_forms\bin\Debug\képek\" + kivFaj + ".jpg";
            
            long kepMeret = new FileInfo(@"képek\" + kivFaj + ".jpg").Length;
            meret.Text = kepMeret/1024 + " KB";
            
            DateTime ido = new FileInfo(@"képek\" + kivFaj + ".jpg").CreationTime;
            letrehozas_ideje.Text = ido.ToString();
        }
        private void beolvasEsFeltolt()
        {
            txt = new List<string[]>();
            fajok = new List<string>();
            string[] be = File.ReadAllLines("fajok.txt", Encoding.Default);

            for (int i = 0; i < be.Length; i++)
            {
                string[] ertekek = be[i].Split('\t');
                txt.Add(ertekek);
            }

            for (int i = 0; i < txt.Count; i++)
            {
                if (i != 0)
                {
                    fajok.Add(txt[i][4]);
                }
                
            }
            CBfajok = new ComboBox()
            {
                Parent = this,
                Location = new Point(20, 20),
                Size = new Size(200, 100),
            };
            
            
            CBfajok.DataSource= fajok;
            CBfajok.SelectedIndexChanged += CBfajok_SelectedIndexChanged;
        }

    }
}
