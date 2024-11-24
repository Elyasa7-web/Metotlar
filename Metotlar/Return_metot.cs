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
    public partial class Return_metot : Form
    {
        public Return_metot()
        {
            InitializeComponent();
        }

        int Toplam(int s1,int s2)
        {
            int s3 = s1 + s2;
            return s3;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text=Toplam(5,9).ToString();
            label2.Text = Toplam(8, 3).ToString();
            label3.Text = Toplam(9, 6).ToString();
        }
    }
}
