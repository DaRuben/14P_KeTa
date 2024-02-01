using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace halmazok
{
    public partial class Form1 : Form
    {
        int kivIndex;
        Button beMegad, beGeneral, tovabb;
        TextBox h1Be, h2Be, muvelet;
        NumericUpDown beElemszam, beMin, beMax;
        Label bekerHalmaz, bekerElem, bekerMin, bekerMax, muveletFelirat;

        List<string> h1 = new List<string>();
        List<string> h2 = new List<string>();
        HashSet<string> h1Bekert = new HashSet<string>();
        HashSet<string> h2Bekert = new HashSet<string>();

        Random R = new Random();
        HashSet<int> h1Generalt = new HashSet<int>();
        HashSet<int> h2Generalt = new HashSet<int>();

        ListBox h1Megjelenit, h2Megjelenit;

        ComboBox menupontok;
        string[] menupontFeliratok = { "--Válasszon--", "(1) Számosság", "(2) Két halmaz diszjunkt-e", "(3) Unio", "(4) Metszet", "(5) Különbség", "(6) Descartes-féle szorzathalmaz" };

        halmaz halmaz = new halmaz();

        public Form1()
        {
            InitializeComponent();
            kivIndex = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(460, 600);

            beMegad = new Button()
            {
                Parent = this,
                Location = new Point(10, 10),
                Size = new Size(120, 30),
                Text = "Halmaz megadása",
            };
            beMegad.Click += BeMegad_Click;
            beGeneral = new Button()
            {
                Parent = this,
                Location = new Point(10, 50),
                Size = new Size(120, 30),
                Text = "Halmaz generálása",
            };
            beGeneral.Click += BeGeneral_Click;

            menupontok = new ComboBox()
            {
                Parent = this,
                Location = new Point(180, 10),
                Size = new Size(180, 20),
                DataSource = menupontFeliratok,
            };
            menupontok.SelectedIndexChanged += Menupontok_SelectedIndexChanged;

        }

        private void Menupontok_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            kivIndex = cmb.SelectedIndex;
            switch (kivIndex)
            {
                case 1:
                    beGeneral.Enabled = false;
                    muveletFelirat = new Label()
                    {
                        Parent = this,
                        Location = new Point(130, 250),
                        Text = menupontFeliratok[kivIndex],
                        AutoSize = true,
                    };
                    muvelet = new TextBox()
                    {
                        Parent = this,
                        Location = new Point(130, 270),
                        Size = new Size(350, 20),
                        ReadOnly = true,
                    };
                    if (h1Be != null && h2Be != null)
                    {
                        int szamossag1 = h1Bekert.Count;
                        int szamossag2 = h2Bekert.Count;
                        muvelet.Text = "Első halmaz számossága: " + szamossag1 + ", második halmaz számossága: " + szamossag2;
                    }
                    else
                    {
                        int szamossag1 = h1Generalt.Count;
                        int szamossag2 = h2Generalt.Count;
                        muvelet.Text = "Első halmaz számossága: " + szamossag1 + ", második halmaz számossága: " + szamossag2;
                    }
                    break;
                case 3:
                    muveletFelirat = new Label()
                    {
                        Parent = this,
                        Location = new Point(130, 250),
                        Text = menupontFeliratok[kivIndex],
                        AutoSize = true,
                    };
                    muvelet = new TextBox()
                    {
                        Parent = this,
                        Location = new Point(130, 270),
                        Size = new Size(350, 20),
                        ReadOnly = true,
                    };
                    if (h1Be != null && h2Be != null)
                    {
                       // var unio = halmaz.Unio(h1Bekert, h2Bekert);
                       // muvelet.Text = "A két halmaz uniója: " + unio;
                    }
                    else
                    {
                        var unio = halmaz.Unio(h1Generalt, h2Generalt);
                        muvelet.Text = "A két halmaz uniója: " + unio;
                    }
                    break;

            }
        }

        private void BeMegad_Click(object sender, EventArgs e)
        {
            beGeneral.Enabled = false;
            bekerHalmaz = new Label()
            {
                Parent = this,
                Location = new Point(10, 105),
                Text = "Adja meg a két halmaz elemeit szóközzel elválasztva!",
                AutoSize = true,
            };
            h1Be = new TextBox()
            {
                Parent = this,
                Location = new Point(10, 130),
                Size = new Size(200, 20),
            };
            h2Be = new TextBox()
            {
                Parent = this,
                Location = new Point(10, 160),
                Size = new Size(200, 20),
            };
            tovabb = new Button()
            {
                Parent = this,
                Location = new Point(10, 190),
                Size = new Size(120, 30),
                Text = "Tovább",
            };
            tovabb.Click += Tovabb_Click;

        }

        private void BeGeneral_Click(object sender, EventArgs e)
        {
            beMegad.Enabled = false;
            bekerElem = new Label()
            {
                Parent = this,
                Location = new Point(10, 105),
                Text = "Elemszám:",
                AutoSize = true,
            };
            beElemszam = new NumericUpDown()
            {
                Parent = this,
                Location = new Point(20, 130),
                Size = new Size(60, 20),
            };

            bekerMin = new Label()
            {
                Parent = this,
                Location = new Point(90, 105),
                Text = "Alsó határ:",
                AutoSize = true,
            };
            beMin = new NumericUpDown()
            {
                Parent = this,
                Location = new Point(100, 130),
                Size = new Size(60, 20),
            };

            bekerMax = new Label()
            {
                Parent = this,
                Location = new Point(170, 105),
                Text = "Felső határ:",
                AutoSize = true,
            };
            beMax = new NumericUpDown()
            {
                Parent = this,
                Location = new Point(180, 130),
                Size = new Size(60, 20),
            };

            tovabb = new Button()
            {
                Parent = this,
                Location = new Point(10, 190),
                Size = new Size(120, 30),
                Text = "Tovább",
            };
            tovabb.Click += Tovabb_Click;
        }

        private void Tovabb_Click(object sender, EventArgs e)
        {
            if (h1Be != null && h2Be != null)
            {
                string h1BeLista = h1Be.Text;
                string h2BeLista = h2Be.Text;
                HalmazBeker(h1BeLista, h2BeLista);
            }
            else
            {
                int elemszam = (int)beElemszam.Value;
                int minH = (int)beMin.Value;
                int maxH = (int)beMax.Value;

                HalmazGeneral(elemszam, minH, maxH, h1Generalt);
                HalmazGeneral(elemszam, minH, maxH, h2Generalt);
            }
        }

        public void HalmazBeker(string h1Be, string h2Be)
        {
            for (int i = 0; i < (h1Be.Length / 2) + 1; i++)
            {
                string[] sv = h1Be.Split(' ');
                h1.Add(sv[i]);
            }
            for (int i = 0; i < (h2Be.Length / 2) + 1; i++)
            {
                string[] sv = h2Be.Split(' ');
                h2.Add(sv[i]);
            }
            h1Bekert = h1.ToHashSet();
            h2Bekert = h2.ToHashSet();

            h1Megjelenit = new ListBox()
            {
                Parent = this,
                Location = new Point(10, 240),
                Size = new Size(50, 300),
            };
            foreach (var elem in h1Bekert)
            {
                h1Megjelenit.Items.Add(elem);
            }

            h2Megjelenit = new ListBox()
            {
                Parent = this,
                Location = new Point(70, 240),
                Size = new Size(50, 300),
            };
            foreach (var elem in h2Bekert)
            {
                h2Megjelenit.Items.Add(elem);
            }
        }
        public void HalmazGeneral(int db, int minH, int maxH, HashSet<int> halmaz)
        {
            List<int> seged = new List<int>();

            for (int i = minH; i <= maxH; i++)
            {
                seged.Add(i);
            }

            for (int i = 0; i < db; i++)
            {
                int randomIndex = R.Next(0, seged.Count);
                int randomValue = seged[randomIndex];
                halmaz.Add(randomValue);
                seged.RemoveAt(randomIndex);
            }

            h1Megjelenit = new ListBox()
            {
                Parent = this,
                Location = new Point(10, 240),
                Size = new Size(50, 300),
            };
            foreach (var elem in h1Generalt)
            {
                h1Megjelenit.Items.Add(elem);
            }

            h2Megjelenit = new ListBox()
            {
                Parent = this,
                Location = new Point(70, 240),
                Size = new Size(50, 300),
            };
            foreach (var elem in h2Generalt)
            {
                h2Megjelenit.Items.Add(elem);
            }
        }
    }
}

