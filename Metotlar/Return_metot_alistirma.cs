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
    public partial class Return_metot_alistirma : Form
    {
        public Return_metot_alistirma()
        {
            InitializeComponent();
        }

        int bolme(int s1,int s2)
        {
            int s3 = s1 / s2;
            return s3;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(textBox1.Text);
            int y = Convert.ToInt16(textBox2.Text);
            label1.Text = bolme(x, y).ToString();
        }
    }
}
