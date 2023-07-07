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
	public partial class Form_Sach_Sua : Form
	{
		Library_Entities db = new Library_Entities();
		private int MaSachCurrent;
		public Form_Sach_Sua()
		{
			InitializeComponent();
		}
		public Form_Sach_Sua(int MaSach)
		{
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.FormBorderStyle = FormBorderStyle.None;
			InitializeComponent();
			Sach x = db.Saches.Where(row => row.MaSach == MaSach).FirstOrDefault();
			MaSachCurrent = MaSach;
			loaddata(x);
		}
		void load_TacGia()
		{
			cbb_TacGia.DataSource = db.TacGias.ToList();
			cbb_TacGia.DisplayMember = "TenTacGia";
			cbb_TacGia.ValueMember = "MaTacGia";
		}
		void load_TheLoai()
		{
			cbb_TheLoai.DataSource = db.TheLoais.ToList();
			cbb_TheLoai.DisplayMember = "TenTheLoai";
			cbb_TheLoai.ValueMember = "MaTheLoai";
		}
		void loaddata(Sach x)
		{
			load_TheLoai();
			load_TacGia();
			textBox_tenSach.Text = x.TenSach.Trim();
			cbb_TacGia.SelectedValue = x.MaTacGia;
			cbb_TheLoai.SelectedValue = x.MaTheLoai;
			textBox_nhaXuatBan.Text = x.TenNXB.Trim();
			textBox_namXuatBan.Text = x.NamXuatBan.ToString().Trim();
			KhoSach khoSach = db.KhoSaches.Where(row => row.MaSach == MaSachCurrent).FirstOrDefault();
			textBox_SoLuong.Text = khoSach.SoLuong.ToString();
			string imgBook = x.LinkHinh.ToString().Trim();
			string path = $@"Resources\{imgBook}";
			pictureBox_sach.Image = Image.FromFile(path);
			pictureBox_sach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		}

		private void iconPictureBox_Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_LuuLai_Click(object sender, EventArgs e)
		{
			if(!check_Input())
			{
				MessageBox.Show("Vui lòng không để trống");
				return;
			}
			string TenSach = textBox_tenSach.Text;
			int MaTacGia = int.Parse(cbb_TacGia.SelectedValue.ToString());
			int MaTheLoai = int.Parse(cbb_TheLoai.SelectedValue.ToString());
			string TenNXB = textBox_nhaXuatBan.Text;
			int NamXuatBan = int.Parse(textBox_namXuatBan.Text);
			Sach update = db.Saches.Where(x => x.MaSach == MaSachCurrent).FirstOrDefault();
			update.TenSach = TenSach;
			update.MaTacGia = MaTacGia;
			update.MaTheLoai = MaTheLoai;
			update.TenNXB = TenNXB;
			update.NamXuatBan = NamXuatBan;
			db.SaveChanges();
			int SoLuong = int.Parse(textBox_SoLuong.Text);
			KhoSach khoSach = db.KhoSaches.Where(row => row.MaSach == MaSachCurrent).FirstOrDefault();
			khoSach.SoLuong = SoLuong;
			db.SaveChanges();
			this.Close();
		}

		private bool check_Input()
		{
			if (string.IsNullOrEmpty(textBox_tenSach.Text) || string.IsNullOrEmpty(textBox_namXuatBan.Text) || string.IsNullOrEmpty(textBox_nhaXuatBan.Text) || string.IsNullOrEmpty(textBox_SoLuong.Text) || cbb_TacGia.SelectedItem == null || cbb_TheLoai.SelectedItem == null)
				return false;
			return true;
		}

		private void Form_Sach_Sua_Load(object sender, EventArgs e)
		{

		}

		private void textBox_namXuatBan_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)) // là số
			{
				e.Handled = false; // nếu như là số thì cho phép nhập
			}
			else
			{
				e.Handled = true; // còn không phải thì chặn lại
			}
		}
	}
}
