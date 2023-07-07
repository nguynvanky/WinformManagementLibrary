
namespace QuanLyThuVien.Forms
{
	partial class FormChiTietThueSach
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
			this.iconPictureBox_Exit = new FontAwesome.Sharp.IconPictureBox();
			this.textBox_TenNguoiThue = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox_SoDienThoai = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox_DiaChi = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox_GhiChu = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_TenSach = new System.Windows.Forms.TextBox();
			this.label_tenSach = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_XemChiTiet = new Guna.UI2.WinForms.Guna2Button();
			this.pictureBox_sach = new System.Windows.Forms.PictureBox();
			this.textBox_NguoiChoMuon = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Exit)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_sach)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
			this.panel2.Controls.Add(this.textBox_NguoiChoMuon);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.iconPictureBox_Exit);
			this.panel2.Controls.Add(this.textBox_TenNguoiThue);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.textBox_SoDienThoai);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.textBox_DiaChi);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.textBox_GhiChu);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.textBox_TenSach);
			this.panel2.Controls.Add(this.label_tenSach);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(300, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(500, 450);
			this.panel2.TabIndex = 3;
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
			this.iconPictureBox_Exit.Click += new System.EventHandler(this.iconPictureBox_Exit_Click);
			// 
			// textBox_TenNguoiThue
			// 
			this.textBox_TenNguoiThue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_TenNguoiThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_TenNguoiThue.Location = new System.Drawing.Point(186, 109);
			this.textBox_TenNguoiThue.Name = "textBox_TenNguoiThue";
			this.textBox_TenNguoiThue.ReadOnly = true;
			this.textBox_TenNguoiThue.Size = new System.Drawing.Size(297, 26);
			this.textBox_TenNguoiThue.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.label5.Location = new System.Drawing.Point(36, 115);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(137, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "Tên người mượn";
			// 
			// textBox_SoDienThoai
			// 
			this.textBox_SoDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_SoDienThoai.Location = new System.Drawing.Point(186, 165);
			this.textBox_SoDienThoai.Name = "textBox_SoDienThoai";
			this.textBox_SoDienThoai.ReadOnly = true;
			this.textBox_SoDienThoai.Size = new System.Drawing.Size(297, 26);
			this.textBox_SoDienThoai.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.label4.Location = new System.Drawing.Point(36, 171);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Số điện thoại";
			// 
			// textBox_DiaChi
			// 
			this.textBox_DiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_DiaChi.Location = new System.Drawing.Point(184, 209);
			this.textBox_DiaChi.Name = "textBox_DiaChi";
			this.textBox_DiaChi.ReadOnly = true;
			this.textBox_DiaChi.Size = new System.Drawing.Size(297, 26);
			this.textBox_DiaChi.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.label3.Location = new System.Drawing.Point(36, 215);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Địa chỉ";
			// 
			// textBox_GhiChu
			// 
			this.textBox_GhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_GhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_GhiChu.Location = new System.Drawing.Point(184, 317);
			this.textBox_GhiChu.Multiline = true;
			this.textBox_GhiChu.Name = "textBox_GhiChu";
			this.textBox_GhiChu.ReadOnly = true;
			this.textBox_GhiChu.Size = new System.Drawing.Size(297, 92);
			this.textBox_GhiChu.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.label2.Location = new System.Drawing.Point(36, 317);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Ghi chú";
			// 
			// textBox_TenSach
			// 
			this.textBox_TenSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_TenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_TenSach.Location = new System.Drawing.Point(186, 54);
			this.textBox_TenSach.Name = "textBox_TenSach";
			this.textBox_TenSach.ReadOnly = true;
			this.textBox_TenSach.Size = new System.Drawing.Size(297, 26);
			this.textBox_TenSach.TabIndex = 1;
			// 
			// label_tenSach
			// 
			this.label_tenSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label_tenSach.AutoSize = true;
			this.label_tenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_tenSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.label_tenSach.Location = new System.Drawing.Point(36, 60);
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
			this.panel1.TabIndex = 2;
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
			this.btn_XemChiTiet.Location = new System.Drawing.Point(58, 377);
			this.btn_XemChiTiet.Name = "btn_XemChiTiet";
			this.btn_XemChiTiet.Size = new System.Drawing.Size(180, 45);
			this.btn_XemChiTiet.TabIndex = 1;
			this.btn_XemChiTiet.Text = "Xem chi tiết";
			this.btn_XemChiTiet.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
			// 
			// pictureBox_sach
			// 
			this.pictureBox_sach.Location = new System.Drawing.Point(26, 12);
			this.pictureBox_sach.Name = "pictureBox_sach";
			this.pictureBox_sach.Size = new System.Drawing.Size(251, 353);
			this.pictureBox_sach.TabIndex = 0;
			this.pictureBox_sach.TabStop = false;
			// 
			// textBox_NguoiChoMuon
			// 
			this.textBox_NguoiChoMuon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_NguoiChoMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_NguoiChoMuon.Location = new System.Drawing.Point(184, 260);
			this.textBox_NguoiChoMuon.Name = "textBox_NguoiChoMuon";
			this.textBox_NguoiChoMuon.ReadOnly = true;
			this.textBox_NguoiChoMuon.Size = new System.Drawing.Size(297, 26);
			this.textBox_NguoiChoMuon.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.label1.Location = new System.Drawing.Point(36, 266);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 20);
			this.label1.TabIndex = 10;
			this.label1.Text = "Người cho mượn";
			// 
			// FormChiTietThueSach
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormChiTietThueSach";
			this.Text = "FormChiTietThueSach";
			this.Load += new System.EventHandler(this.FormChiTietThueSach_Load);
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
		private System.Windows.Forms.TextBox textBox_GhiChu;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_TenSach;
		private System.Windows.Forms.Label label_tenSach;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox_sach;
		private Guna.UI2.WinForms.Guna2Button btn_XemChiTiet;
		private System.Windows.Forms.TextBox textBox_NguoiChoMuon;
		private System.Windows.Forms.Label label1;
	}
}