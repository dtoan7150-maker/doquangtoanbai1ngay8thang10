namespace Bai1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTieuDe;
        private Label lblDonGia;
        private Label lblSoLuong;
        private Label lblGiamGia;
        private Label lblTongTien;
        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private TextBox txtGiamGia;
        private Button btnTinhTien;
        private Button btnLamMoi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            lblDonGia = new Label();
            lblSoLuong = new Label();
            lblGiamGia = new Label();
            lblTongTien = new Label();
            txtDonGia = new TextBox();
            txtSoLuong = new TextBox();
            txtGiamGia = new TextBox();
            btnTinhTien = new Button();
            btnLamMoi = new Button();
            SuspendLayout();

            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.Location = new Point(190, 30);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(340, 30);
            lblTieuDe.Text = "MÁY TÍNH CƯỚC DỊCH VỤ";

            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(70, 100);
            lblDonGia.Size = new Size(120, 20);
            lblDonGia.Text = "Đơn giá dịch vụ:";

            txtDonGia.Location = new Point(220, 97);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(300, 27);

            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(70, 145);
            lblSoLuong.Size = new Size(120, 20);
            lblSoLuong.Text = "Số lượng khách:";

            txtSoLuong.Location = new Point(220, 142);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(300, 27);

            lblGiamGia.AutoSize = true;
            lblGiamGia.Location = new Point(70, 190);
            lblGiamGia.Size = new Size(120, 20);
            lblGiamGia.Text = "Giảm giá (%):";

            txtGiamGia.Location = new Point(220, 187);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(300, 27);

            btnTinhTien.Location = new Point(220, 240);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(130, 40);
            btnTinhTien.Text = "Tính tiền";
            btnTinhTien.UseVisualStyleBackColor = true;
            btnTinhTien.Click += btnTinhTien_Click;

            btnLamMoi.Location = new Point(390, 240);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(130, 40);
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;

            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTongTien.Location = new Point(70, 320);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(190, 25);
            lblTongTien.Text = "Tổng tiền: 0 VNĐ";

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 400);
            Controls.Add(lblTieuDe);
            Controls.Add(lblDonGia);
            Controls.Add(txtDonGia);
            Controls.Add(lblSoLuong);
            Controls.Add(txtSoLuong);
            Controls.Add(lblGiamGia);
            Controls.Add(txtGiamGia);
            Controls.Add(btnTinhTien);
            Controls.Add(btnLamMoi);
            Controls.Add(lblTongTien);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 1 - Máy tính cước dịch vụ";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
