using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace QuanLyThuVien.Forms
{
	public partial class FormChoThue : Form
	{
		Library_Entities db = new Library_Entities();

		public string user { get; set; }
		public FormChoThue()
		{
			InitializeComponent();
		}
		private int maSach_Current;
		void load_data(int id)
		{
			Sach x = db.Saches.Where(row => row.MaSach == id).FirstOrDefault();
			string imgBook = x.LinkHinh.ToString();
			string path = $@"Resources\{imgBook}";
			pictureBox_sach.Image = Image.FromFile(path);
			pictureBox_sach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		}
		public FormChoThue(int id)
		{
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.FormBorderStyle = FormBorderStyle.None;
			InitializeComponent();
			maSach_Current = id;
			load_data(id);
			cbb_DocGiaCu.SelectionChangeCommitted += Cbb_DocGiaCu_SelectionChangeCommitted;
			dateTimePicker.Value = DateTime.Now;
			KhoSach khosach = db.KhoSaches.Where(row => row.MaSach == maSach_Current).FirstOrDefault();
			label_SoLuong.Text = "";
			if(khosach.SoLuong<1)
			{
				this.btn_xacNhan.Enabled = false;
				label_SoLuong.Text = "Sách đã hêt";
				toggle_DocGiaCu.Enabled = false ;
			}
		}

		private void Cbb_DocGiaCu_SelectionChangeCommitted(object sender, EventArgs e)
		{
			int MaNguoiThue = (int)cbb_DocGiaCu.SelectedValue;
			NguoiThue row = db.NguoiThues.Where(x => x.MaNguoiThue == MaNguoiThue).FirstOrDefault();
			textBox_soDienThoai.Text = row.SoDienThoai;
			textBox_hoTen.Text = row.TenNguoiThue;
			textBox_diaChi.Text = row.DiaChi;
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void FormChoThue_Load(object sender, EventArgs e)
		{

			clear_TextBox();
		}
		void clear_TextBox()
		{
			textBox_soDienThoai.Clear();
			textBox_diaChi.Clear();
			textBox_hoTen.Clear();
		}
		void load_cbb_DocGiaCu()
		{
			cbb_DocGiaCu.DataSource = db.NguoiThues.ToList();
			cbb_DocGiaCu.ValueMember = "MaNguoiThue";
			cbb_DocGiaCu.DisplayMember = "TenNguoiThue";
			cbb_DocGiaCu.SelectedIndex = -1;
		}
		private void iconPictureBox_Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		// true if empty
		bool check_input()
		{
			if (string.IsNullOrEmpty(textBox_hoTen.Text) || string.IsNullOrEmpty(textBox_diaChi.Text) || string.IsNullOrEmpty(textBox_soDienThoai.Text))
			{
				return true;
			}
			return false;
		}
		void addNew(TaiKhoan x)
		{
			var saveChangesResult = db.SaveChanges();
			if (saveChangesResult == 0)
			{
				MessageBox.Show("User permission could not be saved");
			}
			List<TaiKhoan> l = db.TaiKhoans.ToList();

		}
		string GhiChu(DateTime ngayTra)
		{
			DateTime ngayThue = DateTime.Now;
			ngayTra = dateTimePicker.Value;
			TimeSpan diffResult = ngayTra.Subtract(ngayThue); // tinh toan ngay tra va ngay thue cach nhau bao nhieeu ngay
			int days = (int)diffResult.TotalDays +1;
			string ghiChu = "Ngày mượn: " + DateTime.Now.ToString("dd/MM/yyy") + " - Ngày trả: " + ngayTra.ToString("dd/MM/yyyy") + ". Vui lòng quay lại trả sau " + days + " ngày.";
			return ghiChu;
		}
		private void btn_xacNhan_Click(object sender, EventArgs e)
		{

			if (!toggle_DocGiaCu.Checked) // truong hop nguoi thue moi
			{
				DateTime ngayThue = DateTime.Now;
				DateTime ngayTra = dateTimePicker.Value;
				if (check_input())
				{
					MessageBox.Show("Không được để trống các ô", "Thông báo", MessageBoxButtons.OK);
					return;
				}
				if (DateTime.Compare(ngayTra, ngayThue) == 0 || DateTime.Compare(ngayTra, ngayThue) < 0)
				{
					MessageBox.Show("Ngày trả không hợp lệ, vui lòng chọn lại");
					return;
				}
				//neu chay tren may khac vui long thay doi path
				string hoTen = textBox_hoTen.Text;
				string soDienThoai = textBox_soDienThoai.Text;
				string diaChi = textBox_diaChi.Text;
				// them duoc nhung tren application nhung tren database thuc su chua co du lieu
				db.NguoiThues.Add(new NguoiThue() { TenNguoiThue = hoTen, DiaChi = diaChi, SoDienThoai = soDienThoai });
				db.SaveChanges();
				//vi the thuc hien truy van thu cong

				//entities van phai savechange de cho chuong trinh dien ra dong bo
				int maNguoiThue = db.NguoiThues.ToList().Last().MaNguoiThue;
				db.ThueSaches.Add(new ThueSach() { MaNguoiThue = maNguoiThue, SoSachDaMuon = 1 });
				db.SaveChanges();
				int maThueSach = db.ThueSaches.ToList().Last().MaThueSach;// lay ma sach cua thang vua moi them vao
				string NguoiChoThue = user;
				string ghiChu = GhiChu(ngayTra);
				db.KhoSaches.Where(row => row.MaSach == maSach_Current).FirstOrDefault().SoLuong --; // khi muon thi kho sach se giam di 1
				db.ChiTietThueSaches.Add(new ChiTietThueSach() { MaSach = maSach_Current, MaThueSach = maThueSach, NgayThue = DateTime.Now, NgayTra = ngayTra, GhiChu = ghiChu, NguoiChoThue = NguoiChoThue });
				db.SaveChanges();
			}
			else // nguoi cu
			{
				DateTime ngayThue = DateTime.Now;
				DateTime ngayTra = dateTimePicker.Value;
				if (cbb_DocGiaCu.SelectedItem == null)
				{
					MessageBox.Show("Không được để trống các ô", "Thông báo", MessageBoxButtons.OK);
					return;
				}
				if (DateTime.Compare(ngayTra, ngayThue) == 0 || DateTime.Compare(ngayTra, ngayThue) < 0)
				{
					MessageBox.Show("Ngày trả không hợp lệ, vui lòng chọn lại");
					return;
				}
				int MaNguoiThueCu = (int)cbb_DocGiaCu.SelectedValue;
				// tim lai thong tin thue sach cua thang cu

				ThueSach thueSach = db.ThueSaches.Where(x => x.MaNguoiThue == MaNguoiThueCu).FirstOrDefault();
				if (thueSach.SoSachDaMuon >= 3)
				{
					MessageBox.Show("Bạn đã mượn 3 cuốn rồi, vui lòng trả sách trước đây để có thể mượn tiếp", "Thông báo");
					return;
				}
				//update so sach da muon
				thueSach.SoSachDaMuon++;
				db.SaveChanges();

				//Lay ma thue sach cua thang này
				int maThueSach = thueSach.MaThueSach;
				// tinh toan lay thong tin can thiet
				string ghiChu = GhiChu(ngayTra);
				string NguoiChoThue = user;
				// thuc hien them cuon sach đang chọn để mượn vào chi tiết với thông tin của độc giả cũ
				db.ChiTietThueSaches.Add(new ChiTietThueSach { MaSach = maSach_Current, MaThueSach = maThueSach, NgayThue = DateTime.Now, NgayTra = ngayTra, GhiChu = ghiChu, NguoiChoThue = NguoiChoThue });
				db.KhoSaches.Where(row => row.MaSach == maSach_Current).FirstOrDefault().SoLuong--; // khi muon thi kho sach se giam di 1
				db.SaveChanges();
			}
			this.Close();
		}

		private void textBox_soDienThoai_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
				e.Handled = false;
			else
				e.Handled = true;
		}
		void DoiTrangThaiTextBox()
		{
			foreach (var item in panel_main.Controls)
			{
				if (item is TextBox)
				{
					TextBox temp = item as TextBox;
					temp.ReadOnly = !temp.ReadOnly;
				}
			}
			cbb_DocGiaCu.Visible = !cbb_DocGiaCu.Visible;
		}
		private void toggle_DocGiaCu_CheckedChanged(object sender, EventArgs e)
		{
			if (toggle_DocGiaCu.Checked) // độc giả cũ thuê
			{
				DoiTrangThaiTextBox();
				load_cbb_DocGiaCu();
			}
			else
			{
				DoiTrangThaiTextBox();
				clear_TextBox();
			}
		}
	}
}
