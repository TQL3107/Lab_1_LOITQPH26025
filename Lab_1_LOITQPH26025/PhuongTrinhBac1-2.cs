using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Lab_1_LOITQPH26025
{
    public partial class PhuongTrinhBac1_2 : Form
    {
        double a, b, c, delta, x1, x2;

        

        private void btn_giai_Click(object sender, EventArgs e)
        {
            if (rdB_Bac1.Checked == true)
            {
                a = Convert.ToDouble(tB_A.Text);
                b = Convert.ToDouble(tB_B.Text);
                if (a == 0)
                {
                    if ( b == 0)
                    {
                        tB_kq.Text = "Phương trình vô số nghiệm";
                    }
                    else
                    {
                        tB_kq.Text = "Phương trình vô nghiệm";
                    } 
                        
                }
                else
                {
                    tB_kq.Text = "Phương trình có nghiệm :" + ((-b) / a).ToString();
                } 
                   
            }
            if (rdB_Bac2.Checked == true)
            {
                a = Convert.ToDouble(tB_A.Text);
                b = Convert.ToDouble(tB_B.Text);
                c = Convert.ToDouble(tB_C.Text);
                if (a == 0)
                {
                    if (b == 0)
                    {
                        if (c == 0)
                        {
                            tB_kq.Text = "Phương trình vô số nghiệm";
                        }    
                        else
                        {
                            tB_kq.Text = "Phương trình vô nghiệm";
                        }    
                        
                    }
                    else
                    {
                        tB_kq.Text = "Phương trình có nghiệm : " + ((( - c) / b).ToString());
                    }

                }
                else
                {
                    delta = (b * b) - (4 * a * c);
                    if (delta < 0)
                    {
                        tB_kq.Text = "Phương trình vô nghiệm";
                    }
                    else
                    {
                        if (delta == 0)
                        {
                            tB_kq.Text = "Phương trình có 1 nghiệm" + ((-b) / (2 * a));
                        }    
                        else
                        {
                            x1 = (-b + Math.Sqrt(delta)) /(2 * a);
                            x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                            tB_kq.Text = "Phương trình có 2 nghiệm: " + "x1 = " + x1 + "x2 = " + x2 ;
                        }    
                    } 
                        
                }

            }
        }
        private void rdB_Bac2_CheckedChanged(object sender, EventArgs e)
        {
            //groupBox1.Enabled = true;
            this.tB_A.ResetText();
            this.tB_B.ResetText();
            this.tB_C.ResetText();
            this.tB_kq.ResetText();

        }

        private void rdB_Bac1_CheckedChanged(object sender, EventArgs e)
        {
            //groupBox1.Enabled = false;
            this.tB_A.ResetText();
            this.tB_B.ResetText();
            this.tB_C.ResetText();
            this.tB_kq.ResetText();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string s;
        public PhuongTrinhBac1_2()
        {
            InitializeComponent();
        }
    }
}
