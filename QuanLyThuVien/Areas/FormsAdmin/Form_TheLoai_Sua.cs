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
	public partial class Form_TheLoai_Sua : Form
	{
		public Form_TheLoai_Sua()
		{
			InitializeComponent();
		}
		int maTheLoaiCurrent = -1;
		public Form_TheLoai_Sua(int maTheLoai)
		{
			InitializeComponent();
			maTheLoaiCurrent = maTheLoai;
			this.Load += Form_TheLoai_Sua_Load;
			this.btn_LuuLai.Click += Btn_LuuLai_Click;
		}

		private void Btn_LuuLai_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(textBox_TheLoai.Text))
			{
				MessageBox.Show("Vui lòng không để trống");
				return;
			}
			Library_Entities db = new Library_Entities();
			TheLoai theLoai = db.TheLoais.Where(x => x.MaTheLoai == maTheLoaiCurrent).FirstOrDefault();
			string TenTheLoai = textBox_TheLoai.Text.Trim();
			theLoai.TenTheLoai = TenTheLoai;
			db.SaveChanges();
			//
			this.Close();
		}

		private void Form_TheLoai_Sua_Load(object sender, EventArgs e)
		{
			loadData(maTheLoaiCurrent);
		}

		void loadData(int maTheLoai)
		{
			Library_Entities db = new Library_Entities();
			TheLoai data = db.TheLoais.Where(x => x.MaTheLoai == maTheLoai).FirstOrDefault();
			textBox_TheLoai.Text = data.TenTheLoai.Trim();
		}
		private void iconPictureBox_Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
