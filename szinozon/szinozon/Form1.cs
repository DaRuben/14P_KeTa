using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace szinozon
{
    public partial class Form1 : Form
    {
        Label sz1, sz2, sz3, sz4;
        string szin1, szin2, bc1, bc2;
        Color kiv1, kiv2, kiv3, kiv4, szin_kiv1, szin_kiv2;
        List<Color> szinek;
        //Button tovabb;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            szinek = new List<Color>();
            szinek.Add(Color.Red);
            szinek.Add(Color.Green);
            szinek.Add(Color.Blue);
            szinek.Add(Color.Yellow);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Színözön";
            Size = new Size(300, 500);


            int szin_i1 = r.Next(szinek.Count);
            int szin_i2 = r.Next(szinek.Count - 1);
            Label sz1 = new Label()
            {
                Parent = this,
                Location = new Point(10, 10),
                Size = new Size(40, 40),
                BackColor = szinek[szin_i1],
            };
            szinek.Remove(szinek[szin_i1]);
            szin1 = sz1.BackColor.ToString();

            Label sz2 = new Label()
            {
                Parent = this,
                Location = new Point(60, 10),
                Size = new Size(40, 40),
                BackColor = szinek[szin_i2],
            };
            szinek.Remove(szinek[szin_i2]);
            szin2 = sz2.BackColor.ToString();

            szinek = new List<Color>();
            szinek.Add(Color.Red);
            szinek.Add(Color.Green);
            szinek.Add(Color.Blue);
            szinek.Add(Color.Yellow);
            Label kiv_sz1 = new Label()
            {
                Parent = this,
                Location = new Point(230, 30),
                Size = new Size(40, 40),
                BackColor = szinek[0],
            };
            kiv1 = kiv_sz1.BackColor;
            Label kiv_sz2 = new Label()
            {
                Parent = this,
                Location = new Point(230, 80),
                Size = new Size(40, 40),
                BackColor = szinek[1],
            };
            kiv2 = kiv_sz2.BackColor;
            Label kiv_sz3 = new Label()
            {
                Parent = this,
                Location = new Point(230, 130),
                Size = new Size(40, 40),
                BackColor = szinek[2],
            };
            kiv3 = kiv_sz3.BackColor;
            Label kiv_sz4 = new Label()
            {
                Parent = this,
                Location = new Point(230, 180),
                Size = new Size(40, 40),
                BackColor = szinek[3],
            };
            kiv4 = kiv_sz4.BackColor;



            kiv_sz1.Click += Kiv_Click;
            kiv_sz2.Click += Kiv_Click;
            kiv_sz3.Click += Kiv_Click;
            kiv_sz4.Click += Kiv_Click;
            kiv_sz1.Click += Kiv2_Click;
            kiv_sz2.Click += Kiv2_Click;
            kiv_sz3.Click += Kiv2_Click;
            kiv_sz4.Click += Kiv2_Click;


            /* tovabb = new Button()
             {
                 Parent = this,
                 Location = new Point(250, 20),
                 Size = new Size(60, 30),
                 Text = "Tovább",
             };
             tovabb.Click += Tovabb_Click;*/
        }

        /*private void Tovabb_Click(object sender, EventArgs e)
        {
            int szam = 0;
            szam++;
            labelek(szam);
        }*/


        private void Kiv_Click(object sender, EventArgs e)
        {
            var lb1 = sender as Label;
            szin_kiv1 = lb1.BackColor;


            labelek();
        }
        private void Kiv2_Click(object sender, EventArgs e)
        {
            var lb2 = sender as Label;
            szin_kiv2 = lb2.BackColor;

            labelek();
        }


        // szin1 szin2
        //  bc1   bc2
        private void Kitalal_sz1_Click(object sender, EventArgs e)
        {
            if (bc1 == szin1)
            {
                MessageBox.Show("1. van, jó helyen");
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
        private void Kitalal_sz2_Click(object sender, EventArgs e)
        {
            if (bc2 == szin2)
            {
                MessageBox.Show("2. van, jó helyen");
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

        void labelek()
        {
             int szam = 0;
            for (int i = 1; i < 4; i += 6)
            {
                for (int j = 1; j < 4; j += 6)
                {
                    szam++;
                    Label kitalal_sz1 = new Label()
                    {
                        Parent = this,
                        Location = new Point(szam * 10, j * 60),
                        Size = new Size(40, 40),
                        BackColor = Color.Gray,
                    };
                    kitalal_sz1.BackColor = szin_kiv1;
                    bc1 = kitalal_sz1.BackColor.ToString();

                    kitalal_sz1.Click += Kitalal_sz1_Click;
                    Label kitalal_sz2 = new Label()
                    {
                        Parent = this,
                        Location = new Point(i * 60, j * 60),
                        Size = new Size(40, 40),
                        BackColor = Color.Gray,
                    };
                    kitalal_sz2.BackColor = szin_kiv2;
                    bc2 = kitalal_sz2.BackColor.ToString();
                    kitalal_sz2.Click += Kitalal_sz2_Click;
                }
            }

        }

    }
}
