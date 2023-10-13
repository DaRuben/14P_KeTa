using rekurzio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace rekurziok_gui
{
    public partial class Form1 : Form
    {
        Label L1, L2, L3;
        NumericUpDown N1, N2, N3;
        Button B1, B2;
        RichTextBox RTB1, RTB2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Rekurziók";
            Size = new Size(600, 400);
            Font = new Font("Times", 14f);

            L1 = new Label()
            {
                Parent = this,
                Text = "Hanyadik fokot kéri?",
                Size = new Size(180, 25),
                Location = new Point(10, 5),
            };
            N1 = new NumericUpDown()
            {
                Parent = this,
                Location = new Point(10, 40),
                Size = new Size(65, 25),
            };
            B1 = new Button()
            {
                Parent = this,
                Text = "OK",
                Location = new Point(85, 35),
                Size = new Size(65, 40),
            };

            L2 = new Label()
            {
                Parent = this,
                Text = "Adja meg a szorzandót:",
                Location = new Point(10, 90),
                Size = new Size(200, 25),
            };
            N2 = new NumericUpDown()
            {
                Parent = this,
                Location = new Point(10, 120),
                Size = new Size(65, 75),
            };
            L3 = new Label()
            {
                Parent = this,
                Text = "Adja meg a szorzót:",
                Location = new Point(220, 90),
                Size = new Size(160, 25),
            };
            N3 = new NumericUpDown()
            {
                Parent = this,
                Location = new Point(220, 120),
                Size = new Size(65, 25),
            };

            B2 = new Button()
            {
                Parent = this,
                Text = "OK",
                Location = new Point(400, 100),
                Size = new Size(65, 40),
            };

            B1.Click += Binomialis;
            B2.Click += Szorzat;
        }


        private void Binomialis(object sender, EventArgs e)
        {
            recursions RK = new recursions();
            RTB1 = new RichTextBox()
            {
                Parent = this,
                Location = new Point(220, 30),
                Size = new Size(420, 50),
                ReadOnly = true,
            };

            int fokszam = (int)N1.Value;
            List<int> szamok = new List<int>();

            for (int k = 0; k < fokszam; k++)
            {
                szamok.Add(RK.Binomialis(fokszam, k));
            }
            szamok.Add(1);
            RTB1.Text = string.Join(" ", szamok);

        }
        private void Szorzat(object sender, EventArgs e)
        {
            recursions RK = new recursions();
            int sznd = (int)N2.Value;
            int szrz = (int)N3.Value;

            RTB2 = new RichTextBox()
            {
                Parent = this,
                Text = RK.Szorzas(sznd, szrz) + "", //sznd+" * "+szrz+" = "+
                Location = new Point(520, 140),
                Size = new Size(70, 50),
                ReadOnly = true,
            };
        }



    }
}
