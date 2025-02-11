using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIApp
{
    public partial class BMIApp : Form
    {
        public BMIApp()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {

                double w, h, bmi;
                w = double.Parse(txtWeight.Text);
                h = double.Parse(txtHeight.Text);
                bmi = w / Math.Pow(h, 2);

                if (bmi < 18.5)
                {
                    lblResult.Text = "Gầy" + bmi.ToString();
                    lblResult.ForeColor = Color.Red;

                }
                else if (bmi > 18.5 && bmi < 24.9)
                {
                    lblResult.Text = "Bình thường";
                    lblResult.ForeColor = Color.Yellow;

                }
                else if (bmi >= 25)
                {
                    lblResult.Text = "Thừa cân";
                    lblResult.ForeColor = Color.Green;

                }
                else if (bmi > 25 && bmi < 29.9)
                {

                    lblResult.Text = "Tiền béo phì";
                    lblResult.ForeColor = Color.Blue;

                }
                else if (bmi > 30 && bmi < 34.9)
                {
                    lblResult.Text = "béo phì I";
                    lblResult.ForeColor = Color.LightBlue;

                }
                else if (bmi > 35 && bmi < 39.9)
                {
                    lblResult.Text = "béo phì II";
                    lblResult.ForeColor = Color.Black;

                }
                else
                {
                    lblResult.Text = "béo phì III";
                    lblResult.ForeColor = Color.Pink;

                }


            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            }
            


    }
}
    
