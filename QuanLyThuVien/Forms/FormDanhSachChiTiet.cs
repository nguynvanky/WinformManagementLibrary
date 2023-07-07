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
	public partial class FormDanhSachChiTiet : Form
	{
		public int MaNguoiThue { get; set; }
		Library_Entities db = new Library_Entities();
		public FormDanhSachChiTiet()
		{
			InitializeComponent();
			this.Load += FormDanhSachChiTiet_Load;
			this.cbb_TrangThai.SelectionChangeCommitted += Cbb_TrangThai_SelectionChangeCommitted;
			this.btn_GiaHan.Click += Btn_GiaHan_Click;
			this.btn_TraSach.Click += Btn_TraSach_Click;
			dgv_ChiTietThueSach.CellMouseClick += Dgv_ChiTietThueSach_CellMouseClick;
		}

		private void Btn_TraSach_Click(object sender, EventArgs e)
		{
			if (dgv_ChiTietThueSach.CurrentRow == null)
			{
				MessageBox.Show("Vui lòng chọn 1 chi tiết");
				return;
			}
			if(MessageBox.Show("Xác nhận trả cuốn sách này?","Thông báo",MessageBoxButtons.YesNo) == DialogResult.No)
			{
				return;
			}
			int MaChiTiet = (int)dgv_ChiTietThueSach.CurrentRow.Cells["MaChiTiet"].Value;
			ChiTietThueSach update = db.ChiTietThueSaches.Where(x => x.MaChiTiet == MaChiTiet).FirstOrDefault();
			if (update.DaTra == 1)
			{
				MessageBox.Show("Sách này đã được trả rồi");
				return;
			}
			ThueSach thueSach = db.ThueSaches.Where(x => x.MaNguoiThue == MaNguoiThue && x.MaThueSach == update.MaThueSach).FirstOrDefault();
			thueSach.SoSachDaMuon--;
			int MaSach = update.MaSach;
			db.KhoSaches.Where(row => row.MaSach == MaSach).FirstOrDefault().SoLuong++;// khi trả sách thì tăng lên 1
			db.SaveChanges();
			update.DaTra = 1;
			update.GhiChu = "Đã trả";
			db.SaveChanges();
			this.Refresh();
			panel_main.Controls.Clear();
		}
		private void Btn_GiaHan_Click(object sender, EventArgs e)
		{
			panel_main.Controls.Clear();
			if (dgv_ChiTietThueSach.CurrentRow == null)
			{
				MessageBox.Show("Vui lòng chọn 1 chi tiết");
				return;
			}
			int MaSach = (int)dgv_ChiTietThueSach.CurrentRow.Cells["MaSach"].Value;
			ThueSach thueSach = db.ThueSaches.Where(x => x.MaNguoiThue == MaNguoiThue).FirstOrDefault();
			ChiTietThueSach chiTietThueSach = db.ChiTietThueSaches.Where(x => x.MaThueSach == thueSach.MaThueSach && x.MaSach == MaSach).FirstOrDefault();
			if (chiTietThueSach.DaTra == 1)
			{
				MessageBox.Show("Sách này đã được trả rồi");
				return;
			}
			FormGiaHan f = new FormGiaHan();
			f.MaChiTiet = chiTietThueSach.MaChiTiet;
			f.MaNguoiThue = MaNguoiThue;
			f.StartPosition = FormStartPosition.CenterScreen;
			f.ShowDialog();
		}

		private void Cbb_TrangThai_SelectionChangeCommitted(object sender, EventArgs e)
		{
			int MaThueSach = db.ThueSaches.Where(x => x.MaNguoiThue == MaNguoiThue).FirstOrDefault().MaThueSach;

			if (cbb_TrangThai.SelectedIndex == 0)// tat ca
			{
				dgv_ChiTietThueSach.DataSource = db.ChiTietThueSaches.Where(x => x.MaThueSach == MaThueSach).ToList();
			}
			else if (cbb_TrangThai.SelectedIndex == 1) // da tra
			{
				dgv_ChiTietThueSach.DataSource = db.ChiTietThueSaches.Where(x => x.MaThueSach == MaThueSach && x.DaTra == 1).ToList();

			}
			else if (cbb_TrangThai.SelectedIndex == 2) // chua tra
			{
				dgv_ChiTietThueSach.DataSource = db.ChiTietThueSaches.Where(x => x.MaThueSach == MaThueSach && x.DaTra == 0).ToList();

			}
		
		}

		private void Dgv_ChiTietThueSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			panel_main.Controls.Clear();
			int MaSach = (int)dgv_ChiTietThueSach.CurrentRow.Cells["MaSach"].Value;
			loadChildForm(MaSach);
		}
		void loadChildForm(int MaSach)
		{
			FormChiTietThueSach f = new FormChiTietThueSach();
			f.MaNguoiThue = MaNguoiThue;
			f.MaSach = MaSach;
			f.TopLevel = false;
			panel_main.Controls.Add(f);
			f.Dock = DockStyle.Fill;
			f.Visible = true;
		}
		void loadTrangThai()
		{
			cbb_TrangThai.Items.Add("Tất cả");
			cbb_TrangThai.Items.Add("Đã trả");
			cbb_TrangThai.Items.Add("Chưa trả");
			cbb_TrangThai.SelectedIndex = 0;
		}
		private void FormDanhSachChiTiet_Load(object sender, EventArgs e)
		{
			LoadDGV();
			loadTrangThai();
		}
		void LoadDGV()
		{
			int MaThueSach = db.ThueSaches.Where(x => x.MaNguoiThue == MaNguoiThue).FirstOrDefault().MaThueSach;
			dgv_ChiTietThueSach.DataSource = db.ChiTietThueSaches.Where(x => x.MaThueSach == MaThueSach).ToList();
			dgv_ChiTietThueSach.Columns["MaChiTiet"].Visible = false;
			dgv_ChiTietThueSach.Columns["MaThueSach"].Visible = false;
			dgv_ChiTietThueSach.Columns["DaTra"].Visible = false;
			dgv_ChiTietThueSach.Columns["Sach"].Visible = false;
			dgv_ChiTietThueSach.Columns["ThueSach"].Visible = false;
			dgv_ChiTietThueSach.Columns["GhiChu"].Visible = false;

			dgv_ChiTietThueSach.Columns["NgayTra"].DefaultCellStyle.Format = "dd/MM/yyyy";
			dgv_ChiTietThueSach.Columns["NgayThue"].DefaultCellStyle.Format = "dd/MM/yyyy";
			//
			dgv_ChiTietThueSach.Columns["NgayTra"].HeaderText = "Ngày trả";
			dgv_ChiTietThueSach.Columns["NgayThue"].HeaderText = "Ngày mượn";
			dgv_ChiTietThueSach.Columns["MaSach"].HeaderText = "Mã sách";
			dgv_ChiTietThueSach.Columns["NguoiChoThue"].HeaderText = "Nhân viên cho cho mượn";
			dgv_ChiTietThueSach.ClearSelection();
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

		private void iconPictureBox_Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
