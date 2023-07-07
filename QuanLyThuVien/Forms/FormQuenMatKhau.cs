using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms
{
	public partial class FormQuenMatKhau : Form
	{
		//Drag Form
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		private void panelControlBox_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		public FormQuenMatKhau()
		{
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.FormBorderStyle = FormBorderStyle.None;
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

			InitializeComponent();
		}

		private void iconPictureBox_Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void iconPictureBox_Minimize_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;

		}

		private void iconPictureBox_Maximize_Click(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
				WindowState = FormWindowState.Maximized;
			else
				WindowState = FormWindowState.Normal;
		}



		private void FormQuenMatKhau_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			Control ctr = (Control)sender;
			if (!ctr.Text.Equals(textBoxMatKhau.Text))
				this.Check_same_pass.SetError(ctr, "Mật khẩu không trùng nhau");
			else
				this.Check_same_pass.Clear();


		}

		private void btn_XacNhan_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxXacNhanMatKhau.Text) || string.IsNullOrEmpty(textBoxTaiKhoan.Text) || string.IsNullOrEmpty(textBoxMatKhau.Text))
				MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OKCancel);
			Library_Entities db = new Library_Entities();
			TaiKhoan x = db.TaiKhoans.Where(a => a.C_USER.Equals(textBoxTaiKhoan.Text)).FirstOrDefault();
			if (x == null)
				MessageBox.Show("Không tồn tài tài khoản này", "Thông báo", MessageBoxButtons.OK);
			else
			{
				if(!textBoxMatKhau.Text.Equals(textBoxXacNhanMatKhau.Text))
				{
					MessageBox.Show("Mật khẩu không trùng", "Thông báo", MessageBoxButtons.OK);
					return;
				}
				x.C_PASSWORD = textBoxXacNhanMatKhau.Text;
				db.SaveChanges();
				MessageBox.Show("Tìm lại mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);
				this.Hide();
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
