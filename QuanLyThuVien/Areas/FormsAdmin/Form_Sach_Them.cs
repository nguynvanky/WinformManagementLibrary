using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.Areas.FormsAdmin
{
	public partial class Form_Sach_Them : Form
	{
		public Form_Sach_Them()
		{
			InitializeComponent();
			this.FormBorderStyle = FormBorderStyle.None;
			btn_LuuLai.Enabled = false;
			this.textBox_namXuatBan.KeyPress += TextBox_namXuatBan_KeyPress;
		}

		

		private void TextBox_namXuatBan_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) ) // là số
			{
				e.Handled = false; // nếu như là số thì cho phép nhập
			}
			else
			{
				e.Handled = true; // còn không phải thì chặn lại
			}
		}

		private Bitmap myBitmap;
		string path = $@"Resources\";
		string filename = "";
		private void btn_Sach_ThemHinh_Click(object sender, EventArgs e)
		{
			OpenFileDialog opnfd = new OpenFileDialog();
			opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
			if (opnfd.ShowDialog() == DialogResult.OK)
			{       
				pictureBox_sach.Image = new Bitmap(opnfd.FileName);
				filename = opnfd.SafeFileName;
				pictureBox_sach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
				path += filename;
				myBitmap = new Bitmap(opnfd.FileName);
			}
			btn_LuuLai.Enabled = true;

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}
		private bool check_input()
		{
			if (string.IsNullOrEmpty(textBox_namXuatBan.Text) || string.IsNullOrEmpty(textBox_tenSach.Text) || string.IsNullOrEmpty(textBox_nhaXuatBan.Text) || cbb_TacGia.SelectedValue == null || cbb_TheLoai.SelectedValue == null ||string.IsNullOrEmpty(textBox_SoLuong.Text))
				return false;
			return true;
		}
		Library_Entities db = new Library_Entities();

		private void btn_LuuLai_Click(object sender, EventArgs e)
		{
			if(!check_input() )
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
				return;
			}
			myBitmap.Save(path);
			Sach insert = new Sach();
			insert.TenSach = textBox_tenSach.Text;
			insert.MaTacGia = (int)cbb_TacGia.SelectedValue;
			insert.MaTheLoai = (int)cbb_TheLoai.SelectedValue;
			insert.TenNXB = textBox_nhaXuatBan.Text;
			insert.NamXuatBan =int.Parse(textBox_namXuatBan.Text);
			insert.LinkHinh = filename;
			db.Saches.Add(insert);
			db.SaveChanges();
			// luu tren csdl

			// them vao kho sach
			int MaSach = db.Saches.ToList().Last().MaSach;
			int SoLuong = int.Parse(textBox_SoLuong.Text);
			KhoSach temp = new KhoSach();
			temp.SoLuong = SoLuong;
			temp.MaSach = MaSach;
			db.KhoSaches.Add(temp);
			db.SaveChanges();
			// luu tren co so du lieu
			this.Close();
			
		}
		void loadTacGia()
		{
			cbb_TacGia.DataSource = db.TacGias.ToList();
			cbb_TacGia.DisplayMember = "TenTacGia";
			cbb_TacGia.ValueMember = "MaTacGia";
			cbb_TacGia.SelectedIndex = -1;

		}
		void loadTheLoai()
		{
			cbb_TheLoai.DataSource = db.TheLoais.ToList();
			cbb_TheLoai.DisplayMember = "TenTheLoai";
			cbb_TheLoai.ValueMember = "MaTheLoai";
			cbb_TheLoai.SelectedIndex = -1;
		}
		private void Form_Sach_Them_Load(object sender, EventArgs e)
		{
			loadTacGia();
			loadTheLoai();
		}

		private void iconPictureBox_Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void link_ThemTacGia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form f = new Form_TacGia_Them();
			f.StartPosition = FormStartPosition.CenterScreen;
			f.ShowDialog();
			loadTacGia();
		}

		private void link_ThemTheLoai_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form f = new Form_TheLoai_Them();
			f.StartPosition = FormStartPosition.CenterScreen;
			f.ShowDialog();
			loadTheLoai();
		}

	
	}
}
