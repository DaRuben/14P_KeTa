using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace emlosok_forms
{
    public partial class Form1 : Form
    {
        List<string> kepek;
        int mozgas;

        PictureBox kep;
        Button bal, jobb, kepAdatai;

        public Form1()
        {
            InitializeComponent();
            kepBetolt();
            kepMegjelenit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Emlősök";
            Size = new Size(550, 350);

            bal = new Button()
            {
                Parent = this,
                Location = new Point(20, 270),
                Size = new Size(100, 30),
                Text = "<",
            };
            jobb = new Button()
            {
                Parent = this,
                Location = new Point(420, 270),
                Size = new Size(100, 30),
                Text = ">",
            };
            kepAdatai = new Button()
            {
                Parent = this,
                Location = new Point(220, 270),
                Size = new Size(100, 30),
                Text = "Tovább",
            };

            bal.Click += Bal_Click;
            jobb.Click += Jobb_Click;
            kepAdatai.Click += KepAdatai_Click;
        }

        private void KepAdatai_Click(object sender, EventArgs e)
        {
            kep_adatai kep = new kep_adatai();
            kep.ShowDialog();
        }

        private void Bal_Click(object sender, EventArgs e)
        {
            mozgas--;
            if (mozgas >= kepek.Count)
            {
                mozgas = -1;
            }
            else
            {
                kep.Image = Image.FromFile(kepek[mozgas]);
            }
        }

        private void Jobb_Click(object sender, EventArgs e)
        {
            mozgas++;
            if (mozgas >= kepek.Count)
            {
                mozgas = -1;
            }
            else
            {
                kep.Image = Image.FromFile(kepek[mozgas]);
            }
        }

        private void kepBetolt()
        {
            string utvonal = @"D:\boronkay\14p\keta\emlosok\emlosok_forms\emlosok_forms\bin\Debug\képek"; 
            kepek = new List<string>();
            
            /* string utvonalKiterj = "";
            if (utvonal == "ember")
            {
                utvonalKiterj = utvonal + "*.png";
            }*/

            kepek = Directory.GetFiles(utvonal, "*.jpg").ToList();
        }

        private void kepMegjelenit()
        {
            kep = new PictureBox()
            {
                Parent = this,
                Location = new Point(20, 10),
                Size = new Size(500, 250),
                SizeMode = PictureBoxSizeMode.Zoom,
            };
            kep.Image = Image.FromFile(kepek[mozgas]);
        }

    }
}
