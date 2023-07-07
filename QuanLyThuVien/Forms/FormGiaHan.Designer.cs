
namespace QuanLyThuVien.Forms
{
	partial class FormGiaHan
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel2 = new System.Windows.Forms.Panel();
			this.dateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.iconPictureBox_Exit = new FontAwesome.Sharp.IconPictureBox();
			this.textBox_TenNguoiThue = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox_SoDienThoai = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox_DiaChi = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox_TenSach = new System.Windows.Forms.TextBox();
			this.label_tenSach = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_XemChiTiet = new Guna.UI2.WinForms.Guna2Button();
			this.pictureBox_sach = new System.Windows.Forms.PictureBox();
			this.btn_XacNhan = new Guna.UI2.WinForms.Guna2Button();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Exit)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_sach)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
			this.panel2.Controls.Add(this.dateTimePicker);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.iconPictureBox_Exit);
			this.panel2.Controls.Add(this.textBox_TenNguoiThue);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.textBox_SoDienThoai);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.textBox_DiaChi);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.textBox_TenSach);
			this.panel2.Controls.Add(this.label_tenSach);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(300, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(500, 450);
			this.panel2.TabIndex = 5;
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Animated = true;
			this.dateTimePicker.AutoRoundedCorners = true;
			this.dateTimePicker.BorderRadius = 17;
			this.dateTimePicker.Checked = true;
			this.dateTimePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(90)))));
			this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker.ForeColor = System.Drawing.Color.White;
			this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.dateTimePicker.Location = new System.Drawing.Point(171, 270);
			this.dateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(314, 36);
			this.dateTimePicker.TabIndex = 11;
			this.dateTimePicker.Value = new System.DateTime(2022, 12, 19, 23, 3, 55, 162);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.label1.Location = new System.Drawing.Point(33, 279);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 20);
			this.label1.TabIndex = 10;
			this.label1.Text = "Ngày trả sách";
			// 
			// iconPictureBox_Exit
			// 
			this.iconPictureBox_Exit.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.iconPictureBox_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
			this.iconPictureBox_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.iconPictureBox_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.iconPictureBox_Exit.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
			this.iconPictureBox_Exit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.iconPictureBox_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconPictureBox_Exit.IconSize = 25;
			this.iconPictureBox_Exit.Location = new System.Drawing.Point(463, 12);
			this.iconPictureBox_Exit.Name = "iconPictureBox_Exit";
			this.iconPictureBox_Exit.Size = new System.Drawing.Size(25, 25);
			this.iconPictureBox_Exit.TabIndex = 2;
			this.iconPictureBox_Exit.TabStop = false;
			// 
			// textBox_TenNguoiThue
			// 
			this.textBox_TenNguoiThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_TenNguoiThue.Location = new System.Drawing.Point(173, 108);
			this.textBox_TenNguoiThue.Name = "textBox_TenNguoiThue";
			this.textBox_TenNguoiThue.ReadOnly = true;
			this.textBox_TenNguoiThue.Size = new System.Drawing.Size(314, 26);
			this.textBox_TenNguoiThue.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.label5.Location = new System.Drawing.Point(35, 111);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(135, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "Tên Người Thuê";
			// 
			// textBox_SoDienThoai
			// 
			this.textBox_SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_SoDienThoai.Location = new System.Drawing.Point(173, 164);
			this.textBox_SoDienThoai.Name = "textBox_SoDienThoai";
			this.textBox_SoDienThoai.ReadOnly = true;
			this.textBox_SoDienThoai.Size = new System.Drawing.Size(314, 26);
			this.textBox_SoDienThoai.TabIndex = 7;
			this.textBox_SoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_SoDienThoai_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.label4.Location = new System.Drawing.Point(35, 167);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Số điện thoại";
			// 
			// textBox_DiaChi
			// 
			this.textBox_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_DiaChi.Location = new System.Drawing.Point(171, 218);
			this.textBox_DiaChi.Name = "textBox_DiaChi";
			this.textBox_DiaChi.ReadOnly = true;
			this.textBox_DiaChi.Size = new System.Drawing.Size(314, 26);
			this.textBox_DiaChi.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.label3.Location = new System.Drawing.Point(33, 221);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Địa chỉ";
			// 
			// textBox_TenSach
			// 
			this.textBox_TenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_TenSach.Location = new System.Drawing.Point(173, 53);
			this.textBox_TenSach.Name = "textBox_TenSach";
			this.textBox_TenSach.ReadOnly = true;
			this.textBox_TenSach.Size = new System.Drawing.Size(314, 26);
			this.textBox_TenSach.TabIndex = 1;
			// 
			// label_tenSach
			// 
			this.label_tenSach.AutoSize = true;
			this.label_tenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_tenSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.label_tenSach.Location = new System.Drawing.Point(35, 56);
			this.label_tenSach.Name = "label_tenSach";
			this.label_tenSach.Size = new System.Drawing.Size(82, 20);
			this.label_tenSach.TabIndex = 0;
			this.label_tenSach.Text = "Tên sách";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(87)))));
			this.panel1.Controls.Add(this.btn_XemChiTiet);
			this.panel1.Controls.Add(this.pictureBox_sach);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(300, 450);
			this.panel1.TabIndex = 4;
			// 
			// btn_XemChiTiet
			// 
			this.btn_XemChiTiet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_XemChiTiet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_XemChiTiet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_XemChiTiet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_XemChiTiet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
			this.btn_XemChiTiet.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btn_XemChiTiet.ForeColor = System.Drawing.Color.White;
			this.btn_XemChiTiet.Location = new System.Drawing.Point(57, 393);
			this.btn_XemChiTiet.Name = "btn_XemChiTiet";
			this.btn_XemChiTiet.Size = new System.Drawing.Size(180, 45);
			this.btn_XemChiTiet.TabIndex = 1;
			this.btn_XemChiTiet.Text = "Xem chi tiết";
			this.btn_XemChiTiet.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
			// 
			// pictureBox_sach
			// 
			this.pictureBox_sach.Location = new System.Drawing.Point(25, 28);
			this.pictureBox_sach.Name = "pictureBox_sach";
			this.pictureBox_sach.Size = new System.Drawing.Size(251, 353);
			this.pictureBox_sach.TabIndex = 0;
			this.pictureBox_sach.TabStop = false;
			// 
			// btn_XacNhan
			// 
			this.btn_XacNhan.AutoRoundedCorners = true;
			this.btn_XacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
			this.btn_XacNhan.BorderRadius = 21;
			this.btn_XacNhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_XacNhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_XacNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_XacNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_XacNhan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(87)))));
			this.btn_XacNhan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_XacNhan.ForeColor = System.Drawing.Color.White;
			this.btn_XacNhan.Location = new System.Drawing.Point(501, 354);
			this.btn_XacNhan.Name = "btn_XacNhan";
			this.btn_XacNhan.Size = new System.Drawing.Size(180, 45);
			this.btn_XacNhan.TabIndex = 12;
			this.btn_XacNhan.Text = "Xác nhận";
			// 
			// FormGiaHan
			// 
			this.AcceptButton = this.btn_XacNhan;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_XacNhan);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FormGiaHan";
			this.Text = "FormGiaHan";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Exit)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_sach)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox_Exit;
		private System.Windows.Forms.TextBox textBox_TenNguoiThue;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox_SoDienThoai;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox_DiaChi;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox_TenSach;
		private System.Windows.Forms.Label label_tenSach;
		private System.Windows.Forms.Panel panel1;
		private Guna.UI2.WinForms.Guna2Button btn_XemChiTiet;
		private System.Windows.Forms.PictureBox pictureBox_sach;
		private Guna.UI2.WinForms.Guna2Button btn_XacNhan;
		private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker;
		private System.Windows.Forms.Label label1;
	}
}