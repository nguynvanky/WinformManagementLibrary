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
using QuanLyThuVien.Areas.FormsAdmin;
namespace QuanLyThuVien.Forms
{
	public partial class FormDangNhap : Form
	{
		Library_Entities db = new Library_Entities();

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
		public FormDangNhap()
		{
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.FormBorderStyle = FormBorderStyle.None;
			InitializeComponent();
		}
		private void panelControlBox_Paint(object sender, EventArgs e)
		{

		}
		private void iconPictureBox_Exit_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
				Application.Exit();
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

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void FormDangNhap_Load(object sender, EventArgs e)
		{

		}

		private void panelControlBox_Paint(object sender, PaintEventArgs e)
		{

		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			FormQuenMatKhau f = new FormQuenMatKhau();
			this.Hide();
			f.ShowDialog();
			this.Show();

		}
		private bool Login(string user, string password)
		{
			if (string.IsNullOrWhiteSpace(textBoxMatKhau.Text) || string.IsNullOrWhiteSpace(textBoxTaiKhoan.Text))
			{
				MessageBox.Show("Tài khoản hoặc mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OKCancel);
				return false;
			}
			try
			{

			foreach(TaiKhoan i in db.TaiKhoans)
			{
				if(i.C_USER.Equals(user) && i.C_PASSWORD.Equals(password))
				{
					//MessageBox.Show($"Bạn đã đăng nhập thành công tài khoản {i.FullName}","Thông báo",MessageBoxButtons.OK);
					return true;
				}
			}
			MessageBox.Show("Tài khoản hoặc mật khẩu sai", "Thông báo", MessageBoxButtons.OK);
			return false;
			}
			catch
			{
				MessageBox.Show("Chưa kết nối cơ sở dữ liệu");
				return false;
			}
		}
		private void btn_DangNhap_Click(object sender, EventArgs e)
		{
			string user, password;
			user = textBoxTaiKhoan.Text;
			password = textBoxMatKhau.Text;
			if(user.Equals("admin") && password.Equals("admin"))
			{

				this.Hide();
				Form f = new FormHomeAdmin();
				f.StartPosition = FormStartPosition.CenterScreen;
				f.ShowDialog();
				this.Show();
			}
			else if (Login(user, password))
			{
				this.Hide();
				Form f = new Home(user);
				f.StartPosition = FormStartPosition.CenterScreen;
				f.ShowDialog();
				this.Show();
			}
		}

		private void textBoxTaiKhoan_TextChanged(object sender, EventArgs e)
		{
			Control ctr = (Control)sender;
			if (string.IsNullOrEmpty(textBoxTaiKhoan.Text))
			{
				this.errorProvider1.SetError(ctr, "Không được để trống");
			}
			else
				this.errorProvider1.Clear();

		}

		private void textBoxTaiKhoan_MouseLeave(object sender, EventArgs e)
		{

		}

		private void textBoxMatKhau_MouseLeave(object sender, EventArgs e)
		{

		}

		private void textBoxMatKhau_TextChanged(object sender, EventArgs e)
		{
			Control ctr = (Control)sender;
			if (string.IsNullOrEmpty(textBoxTaiKhoan.Text))
			{
				this.errorProvider1.SetError(ctr, "Không được để trống");
			}
			else
				this.errorProvider1.Clear();
		}

		private void textBoxTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar))
			{
				e.Handled = false; // cho phép
			}
			else
			{
				e.Handled = true; // chặn lại
			}
		}
	}
}
