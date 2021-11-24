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
    public partial class Form3 : Form
    {
        Random rand = new Random();
        String[] ArrPhepToan = { "+", "-", "x", ":" };
        int vitri;
        public Form3()
        {
            InitializeComponent();
        }
        private void TaoPhepToan()
        {
            int a = rand.Next(10);
            int b = rand.Next(10);
            vitri = rand.Next(4);
            lbso1.Text = a.ToString();
            lbso2.Text = b.ToString();
            lbdau.Text = ArrPhepToan[vitri];
            txtNguoi.Text = "";
            txtNguoi.Focus();
        }

        private void bttieptuc_Click(object sender, EventArgs e)
        {
            TaoPhepToan();
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            int a = int.Parse(lbso1.Text);
            int b = int.Parse(lbso2.Text);
            int sochon = int.Parse(txtNguoi.Text);
            int dapan = 0;
            switch (vitri)
            {
                case 0://+
                    dapan = a + b;
                    break;
                case 1:
                    dapan = a - b;
                    break;
                case 2:
                    dapan = a * b;
                    break;
                case 3:
                    dapan = a / b;
                    break;
            }
            if (sochon == dapan)
                lbketquamay.Text = "Đúng rồi!";
            else
                lbketquamay.Text = String.Format("Sai rồi, đáp án phải bằng {0}", dapan);

        }

        private void bt0_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtNguoi.Text += bt.Text;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtNguoi.Text += bt.Text;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtNguoi.Text += bt.Text;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtNguoi.Text += bt.Text;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtNguoi.Text += bt.Text;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtNguoi.Text += bt.Text;
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtNguoi.Text += bt.Text;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtNguoi.Text += bt.Text;
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtNguoi.Text += bt.Text;
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtNguoi.Text += bt.Text;
        }

        private void btdau_Click(object sender, EventArgs e)
        {
            if (txtNguoi.Text != "") return;
            txtNguoi.Text = "-";
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (txtNguoi.Text == "") return;
            txtNguoi.Text = txtNguoi.Text.Substring(0, txtNguoi.Text.Length - 1);
        }
    }
}
