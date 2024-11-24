using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar
{
    public partial class Metotlar_odev : Form
    {
        public Metotlar_odev()
        {
            InitializeComponent();
        }

        private void yazdir()
        {
            textBox1.Text = "Elyasa";
            textBox2.Text = "Kapucu";
            textBox3.Text = "İstanbul";
            textBox4.Text = "22";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            yazdir();
        }
    }
}
