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
	public partial class Form_TacGia_Sua : Form
	{
		public Form_TacGia_Sua()
		{
			InitializeComponent();
		}
		int maTacGiaCurrent = -1;
		public Form_TacGia_Sua(int maTacGia)
		{
			InitializeComponent();
			maTacGiaCurrent = maTacGia;
		}
		void load_Data(int maTacGia)
		{
			Library_Entities db = new Library_Entities();
			TacGia tacGia = db.TacGias.Where(x => x.MaTacGia == maTacGia).FirstOrDefault();
			textBox_TenTacGia.Text = tacGia.TenTacGia.Trim();
			textBox_NamSinh.Text = tacGia.NamSinh.ToString().Trim();
		}
		private void Form_TacGia_Sua_Load(object sender, EventArgs e)
		{
			load_Data(maTacGiaCurrent);
		}

		private void iconPictureBox1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_LuuLai_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox_NamSinh.Text) || string.IsNullOrEmpty(textBox_TenTacGia.Text))
			{
				MessageBox.Show("Vui lòng không để trống");
				return;
			}
			Library_Entities db = new Library_Entities();
			TacGia tacGia = db.TacGias.Where(x => x.MaTacGia == maTacGiaCurrent).FirstOrDefault();
			string TenTacGia = textBox_TenTacGia.Text;
			int NamSinh = int.Parse(textBox_NamSinh.Text);
			tacGia.TenTacGia = TenTacGia;
			tacGia.NamSinh = NamSinh;
			db.SaveChanges();
			// luu tren csdl
			this.Close();
		}
	}
}
