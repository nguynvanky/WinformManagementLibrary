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
namespace QuanLyThuVien.Areas.FormsAdmin
{
	public partial class FormHomeAdmin : Form
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
		private int MaSachCurrent = -1;
		private int MaTacGiaCurrent = -1;
		private int MaTheLoaiCurrent = -1;
		private string _UserCurrent = "";
		public FormHomeAdmin()
		{
			InitializeComponent();
			this.Load += FormHomeAdmin_Load;
		}
		private void FormHomeAdmin_Load(object sender, EventArgs e)
		{

			loadTacGia();
			loadSach();
			loadTheLoai();
			loadNhanVien();
			dtgv_TacGia.CellMouseClick += Dtgv_TacGia_CellMouseClick;
			dtgv_Sach.CellMouseClick += Dtgv_Sach_CellMouseClick;
			dtgv_TheLoai.CellMouseClick += Dtgv_TheLoai_CellMouseClick;
			dtgv_NhanVien.CellMouseClick += Dtgv_NhanVien_CellMouseClick;
		}


		#region Sach
		// ---------------------- Sach -----------------------
		private void Dtgv_Sach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.dtgv_Sach.Rows[e.RowIndex];
				MaSachCurrent = (int)row.Cells["MaSach"].Value;
			}
		}
		void loadSach()
		{
			Library_Entities db = new Library_Entities();

			dtgv_Sach.DataSource = db.Saches.ToList();
			dtgv_Sach.Columns["MaTacGia"].Visible = false;
			dtgv_Sach.Columns["MaTheLoai"].Visible = false;
			dtgv_Sach.Columns["KhoSach"].Visible = false;
			dtgv_Sach.Columns["MaTacGia"].Visible = false;
			dtgv_Sach.Columns["LinkHinh"].Visible = false;
			dtgv_Sach.Columns["TacGia"].Visible = false;
			dtgv_Sach.Columns["TheLoai"].Visible = false;
			dtgv_Sach.Columns["ChiTietThueSaches"].Visible = false;

			dtgv_Sach.Columns["MaSach"].HeaderText = "Mã sách";
			dtgv_Sach.Columns["TenSach"].HeaderText = "Tên sách";
			dtgv_Sach.Columns["TenNXB"].HeaderText = "Tên NXB";
			dtgv_Sach.Columns["NamXuatBan"].HeaderText = "Năm Xuất bản";
			dtgv_Sach.ClearSelection();
		}
		private void btn_Sach_Them_Click(object sender, EventArgs e)
		{
			Form f = new Form_Sach_Them();
			f.StartPosition = FormStartPosition.CenterScreen;
			f.ShowDialog();
			loadSach();
			this.Refresh();
		}
		private void btn_Sach_Sua_Click(object sender, EventArgs e)
		{
			if (MaSachCurrent == -1)
			{
				MessageBox.Show("Vui lòng chọn một sách");
				return;
			}
			Form f = new Form_Sach_Sua(MaSachCurrent);
			f.StartPosition = FormStartPosition.CenterScreen;
			f.ShowDialog();
			loadSach();
			this.Refresh();
		}
		private void btn_Sach_Xoa_Click(object sender, EventArgs e)
		{
			if (MaSachCurrent == -1)
			{
				MessageBox.Show("Vui lòng chọn một sách");
				return;
			}
			if (MessageBox.Show("Xác nhận xóa cuốn sách này?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{

				Library_Entities db = new Library_Entities();
				Sach delete = db.Saches.Where(x => x.MaSach == MaSachCurrent).FirstOrDefault();
				try
				{
					KhoSach temp = db.KhoSaches.Where(x => x.MaSach == delete.MaSach).FirstOrDefault();
					db.KhoSaches.Remove(temp);
					db.Saches.Remove(delete);
				}
				catch (Exception ec)
				{
					MessageBox.Show("Sách này hiện tại đang có người thuê không thể xóa được");
					return;
				}
				db.SaveChanges();
				loadSach();
				this.Refresh();
			}
		}
		#endregion
		#region Tac Gia
		void loadTacGia()
		{
			Library_Entities db = new Library_Entities();
			dtgv_TacGia.DataSource = db.TacGias.ToList();
			dtgv_TacGia.Columns["MaTacGia"].Visible = false;
			dtgv_TacGia.Columns["Saches"].Visible = false;

			dtgv_TacGia.Columns["TenTacGia"].HeaderText = "Tên tác giả";
			dtgv_TacGia.Columns["NamSinh"].HeaderText = "Năm sinh";


			dtgv_TacGia.ClearSelection();

		}
		private void Dtgv_TacGia_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.dtgv_TacGia.Rows[e.RowIndex];
				MaTacGiaCurrent = (int)row.Cells["MaTacGia"].Value;
			}
		}

		private void btn_TacGia_Them_Click(object sender, EventArgs e)
		{
			Form f = new Form_TacGia_Them();
			f.StartPosition = FormStartPosition.CenterScreen;
			f.ShowDialog();
			loadTacGia();
			this.Refresh();
		}

		private void btn_TacGia_Sua_Click(object sender, EventArgs e)
		{
			if (MaTacGiaCurrent == -1)
			{
				MessageBox.Show("Vui lòng chọn một sách");
				return;
			}
			Form f = new Form_TacGia_Sua(MaTacGiaCurrent);
			f.StartPosition = FormStartPosition.CenterScreen;
			f.ShowDialog();
			loadTacGia();
			this.Refresh();
		}

		private void btn_TacGiaXoa_Click(object sender, EventArgs e)
		{
			if (MaTacGiaCurrent == -1)
			{
				MessageBox.Show("Vui lòng chọn một tác giả");
				return;
			}
			if (MessageBox.Show("Xác nhận xóa tác giả này?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{

				Library_Entities db = new Library_Entities();
				TacGia delete = db.TacGias.Where(x => x.MaTacGia == MaTacGiaCurrent).FirstOrDefault();
				try
				{
					db.TacGias.Remove(delete);
					db.SaveChanges();
				}
				catch (Exception ec)
				{
					MessageBox.Show("Tác giả này hiện đang là khóa ngoại của 1 sách không thể xóa được");
				}
				loadTacGia();
				this.Refresh();
			}
		}
		#endregion
		#region The loai
		private void Dtgv_TheLoai_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.dtgv_TheLoai.Rows[e.RowIndex];
				MaTheLoaiCurrent = (int)row.Cells["MaTheLoai"].Value;
			}
		}
		void loadTheLoai()
		{
			Library_Entities db = new Library_Entities();
			dtgv_TheLoai.DataSource = db.TheLoais.ToList();
			dtgv_TheLoai.Columns["Saches"].Visible = false;
			//
			dtgv_TheLoai.Columns["MaTheLoai"].HeaderText = "Mã thể loại";
			dtgv_TheLoai.Columns["TenTheLoai"].HeaderText = "Tên thể loại";
			dtgv_TheLoai.ClearSelection();
		}



		private void btn_TheLoai_Them_Click(object sender, EventArgs e)
		{
			Form f = new Form_TheLoai_Them();
			f.StartPosition = FormStartPosition.CenterScreen;
			f.ShowDialog();
			loadTheLoai();
			this.Refresh();
		}

		private void btn_TheLoai_Sua_Click(object sender, EventArgs e)
		{
			if (MaTheLoaiCurrent == -1)
			{
				MessageBox.Show("Vui lòng chọn một thể loại");
				return;
			}
			Form f = new Form_TheLoai_Sua(MaTheLoaiCurrent);
			f.StartPosition = FormStartPosition.CenterScreen;
			f.ShowDialog();
			loadTheLoai();
			this.Refresh();
		}

		private void btn_TheLoai_Xoa_Click(object sender, EventArgs e)
		{
			if (MaTheLoaiCurrent == -1)
			{
				MessageBox.Show("Vui lòng chọn một thể loại");
				return;
			}
			if (MessageBox.Show("Xác nhận xóa thể loại này?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{

				Library_Entities db = new Library_Entities();
				TheLoai delete = db.TheLoais.Where(x => x.MaTheLoai == MaTheLoaiCurrent).FirstOrDefault();
				try
				{
					db.TheLoais.Remove(delete);
					db.SaveChanges();
					// 
				}
				catch (Exception ec)
				{
					MessageBox.Show("Thể loại này hiện đang là khóa ngoại của 1 sách không thể xóa được");
				}
				loadTacGia();
				this.Refresh();
			}
		}
		#endregion
		#region Nhan vien
		private void Dtgv_NhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.dtgv_NhanVien.Rows[e.RowIndex];
				_UserCurrent = row.Cells["C_USER"].Value.ToString();
			}
		}
		void loadNhanVien()
		{
			Library_Entities db = new Library_Entities();
			dtgv_NhanVien.DataSource = db.TaiKhoans.ToList();
			dtgv_NhanVien.Columns["C_USER"].HeaderText = "Tên tài khoản";
			dtgv_NhanVien.Columns["C_PASSWORD"].HeaderText = "Mật khẩu";
			dtgv_NhanVien.Columns["FullName"].HeaderText = "Tên Nhân Viên";
			dtgv_NhanVien.ClearSelection();
		}
		private void btn_NhanVien_Them_Click(object sender, EventArgs e)
		{
			Form f = new Form_NhanVien_Them();
			f.StartPosition = FormStartPosition.CenterScreen;
			f.ShowDialog();
			loadNhanVien();
			this.Refresh();
		}
		private void btn_NhanVien_Sua_Click(object sender, EventArgs e)
		{
			if (_UserCurrent == "")
			{
				MessageBox.Show("Vui lòng chọn một nhân viên");
				return;
			}
			Form f = new Form_NhanVien_Sua(_UserCurrent);
			f.StartPosition = FormStartPosition.CenterScreen;
			f.ShowDialog();
			loadNhanVien();
			this.Refresh();
		}
		private void btn_NhanVien_Xoa_Click(object sender, EventArgs e)
		{
			if (_UserCurrent == "")
			{
				MessageBox.Show("Vui lòng chọn một tài khoản");
				return;
			}
			if (MessageBox.Show("Xác nhận xóa tài khoản này?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Library_Entities db = new Library_Entities();
				TaiKhoan delete = db.TaiKhoans.Where(x => x.C_USER.Trim().Equals(_UserCurrent)).FirstOrDefault();
				if (delete.C_USER == "admin" && delete.C_USER == "admin")
				{
					MessageBox.Show("Không thể xóa tài khoản chủ");
					return;
				}
				db.TaiKhoans.Remove(delete);
				db.SaveChanges();
				loadNhanVien();
				this.Refresh();
			}
		}

		#endregion

		private void iconPictureBox_Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
