using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDatabaseMySQL;

namespace Dallos_Ruben_kepes_kviz
{
    public partial class Form1 : Form
    {
        MyDB db;
        public Form1()
        {
            InitializeComponent();
            db = new MyDB("localhost", "root", "", "kviz");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jatekosNev = textBox1.Text;
            string sql = $"INSERT INTO `jatekos` (`nev`) VALUES ('{jatekosNev}')";
            db.Query(sql);
        }

        private void műveletekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jatek j = new jatek();
            j.ShowDialog();
        }
    }
}
