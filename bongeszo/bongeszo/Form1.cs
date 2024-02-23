using System;
using System.Windows.Forms;

namespace bongeszo
{
    public partial class Form1 : Form
    {
        string url;
        bool lathato;

        public Form1()
        {
            InitializeComponent();
            lathato = false;
        }
        private void keres_g_Click(object sender, EventArgs e)
        {
            kereses();
        }
        private void kereses()
        {
            url = url_tb.Text;
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "http://" + url;
            }
            if (!url.EndsWith(".com") && !url.EndsWith(".hu"))
            {
                url = url + ".com";
            }
            bongeszo.Navigate(url);
        }


        private void vissza_b_Click(object sender, EventArgs e)
        {
            bongeszo.GoBack();
        }

        private void elore_b_Click(object sender, EventArgs e)
        {
            bongeszo.GoForward();
        }

        private void frissit_b_Click(object sender, EventArgs e)
        {
            bongeszo.Refresh();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y <= 25)
            {
                panel1.Visible = true;

            }
            else
            {
                panel1.Visible = false;
            }
        }
    }
}
    

