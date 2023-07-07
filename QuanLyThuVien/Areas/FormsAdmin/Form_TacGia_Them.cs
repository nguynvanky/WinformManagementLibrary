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
	public partial class Form_TacGia_Them : Form
	{
		public Form_TacGia_Them()
		{
			InitializeComponent();
		}
		private bool check_Input()
		{
			if(string.IsNullOrEmpty(textBox_NamSinh.Text) || string.IsNullOrEmpty(textBox_TenTacGia.Text) )
			{
				return false;
			}
			return true;
		}
		private void btn_Them_Click(object sender, EventArgs e)
		{
			if(!check_Input())
			{
				MessageBox.Show("Vui lòng không để trống");
				return;
			}
			string TenTacGia = textBox_TenTacGia.Text;
			int NamSinh = int.Parse(textBox_NamSinh.Text);
			TacGia x = new TacGia();
			x.TenTacGia = TenTacGia;
			x.NamSinh = NamSinh;
			Library_Entities db = new Library_Entities();
			db.TacGias.Add(x);
			db.SaveChanges();
			this.Close();
		}

		private void iconPictureBox1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
