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
    public partial class Return_metot_odev : Form
    {
        public Return_metot_odev()
        {
            InitializeComponent();
        }

        int carpma(int s1,int s2)
        {
            int s3 = s1 * s2;
            return s3;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = carpma(7, 9).ToString();
            label2.Text = carpma(5, 7).ToString();
            label3.Text = carpma(3, 10).ToString();
        }
    }
}
