using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_01
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void GetPay()
        {
            if (txt_Name.Text == "")
            {
                MessageBox.Show("Vui long nhap ten khach hang!");
                txt_Name.Focus();
            }
            else
            {
                long total = 0;
                if (chk_Clean.Checked == true)
                    total += 100000;
                if (chk_Whitening.Checked == true)
                    total += 1200000;
                if (chk_Xray.Checked == true)
                    total += 200000;
                int soluong = int.Parse(numFilling.Value.ToString());
                total += soluong * 80000;

                txtTotal.Text = String.Format("{0:#,###} dong", total);
            }
        }
            private void btn_Calc_Click(object sender, EventArgs e)
            {
                GetPay();
            }
        }
    }

