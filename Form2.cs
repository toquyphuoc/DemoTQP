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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bttinh_Click(object sender, EventArgs e)
        {
            try
            {
                int a = checked(int.Parse(txt1.Text));
                int b = checked(int.Parse(txt2.Text));
                if (rdcong.Checked)
                    lbketqua.Text = String.Format("{0}", checked(a + b));
                else if (rdtru.Checked)
                    lbketqua.Text = String.Format("{0}", checked(a - b));
                else if (rdnhan.Checked)
                    lbketqua.Text = String.Format("{0}", checked(a * b));
                else if (rdchia.Checked)
                {
                    if (b == 0)
                        throw new DivideByZeroException("Không thể chia cho 1 số là 0");
                    lbketqua.Text = String.Format("{0:0.00}", (double)a / b);
                }
                else
                    lbketqua.Text = String.Format("{0}", a % b);
            }
            catch (FormatException)
            {
                lbketqua.Text = "Bạn phải nhập hai số!";
            }
            catch (DivideByZeroException ex)
            {
                lbketqua.Text = ex.Message;
            }
            catch (OverflowException)
            {
                lbketqua.Text = "Không thể nhập số quá lớn!";
            }
        }
    }
}
