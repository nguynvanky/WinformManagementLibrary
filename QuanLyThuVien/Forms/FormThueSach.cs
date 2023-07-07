using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace QuanLyThuVien.Forms
{
	public partial class FormThueSach : Form
	{
		Library_Entities db = new Library_Entities();
		public FormThueSach()
		{
			InitializeComponent();
		}

		
		void loadData()
		{
			panel_Main.Controls.Clear();
			List<NguoiThue> nguoiThues = db.NguoiThues.ToList();
			foreach (NguoiThue i in nguoiThues)
			{
				panel_Main.Controls.Add(Item_NguoiThue(i));
			}
		}
		Panel Item_NguoiThue(NguoiThue x)
		{
			// 
			// panel item
			// 
			Panel item = new Panel();
			item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			item.Dock = System.Windows.Forms.DockStyle.Top;
			item.Location = new System.Drawing.Point(0, 34);
			item.Size = new System.Drawing.Size(959, 50);
			// 
			// btn_Xem
			// 
			IconButton btn_Xem = new IconButton();
			btn_Xem.Dock = System.Windows.Forms.DockStyle.Fill;
			btn_Xem.FlatAppearance.BorderSize = 0;
			btn_Xem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btn_Xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			btn_Xem.IconChar = FontAwesome.Sharp.IconChar.Eye;
			btn_Xem.IconColor = System.Drawing.Color.Black;
			btn_Xem.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btn_Xem.IconSize = 24;
			btn_Xem.Location = new System.Drawing.Point(0, 0);
			btn_Xem.Name = "btn_Xem";
			btn_Xem.Size = new System.Drawing.Size(75, 48);
			btn_Xem.TabIndex = 0;
			btn_Xem.Text = "Xem";
			btn_Xem.TextImageRelation = TextImageRelation.ImageBeforeText;
			btn_Xem.UseVisualStyleBackColor = true;
			btn_Xem.Tag = x.MaNguoiThue;
			btn_Xem.Click += Btn_Xem_Click;
			// 
			// panel_Xem
			// 
			Panel panel_Xem = new Panel();
			panel_Xem.Controls.Add(btn_Xem);
			panel_Xem.Dock = System.Windows.Forms.DockStyle.Right;
			panel_Xem.Location = new System.Drawing.Point(732, 0);
			panel_Xem.Name = "panel_Xem";
			panel_Xem.Size = new System.Drawing.Size(75, 48);
			// 
			// lbl_Ten
			// 
			Label lbl_Ten = new Label();
			lbl_Ten.AutoSize = true;
			lbl_Ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			lbl_Ten.Location = new System.Drawing.Point(42, 14);
			lbl_Ten.Name = "lbl_Ten";
			lbl_Ten.Size = new System.Drawing.Size(33, 18);
			lbl_Ten.TabIndex = 4;
			lbl_Ten.Text = x.TenNguoiThue;
			// 
			// lbl_DiaChi
			// 
			Label lbl_DiaChi = new Label();
			lbl_DiaChi.AutoSize = true;
			lbl_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			lbl_DiaChi.Location = new System.Drawing.Point(208, 14);
			lbl_DiaChi.Name = "lbl_DiaChi";
			lbl_DiaChi.Size = new System.Drawing.Size(53, 18);
			lbl_DiaChi.TabIndex = 5;
			lbl_DiaChi.Text = x.DiaChi;
			// 
			// lbl_SDT
			// 
			Label lbl_SDT = new Label();

			lbl_SDT.AutoSize = true;
			lbl_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			lbl_SDT.Location = new System.Drawing.Point(526, 14);
			lbl_SDT.Name = "lbl_SDT";
			lbl_SDT.Size = new System.Drawing.Size(94, 18);
			lbl_SDT.TabIndex = 6;
			lbl_SDT.Text = x.SoDienThoai;
			item.Controls.Add(lbl_SDT);
			item.Controls.Add(lbl_DiaChi);
			item.Controls.Add(lbl_Ten);
			item.Controls.Add(panel_Xem);
			return item;
		}

		

		private void Btn_Xem_Click(object sender, EventArgs e)
		{
			IconButton iconButton = sender as IconButton;
			int maNguoiThue = (int)iconButton.Tag;
			FormDanhSachChiTiet f = new FormDanhSachChiTiet();
			f.MaNguoiThue = maNguoiThue;
			f.StartPosition = FormStartPosition.CenterScreen;
			f.ShowDialog();
		}

	

		private void FormThueSach_Load(object sender, EventArgs e)
		{
			loadData();
		}

		
	}
}
