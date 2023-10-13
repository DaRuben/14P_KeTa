using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _20231009
{
    public partial class Form1 : Form
    {
        Label L1, L2, L3, L4;
        NumericUpDown N1, N2;
        ListBox LB1;
        Button B1, B2, B3, B4;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(450, 300);
            Font = new Font("Times", 14f);
            Text = "Prímszámok";

            primszamok PSZ = new primszamok();
            adatbazis DB = new adatbazis("server=localhost;database=primszamok;user=root;password=;");

            L1 = new Label()
            {
                Parent = this,
                Text = "Adjon meg egy számot!",
                Location = new Point(10, 10),
                AutoSize = true,
            };
            N1 = new NumericUpDown()
            {
                Parent = this,
                Location = new Point(45, 50),
                Size = new Size(75, 30),
                Minimum = 1,
                Maximum = 999999999,
            };
            B1 = new Button()
            {
                Parent = this,
                Text = "OK",
                Location = new Point(190, 50),
                AutoSize = true,
            };


            L3 = new Label()
            {
                Parent = this,
                Text = "Adjon meg egy számot!",
                Location = new Point(10, 100),
                AutoSize = true,
            };
            N2 = new NumericUpDown()
            {
                Parent = this,
                Location = new Point(45, 140),
                Size = new Size(75, 30),
                Minimum = 1,
                Maximum = 999999999,
            };
            B2 = new Button()
            {
                Parent = this,
                Text = "OK",
                Location = new Point(190, 140),
                AutoSize = true,
            };

            B3 = new Button()
            {
                Parent = this,
                Text = "Kilépés",
                Location = new Point(190, 320),
                AutoSize = true,
            };
            B4 = new Button()
            {
                Parent = this,
                Text = "Újra",
                Location = new Point(100, 320),
                AutoSize = true,
            };

            B1.Click += B1_Click;
            B2.Click += B2_Click;
            B3.Click += B3_Click;
            B4.Click += B4_Click;
        }
        private void B4_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void B3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void B2_Click(object sender, EventArgs e)
        {
            primszamok PSZ = new primszamok();
            adatbazis DB = new adatbazis("server=localhost;database=primszamok;user=root;password=;");

            int beSzam = (int)N2.Value;
            L4 = new Label()
            {
                Parent = this,
                Text = "Prímszámok " + beSzam + "-ig:",
                Location = new Point(325, 110),
                AutoSize = true,
            };
            LB1 = new ListBox()
            {
                Parent = this,
                Location = new Point(330, 135),
                Size =new Size(140, 240)
            };
            LB1.DataSource = PSZ.bekertSzamigMegallapit(beSzam);


            /*List<int> bekertSzamig = PSZ.bekertSzamigMegallapit(beSzam);
            foreach (int sz in bekertSzamig)
            {
                DB.DdlDml("INSERT INTO primszam VALUES (" + sz + ")");
            }*/
        }

        private void B1_Click(object sender, EventArgs e)
        {
            primszamok PSZ = new primszamok();

            int beSzam = (int)N1.Value;
            L2 = new Label()
            {
                Parent = this,
                Location = new Point(320, 45),
                Font=new Font("Garamond",18),
                Text = beSzam + " = " + PSZ.primSzamMegallapit(beSzam),
                BackColor = Color.LightGray,
                AutoSize = true,
            };

        }
    }
}
