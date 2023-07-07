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
	public partial class FormChiTietThueSach : Form
	{
		public int MaNguoiThue { get; set; }
		public int MaSach { get; set; }
		Library_Entities db = new Library_Entities();
		public FormChiTietThueSach()
		{
			InitializeComponent();


		}


		private void Btn_XemChiTiet_Click(object sender, EventArgs e)
		{
			Guna2Button btn = sender as Guna2Button;
			int maSach = (int)btn.Tag;
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
			textBox_GhiChu.Text = chiTietThueSach.GhiChu;
			string TenNguoiChoMuon = db.TaiKhoans.Where(row => row.C_USER.Equals(chiTietThueSach.NguoiChoThue)).FirstOrDefault().FullName;
			textBox_NguoiChoMuon.Text = "Nhân viên " + TenNguoiChoMuon;
			string imgBook = x.LinkHinh.ToString();
			string path = $@"Resources\{imgBook}";
			pictureBox_sach.Image = Image.FromFile(path);
			pictureBox_sach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		}
		private void FormChiTietThueSach_Load(object sender, EventArgs e)
		{
			ThueSach thueSach = db.ThueSaches.Where(x => x.MaNguoiThue == MaNguoiThue).FirstOrDefault();
			NguoiThue nguoiThue = db.NguoiThues.Where(x => x.MaNguoiThue == MaNguoiThue).FirstOrDefault();
			ChiTietThueSach chiTietThueSach = db.ChiTietThueSaches.Where(x => x.MaThueSach == thueSach.MaThueSach && x.MaSach == MaSach).FirstOrDefault();
			Sach sach = db.Saches.Where(x => x.MaSach == chiTietThueSach.MaSach).FirstOrDefault();
			loaddata(sach, nguoiThue, chiTietThueSach);
			this.btn_XemChiTiet.Tag = sach.MaSach;
			this.btn_XemChiTiet.Click += Btn_XemChiTiet_Click;
		}

		private void iconPictureBox_Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
