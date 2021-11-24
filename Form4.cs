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
    public partial class Form4 : Form
    {
        Random rand = new Random();
        static int diem = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void btQuayso_Click(object sender, EventArgs e)
        {
            int a = rand.Next(1, 7);
            int b = rand.Next(1, 7);
            int c = rand.Next(1, 7);
            lbso1.Text = a.ToString();
            lbso2.Text = b.ToString();
            lbso3.Text = c.ToString();
            int tong = a + b + c;
            if (rdXiu.Checked)
            {
                if (tong < 11)
                {
                    lbKetqua.Text = String.Format("Bạn đã đoán đúng, tổng là {0}", tong);
                    diem += 10;
                    lbDiem.Text = diem.ToString();
                }
                else
                {
                    lbKetqua.Text = String.Format("Bạn đã đoán sai, tổng là {0}", tong);
                    diem -= 10;
                    lbDiem.Text = diem.ToString();
                }
            }
            if (rdTai.Checked)
            {
                if (tong < 11)
                {
                    lbKetqua.Text = String.Format("Bạn đã đoán sai, tổng là {0}", tong);
                    diem -= 10;
                    lbDiem.Text = diem.ToString();
                }
                else
                {
                    lbKetqua.Text = String.Format("Bạn đã đoán đúng, tổng là {0}", tong);
                    diem += 10;
                    lbDiem.Text = diem.ToString();
                }
            }

        }
    }
}
