using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_LOITQPH26025
{
    public partial class TinhToan : Form
    {
        public TinhToan()
        {
            InitializeComponent();
        }

        private void btn_cong_Click(object sender, EventArgs e)
        {
            int n = int.Parse(tb_son.Text);   
            int m = int.Parse(tb_som.Text);
            int Tong = m + n;
            tb_kq.Text = Tong.ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            tb_son.Text = "";
            tb_som.Text = "";
            tb_kq.Text = "";

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_tru_Click(object sender, EventArgs e)
        {
            int n = int.Parse(tb_son.Text);
            int m = int.Parse(tb_som.Text);
            int Tru = m - n;
            tb_kq.Text = Tru.ToString();
        }

        private void btn_nha_Click(object sender, EventArgs e)
        {
            int n = int.Parse(tb_son.Text);
            int m = int.Parse(tb_som.Text);
            int Nhan = m * n;
            tb_kq.Text = Nhan.ToString();
        }

        private void btn_chia_Click(object sender, EventArgs e)
        {
            int n = int.Parse(tb_son.Text);
            int m = int.Parse(tb_som.Text);
            int Chia = m % n;
            tb_kq.Text = Chia.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            USCLN_BCNN form2 = new USCLN_BCNN();
            form2.ShowDialog();
        }
    }
}
