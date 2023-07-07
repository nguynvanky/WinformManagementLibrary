using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.Areas.FormsAdmin
{
	public partial class Form_NhanVien_Sua : Form
	{
		public Form_NhanVien_Sua()
		{
			InitializeComponent();
		}
		string _user = "";
		public Form_NhanVien_Sua(string user)
		{
			InitializeComponent();
			_user = user;
			this.Load += Form_NhanVien_Sua_Load;
		}

		private void Form_NhanVien_Sua_Load(object sender, EventArgs e)
		{
			loadUser();
			textBox_TenTaiKhoan.ReadOnly = true;
		}
		void loadUser()
		{
			Library_Entities db = new Library_Entities();
			TaiKhoan taiKhoan = db.TaiKhoans.Where(x => x.C_USER.Equals(_user)).FirstOrDefault();
			textBox_TenTaiKhoan.Text = taiKhoan.C_USER;
			textBox_MatKhau.Text = taiKhoan.C_PASSWORD;
			textBox_HoTen.Text = taiKhoan.FullName;
		}
		private void iconPictureBox1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_LuuLai_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(textBox_HoTen.Text) || string.IsNullOrEmpty(textBox_MatKhau.Text))
			{
				MessageBox.Show("Vui lòng điền đầy đủ thông tin");
				return;
			}
			Library_Entities db = new Library_Entities();
			string user = textBox_TenTaiKhoan.Text;
			string hoten = textBox_HoTen.Text;
			string password = textBox_TenTaiKhoan.Text;
			TaiKhoan update = db.TaiKhoans.Where(x => x.C_USER.Trim().Equals(user)).FirstOrDefault();
			update.FullName = hoten;
			update.C_PASSWORD = password;
			db.SaveChanges();
		}
	}
}
