using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms
{
	public partial class ChiTiet : Form
	{
		Library_Entities db = new Library_Entities();
		public ChiTiet()
		{
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.FormBorderStyle = FormBorderStyle.None;
			InitializeComponent();
		}
		void loaddata(Sach x)
		{
			textBox_tenSach.Text = x.TenSach;
			textBox_tacGia.Text = x.TacGia.TenTacGia;
			textBox_theLoai.Text = x.TheLoai.TenTheLoai;
			textBox_nhaXuatBan.Text = x.TenNXB;
			textBox_namXuatBan.Text = x.NamXuatBan.ToString();
			KhoSach khoSach = db.KhoSaches.Where(row => row.MaSach == x.MaSach).FirstOrDefault();
			textBox_SoLuong.Text = khoSach.SoLuong.ToString();
			string imgBook = x.LinkHinh.ToString();
			string path = $@"Resources\{imgBook}";
			pictureBox_sach.Image = Image.FromFile(path);
			pictureBox_sach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		}
		public ChiTiet(int maSach)
		{
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.FormBorderStyle = FormBorderStyle.None;
			InitializeComponent();
			Library_Entities db = new Library_Entities();
			Sach x = db.Saches.Where(row => row.MaSach == maSach).FirstOrDefault();
			loaddata(x);
		}
		
		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pictureBox_sach_Click(object sender, EventArgs e)
		{

		}

		private void textBox_tacGia_TextChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void textBox_theLoai_TextChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void textBox_nhaXuatBan_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void textBox_namXuatBan_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void textBox_tenSach_TextChanged(object sender, EventArgs e)
		{

		}

		private void label_tenSach_Click(object sender, EventArgs e)
		{

		}

		private void ChiTiet_Load(object sender, EventArgs e)
		{

		}

		private void iconPictureBox_Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
