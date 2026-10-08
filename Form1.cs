using System;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtDonGia.TabIndex = 0;
            txtSoLuong.TabIndex = 1;
            txtGiamGia.TabIndex = 2;
            btnTinhTien.TabIndex = 3;
            btnLamMoi.TabIndex = 4;
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDonGia.Text) ||
                string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
                string.IsNullOrWhiteSpace(txtGiamGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!double.TryParse(txtDonGia.Text, out double donGia))
            {
                MessageBox.Show("Đơn giá phải là số!");
                txtDonGia.Focus();
                return;
            }

            if (!int.TryParse(txtSoLuong.Text, out int soLuong))
            {
                MessageBox.Show("Số lượng khách phải là số nguyên!");
                txtSoLuong.Focus();
                return;
            }

            if (!double.TryParse(txtGiamGia.Text, out double giamGia))
            {
                MessageBox.Show("Giảm giá phải là số!");
                txtGiamGia.Focus();
                return;
            }

            if (donGia < 0)
            {
                MessageBox.Show("Đơn giá không được nhỏ hơn 0!");
                txtDonGia.Focus();
                return;
            }

            if (soLuong < 0)
            {
                MessageBox.Show("Số lượng không được nhỏ hơn 0!");
                txtSoLuong.Focus();
                return;
            }

            if (giamGia < 0 || giamGia > 100)
            {
                MessageBox.Show("Giảm giá phải từ 0% đến 100%!");
                txtGiamGia.Focus();
                return;
            }

            double tongTien = donGia * soLuong * (100 - giamGia) / 100;

            lblTongTien.Text = "Tổng tiền: " + tongTien.ToString("N0") + " VNĐ";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtGiamGia.Clear();
            lblTongTien.Text = "Tổng tiền: 0 VNĐ";
            txtDonGia.Focus();
        }
    }
}
