using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kodol
{
    public partial class Form1 : Form
    {
        Label L1, L2, L3, L4, L5;
        TextBox TB1, TB2;
        Button B1, B2;

        string nyiltSzoveg, kulcsszo, nagyKulcsszo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(700, 400);

            L1 = new Label()
            {
                Parent = this,
                Text = "Adjon meg egy átalakítandó szöveget (nem üres string):",
                Font = new Font("Times", 10f),
                Location = new Point(20, 5),
                Size = new Size(380, 25),
            };

            TB1 = new TextBox()
            {
                Parent = this,
                Location = new Point(20, 35),
                Size = new Size(300, 25),
            };
            B1 = new Button()
            {
                Parent = this,
                Text = "OK",
                Location = new Point(330, 30),
                Size = new Size(45, 35),
            };

            B1.Click += B1_Click;


            L4 = new Label()
            {
                Parent = this,
                Text = "Adja meg a kulcsszót (maximum 5 karakter):",
                Font = new Font("Times", 10f),
                Location = new Point(20, 120),
                Size = new Size(380, 25),
            };

            TB2 = new TextBox()
            {
                Parent = this,
                Location = new Point(20, 145),
                Size = new Size(300, 25),
            };
            B2 = new Button()
            {
                Parent = this,
                Text = "OK",
                Location = new Point(330, 145),
                Size = new Size(45, 35),
            };
            B2.Click += B2_Click;

        }


        private void B1_Click(object sender, EventArgs e)
        {
            string bekertSzoveg = TB1.Text;

            kodolas K = new kodolas(bekertSzoveg);
            nyiltSzoveg = K.szovegAtalakit(bekertSzoveg);

            L2 = new Label()
            {
                Parent = this,
                Text = "Átalakított nyílt szöveg:",
                Font = new Font("Times", 10f),
                Location = new Point(20, 65),
                Size = new Size(155, 25),
            };
            L3 = new Label()
            {
                Parent = this,
                Text = nyiltSzoveg,
                Location = new Point(20, 90),
                Size = new Size(ClientSize.Width, ClientSize.Height),
            };
        }
        private void B2_Click(object sender, EventArgs e)
        {
            kulcsszo = TB2.Text;
            nagyKulcsszo = kulcsszo.ToUpper();

            L5 = new Label()
            {
                Parent = this,
                Text = nagyKulcsszo,
                Font = new Font("Times", 10f),
                Location = new Point(20, 185),
                Size = new Size(155, 25),
            };
        }

    }
}
