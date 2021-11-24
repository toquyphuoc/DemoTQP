using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTGD_Chuong2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btcong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt1.Text);
            int b = int.Parse(txt2.Text);
            lbketqua.Text = String.Format("{0}", a + b);
        }

        private void bttru_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt1.Text);
            int b = int.Parse(txt2.Text);
            lbketqua.Text = String.Format("{0}", a - b);
        }

        private void btnhan_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt1.Text);
            int b = int.Parse(txt2.Text);
            lbketqua.Text = String.Format("{0}", a * b);
        }

        private void btchia_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt1.Text);
            int b = int.Parse(txt2.Text);
            if (b != 0)
                lbketqua.Text = String.Format("{0:0.00}", (double)a / b);
            else
                lbketqua.Text = String.Format("Khong the chia cho 1 so = 0");

        }

        private void btdong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
