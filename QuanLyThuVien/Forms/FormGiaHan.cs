using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
namespace QuanLyThuVien.Forms
{
	public partial class FormGiaHan : Form
	{
		Library_Entities db = new Library_Entities();
		public int MaChiTiet { get; set; }
		public int MaNguoiThue { get; set; }
		public FormGiaHan()
		{
			InitializeComponent();
			this.btn_XemChiTiet.Click += Btn_XemChiTiet_Click;
			this.btn_XacNhan.Click += Btn_XacNhan_Click;
			this.iconPictureBox_Exit.Click += IconPictureBox_Exit_Click;
			this.FormBorderStyle = FormBorderStyle.None;
			this.Load += FormGiaHan_Load;
		}

		private void FormGiaHan_Load(object sender, EventArgs e)
		{
			NguoiThue nguoiThue = db.NguoiThues.Where(x => x.MaNguoiThue == MaNguoiThue).FirstOrDefault();
			ChiTietThueSach chiTietThueSach = db.ChiTietThueSaches.Where(x => x.MaChiTiet ==MaChiTiet).FirstOrDefault();
			Sach sach = db.Saches.Where(x => x.MaSach == chiTietThueSach.MaSach).FirstOrDefault();
			loaddata(sach, nguoiThue, chiTietThueSach);
		}

		public FormGiaHan(int maNguoiThue)
		{
			InitializeComponent();
			
		}

		private void Btn_XacNhan_Click(object sender, EventArgs e)
		{
			DateTime ngayTra = dateTimePicker.Value;
			DateTime ngayThue = DateTime.Now;
			if (DateTime.Compare(ngayTra, ngayThue) == 0 || DateTime.Compare(ngayTra, ngayThue) < 0)
			{
				MessageBox.Show("Ngày gia hạn không hợp lệ, vui lòng chọn lại");
				return;
			}
			ChiTietThueSach chiTietThueSach = db.ChiTietThueSaches.Where(x => x.MaChiTiet == MaChiTiet).FirstOrDefault();
			TimeSpan diffResult = ngayTra.Subtract(chiTietThueSach.NgayThue ?? DateTime.Now); // tinh toan ngay tra va ngay thue cach nhau bao nhieeu ngay
			int days = (int)diffResult.TotalDays;
			string ghiChu = "Ngày mượn: " + DateTime.Now.ToString("dd/MM/yyy") + " - Ngày trả: " + ngayTra.ToString("dd/MM/yyyy") + ". Vui lòng quay lại trả sau " + days + " ngày.";
			ChiTietThueSach update = db.ChiTietThueSaches.Where(x => x.MaChiTiet == MaChiTiet).FirstOrDefault(); ;
			update.NgayTra = ngayTra;
			update.GhiChu = ghiChu;
			db.SaveChanges();
			this.Close();
		}

		private void IconPictureBox_Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Btn_XemChiTiet_Click(object sender, EventArgs e)
		{

			int maSach = db.ChiTietThueSaches.Where(x => x.MaChiTiet == MaChiTiet).FirstOrDefault().MaSach;
			Form f = new ChiTiet(maSach);
			f.StartPosition = FormStartPosition.CenterScreen;
			f.ShowDialog();
		}

		void loaddata(Sach x, NguoiThue nguoiThue, ChiTietThueSach chiTietThueSach)
		{
			textBox_TenSach.Text = x.TenSach;
			textBox_TenNguoiThue.Text = nguoiThue.TenNguoiThue;
			textBox_SoDienThoai.Text = nguoiThue.SoDienThoai;
			textBox_DiaChi.Text = nguoiThue.DiaChi;
			string imgBook = x.LinkHinh.ToString();
			string path = $@"Resources\{imgBook}";
			pictureBox_sach.Image = Image.FromFile(path);
			pictureBox_sach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			dateTimePicker.Value = chiTietThueSach.NgayTra ?? DateTime.Now;
		}

		

		private void textBox_SoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
				e.Handled = false;
			else
				e.Handled = true;
		}
	}
}
