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
    public partial class USCLN_BCNN : Form
    {
        public USCLN_BCNN()
        {
            InitializeComponent();
        }

        private void rb_USCLN_CheckedChanged(object sender, EventArgs e) //sai
        {
            //if (rb_USCLN.Checked == true)
            //{
            //    tb_kq.Text = $"{USCLN}";
            //}
            //else if (rb_BCNN.Checked == true)
            //{
            //    tb_kq.Text = $"{BSCNN}";
            //}

        }

        private void rb_USCLN_ClientSizeChanged(object sender, EventArgs e) //sai
        {

        }

        private void rb_USCLN_Click(object sender, EventArgs e)
        {
            //int a = int.Parse(tb_A.Text);
            //int b = int.Parse(tb_B.Text);
            //if (a == b)
            //{
            //    MessageBox.Show("");
            //}
            //else
            //{
            //    int uscln = a% b;
            //}    
        }

        private void rb_BCNN_Click(object sender, EventArgs e)
        {

        }
        //static int USCLN(int a, int b)
        //{
        //    if (a == b)
        //    {
        //         return a;
        //    }
        //    return USCLN(b, a % b);
                
        //}
        //static int BSCNN(int a, int b)
        //{
        //    return (a * b) / USCLN(a, b);
        //}
        private void btn_tim_Click(object sender, EventArgs e)
        {
            
            //if (rb_USCLN.Checked == true)
            //{
            //    tb_kq.Text = $"{USCLN}";
            //}
            //else if (rb_BCNN.Checked == true)
            //{
            //    tb_kq.Text = $"{BSCNN}";
            //}   
                

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PhuongTrinhBac1_2 form3 = new PhuongTrinhBac1_2();
            form3.ShowDialog();
        }
    }
}
