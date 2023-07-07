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
	public partial class Form_TheLoai_Them : Form
	{
		public Form_TheLoai_Them()
		{
			InitializeComponent();
			this.btn_Them.Click += Btn_Them_Click;
		}

		private void Btn_Them_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(textBox_TheLoai.Text))
			{
				MessageBox.Show("Vui lòng không để trống");
				return;
			}
			string TenTheLoai = textBox_TheLoai.Text;
			TheLoai insert = new TheLoai();
			insert.TenTheLoai = TenTheLoai;
			Library_Entities db = new Library_Entities();
			db.TheLoais.Add(insert);
			db.SaveChanges();
			//
			this.Close();
		}

		private void iconPictureBox_Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
