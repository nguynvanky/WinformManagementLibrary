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
	public partial class Form_NhanVien_Them : Form
	{
		public Form_NhanVien_Them()
		{
			InitializeComponent();
		}

		private void iconPictureBox1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		bool checkinput()
		{
			if (string.IsNullOrEmpty(textBox_HoTen.Text) || string.IsNullOrEmpty(textBox_MatKhau.Text) || string.IsNullOrEmpty(textBox_TenTaiKhoan.Text))
				return false;
			return true;
		}
		private void btn_Them_Click(object sender, EventArgs e)
		{
			if(checkinput() == false)
			{
				MessageBox.Show("Vui lòng điền đầy đủ thông tin");
				return;
			}
			string user = textBox_TenTaiKhoan.Text;
			string hoten = textBox_HoTen.Text;
			string password = textBox_TenTaiKhoan.Text;
			TaiKhoan insert = new TaiKhoan();
			insert.C_USER = user;
			insert.C_PASSWORD = password;
			insert.FullName = hoten;
			Library_Entities db = new Library_Entities();
			if(db.TaiKhoans.Where(x=>x.C_USER.Trim().Equals(user)).FirstOrDefault() != null)
			{
				MessageBox.Show("Tên tài khoản này đã tồn tại");
				return;
			}
			db.TaiKhoans.Add(insert);
			db.SaveChanges();
			this.Close();
		}
	}
}
