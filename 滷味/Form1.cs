using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] s_name = new string[] { "高麗菜", "豆乾", "海帶", "肉片" };
        int[] s_price = new int[] { 30, 15, 15, 40 };
        int sum = 0;
        int cash, total;
        private void Form1_Load(object sender, EventArgs e)
        {
            LstName.Items.AddRange(s_name);
        }

        private void LstName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstName.SelectedIndex >= 0)
            {
                TxtName.Text = LstName.Text;
                TxtPrice.Text = s_price[LstName.SelectedIndex].ToString();
                TxtNum.Text = "1";
                TxtTotal.Text = "";
                TxtSum.Text = "";
                TxtNum.Focus();
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(TxtNum.Text) > 0)
                {
                    TxtTotal.Text = (Convert.ToInt32(TxtPrice.Text) * Convert.ToInt32(TxtNum.Text)).ToString();
                    sum += Convert.ToInt32(TxtTotal.Text);
                    TxtSum.Text = sum.ToString();
                }
                else
                {
                    MessageBox.Show("請輸入數量!");
                }
            }
            catch
            {
                MessageBox.Show("請輸入數字!");
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                cash = Convert.ToInt32(TxtCash.Text);
                total = Convert.ToInt32(TxtTotal.Text);
            }
            catch
            {
                MessageBox.Show("請輸入數字!");
                return;
            }
            int n1000, n500, n100, n50, n10, n5, n1, change;
            if (cash >= total)
            {
                change = cash - total;
                TxtChange.Text = change.ToString();

                n1000 = change / 1000;
                change %= 1000;
                n500 = change / 500;
                change %= 500;
                n100 = change / 100;
                change %= 100;
                n50 = change / 50;
                change %= 50;
                n10 = change / 10;
                change %= 10;
                n5 = change / 5;
                change %= 5;
                n1 = change;

                Txt1000.Text = n1000.ToString();
                Txt500.Text = n500.ToString();
                Txt100.Text = n100.ToString();
                Txt50.Text = n50.ToString();
                Txt10.Text = n10.ToString();
                Txt5.Text = n5.ToString();
                Txt1.Text = n1.ToString();
            }
            else
            {
                MessageBox.Show("餘額不足!");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtName.Text = "";
            TxtNum.Text = "";
            TxtPrice.Text = "";
            TxtSum.Text = "";
            TxtTotal.Text = "";
            sum = 0;
        }
    }
}
