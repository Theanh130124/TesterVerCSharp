using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnCong_21_Anh_Click(object sender, EventArgs e)
        {
            int a_21_Anh = int.Parse(txtSoThuNhat_21_Anh.Text);
            int b_21_Anh = int.Parse(txtSoThuHai_21_Anh.Text);
            Calculation c_21_Anh = new Calculation(a_21_Anh, b_21_Anh);
            int ketQua_21_Anh = c_21_Anh.Exucute("+");
            txtRes_21_Anh.Text = ketQua_21_Anh.ToString();
        }

        private void btnTru_21_Anh_Click(object sender, EventArgs e)
        {
            int a_21_Anh = int.Parse(txtSoThuNhat_21_Anh.Text);
            int b_21_Anh = int.Parse(txtSoThuHai_21_Anh.Text);
            Calculation c_21_Anh = new Calculation(a_21_Anh, b_21_Anh);
            int ketQua_21_Anh = c_21_Anh.Exucute("Tru");
            txtRes_21_Anh.Text = ketQua_21_Anh.ToString();
        }

        private void btnNhan_21_Anh_Click(object sender, EventArgs e)
        {
            int a_21_Anh = int.Parse(txtSoThuNhat_21_Anh.Text);
            int b_21_Anh = int.Parse(txtSoThuHai_21_Anh.Text);
            Calculation c_21_Anh = new Calculation(a_21_Anh, b_21_Anh);
            int ketQua_21_Anh = c_21_Anh.Exucute("Nhan");
            txtRes_21_Anh.Text = ketQua_21_Anh.ToString();
        }

        private void btnChia_21_Anh_Click(object sender, EventArgs e)
        {
            int a_21_Anh = int.Parse(txtSoThuNhat_21_Anh.Text);
            int b_21_Anh = int.Parse(txtSoThuHai_21_Anh.Text);
            Calculation c_21_Anh = new Calculation(a_21_Anh, b_21_Anh);
            int ketQua_21_Anh = c_21_Anh.Exucute("Chia");
            txtRes_21_Anh.Text = ketQua_21_Anh.ToString();
        }

        private void BtnPower_21_Anh_Click(object sender, EventArgs e)
        {
            double x_21_Anh = double.Parse(txtSoThuNhat_21_Anh.Text);
            int n_21_Anh = int.Parse(txtSoThuHai_21_Anh.Text);
            double ketQua_21_Anh = Calculation.Power_21_Anh(x_21_Anh, n_21_Anh); //Phương thức tỉnh gọi qua tên class chưa nó luôn
            txtRes_21_Anh.Text = ketQua_21_Anh.ToString();

        }


    }
}
