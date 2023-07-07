using FontAwesome.Sharp;
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
using QuanLyThuVien.Forms;

namespace QuanLyThuVien
{
	public partial class Home : Form
	{
		private Panel leftBorderBtn;
		private IconButton currentBtn;
		private Form currentChildForm;
		string user;
		Library_Entities db = new Library_Entities();

		private struct RGBColors
		{
			public static Color color1 = Color.FromArgb(60, 35, 23);
			public static Color color2 = Color.FromArgb(98, 142, 144);
			public static Color color3 = Color.FromArgb(78, 108, 80);
			public static Color color4 = Color.FromArgb(97, 118, 75);
			public static Color color5 = Color.FromArgb(80, 87, 122);
			public static Color color6 = Color.FromArgb(79, 160, 149);
		}
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
		//constructor
		public Home(string _user)
		{
			user = _user;
			Library_Entities db = new Library_Entities();
			TaiKhoan x = db.TaiKhoans.Where(row => row.C_USER == _user).FirstOrDefault();
			string name = x.FullName;
			this.StartPosition = FormStartPosition.CenterScreen;
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.FormBorderStyle = FormBorderStyle.None;
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
			this.Text = string.Empty;
			//
			InitializeComponent();
			if (name == "admin")
			{
				this.label_employee.Text = string.Empty;
			}
			else
			{
				this.label_employee.Text += name;
			}
			//Left border
			leftBorderBtn = new Panel();
			leftBorderBtn.Size = new Size(7, 60);
			panelMenu.Controls.Add(leftBorderBtn);
			StartTimer();

		}
		public Home()
		{

			this.StartPosition = FormStartPosition.CenterScreen;
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.FormBorderStyle = FormBorderStyle.None;
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
			this.Text = string.Empty;
			//
			InitializeComponent();
			//Left border
			leftBorderBtn = new Panel();
			leftBorderBtn.Size = new Size(7, 60);
			panelMenu.Controls.Add(leftBorderBtn);

		}
		private void ActivateButton(object senderBtn, Color color)
		{
			DisableButton();
			if (senderBtn != null)
			{
				//return all button to start
				//button
				currentBtn = (IconButton)senderBtn;
				currentBtn.BackColor = Color.FromArgb(206, 148, 97);
				currentBtn.ForeColor = color;
				currentBtn.TextAlign = ContentAlignment.MiddleCenter;
				currentBtn.IconColor = color;
				currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
				currentBtn.ImageAlign = ContentAlignment.MiddleRight;
				// Left border
				leftBorderBtn.BackColor = color;
				leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
				leftBorderBtn.Visible = true;
				leftBorderBtn.BringToFront();
				//Icon current child form

			}
		}
		private void DisableButton()
		{
			if (currentBtn != null)
			{
				leftBorderBtn.Visible = false;
				currentBtn.BackColor = Color.FromArgb(206, 148, 97);
				currentBtn.ForeColor = Color.FromArgb(252, 255, 231);
				currentBtn.TextAlign = ContentAlignment.MiddleCenter;
				currentBtn.IconColor = Color.FromArgb(252, 255, 231); ;
				currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
				currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
			}
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

		private void panelControlBox_Paint(object sender, PaintEventArgs e)
		{

		}

		private void iconButtonSach_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color1);
			Form F = new FormSach(user);
			OpenChildForm(F);
			label_tieude.Text = "Sách";
		}

		private void iconButtonTimkiem_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color1);
			OpenChildForm(new FormTimKiem());
			label_tieude.Text = "Tìm kiếm";

		}

		private void iconButtonThueSach_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color1);
			OpenChildForm(new FormThueSach());
			label_tieude.Text = "Những người đang mượn sách tại thư viện";
		}

		private void iconButtonTraSach_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color1);
			OpenChildForm(new FormQuaHan());
			label_tieude.Text = "Danh sách quá hạn trả sách";

		}

		private void pictureBoxLogo_Click(object sender, EventArgs e)
		{
			DisableButton();
			if (currentChildForm != null)
				currentChildForm.Close();
			label_tieude.Text = string.Empty;
		}

		private void panelMenu_Paint(object sender, PaintEventArgs e)
		{

		}

		private void OpenChildForm(Form childform)
		{
			if (currentChildForm != null)
			{
				currentChildForm.Close();
			}
			currentChildForm = childform;
			childform.TopLevel = false;
			childform.FormBorderStyle = FormBorderStyle.None;
			childform.Dock = DockStyle.Fill;
			childform.Size = new Size(panelDesktopWork.Size.Width, panelDesktopWork.Size.Height);
			panelDesktopWork.Controls.Add(childform);
			panelDesktopWork.Tag = childform;
			childform.BringToFront();
			childform.Show();
		}

		private void Home_Load(object sender, EventArgs e)
		{
		}

		private void panelDesktopWork_Paint(object sender, PaintEventArgs e)
		{

		}

		private void iconButtonTacGia_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color1);
			OpenChildForm(new FormTacGia());
			label_tieude.Text = "Sách theo tác giả";

		}

		private void iconButtonTheLoai_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color1);
			OpenChildForm(new FormTheLoai());
			label_tieude.Text = "Sách theo thể loại";

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label_employee_Click(object sender, EventArgs e)
		{

		}

		private void iconButton_DangXuat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		System.Windows.Forms.Timer t = null;
		private void StartTimer()
		{
			t = new System.Windows.Forms.Timer();
			t.Interval = 1000;
			t.Tick += new EventHandler(t_Tick);
			t.Enabled = true;
		}

		void t_Tick(object sender, EventArgs e)
		{
			lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
		}

		private void iconButton_Home_Sach_Click(object sender, EventArgs e)
		{
			Form F = new FormSach(user);
			OpenChildForm(F);
			label_tieude.Text = "Sách";
		}

		private void iconButton_Home_TimKiem_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FormTimKiem());
			label_tieude.Text = "Tìm kiếm";

		}

		private void iconButton_Home_MuonSach_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FormThueSach());
			label_tieude.Text = "Những người đang mượn sách tại thư viện";
		}

		private void iconButton_Home_QuaHan_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FormQuaHan());
			label_tieude.Text = "Danh sách người chưa trả sách";
		}

		private void iconButton_Home_TheLoai_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FormTheLoai());
			label_tieude.Text = "Sách theo thể loại";

		}

		private void iconButton_Home_TacGia_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FormTacGia());
			label_tieude.Text = "Sách theo tác giả";
		}
	}
}
