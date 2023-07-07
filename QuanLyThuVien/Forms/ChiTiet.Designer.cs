
namespace QuanLyThuVien.Forms
{
	partial class ChiTiet
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox_sach = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.iconPictureBox_Exit = new FontAwesome.Sharp.IconPictureBox();
			this.textBox_tacGia = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox_theLoai = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox_nhaXuatBan = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox_namXuatBan = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_tenSach = new System.Windows.Forms.TextBox();
			this.label_tenSach = new System.Windows.Forms.Label();
			this.textBox_SoLuong = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_sach)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Exit)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(87)))));
			this.panel1.Controls.Add(this.pictureBox_sach);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(300, 450);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// pictureBox_sach
			// 
			this.pictureBox_sach.Location = new System.Drawing.Point(25, 28);
			this.pictureBox_sach.Name = "pictureBox_sach";
			this.pictureBox_sach.Size = new System.Drawing.Size(251, 391);
			this.pictureBox_sach.TabIndex = 0;
			this.pictureBox_sach.TabStop = false;
			this.pictureBox_sach.Click += new System.EventHandler(this.pictureBox_sach_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
			this.panel2.Controls.Add(this.textBox_SoLuong);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.iconPictureBox_Exit);
			this.panel2.Controls.Add(this.textBox_tacGia);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.textBox_theLoai);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.textBox_nhaXuatBan);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.textBox_namXuatBan);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.textBox_tenSach);
			this.panel2.Controls.Add(this.label_tenSach);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(300, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(500, 450);
			this.panel2.TabIndex = 1;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
			// textBox_tacGia
			// 
			this.textBox_tacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_tacGia.Location = new System.Drawing.Point(174, 128);
			this.textBox_tacGia.Name = "textBox_tacGia";
			this.textBox_tacGia.ReadOnly = true;
			this.textBox_tacGia.Size = new System.Drawing.Size(314, 26);
			this.textBox_tacGia.TabIndex = 9;
			this.textBox_tacGia.TextChanged += new System.EventHandler(this.textBox_tacGia_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.label5.Location = new System.Drawing.Point(34, 131);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "Tác giả";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// textBox_theLoai
			// 
			this.textBox_theLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_theLoai.Location = new System.Drawing.Point(174, 184);
			this.textBox_theLoai.Name = "textBox_theLoai";
			this.textBox_theLoai.ReadOnly = true;
			this.textBox_theLoai.Size = new System.Drawing.Size(314, 26);
			this.textBox_theLoai.TabIndex = 7;
			this.textBox_theLoai.TextChanged += new System.EventHandler(this.textBox_theLoai_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.label4.Location = new System.Drawing.Point(34, 187);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Thể loại";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// textBox_nhaXuatBan
			// 
			this.textBox_nhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_nhaXuatBan.Location = new System.Drawing.Point(172, 287);
			this.textBox_nhaXuatBan.Name = "textBox_nhaXuatBan";
			this.textBox_nhaXuatBan.ReadOnly = true;
			this.textBox_nhaXuatBan.Size = new System.Drawing.Size(316, 26);
			this.textBox_nhaXuatBan.TabIndex = 5;
			this.textBox_nhaXuatBan.TextChanged += new System.EventHandler(this.textBox_nhaXuatBan_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.label3.Location = new System.Drawing.Point(34, 290);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(115, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Nhà xuất bản";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// textBox_namXuatBan
			// 
			this.textBox_namXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_namXuatBan.Location = new System.Drawing.Point(172, 338);
			this.textBox_namXuatBan.Name = "textBox_namXuatBan";
			this.textBox_namXuatBan.ReadOnly = true;
			this.textBox_namXuatBan.Size = new System.Drawing.Size(316, 26);
			this.textBox_namXuatBan.TabIndex = 3;
			this.textBox_namXuatBan.TextChanged += new System.EventHandler(this.textBox_namXuatBan_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.label2.Location = new System.Drawing.Point(34, 341);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Năm xuất bản";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// textBox_tenSach
			// 
			this.textBox_tenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_tenSach.Location = new System.Drawing.Point(174, 73);
			this.textBox_tenSach.Name = "textBox_tenSach";
			this.textBox_tenSach.ReadOnly = true;
			this.textBox_tenSach.Size = new System.Drawing.Size(314, 26);
			this.textBox_tenSach.TabIndex = 1;
			this.textBox_tenSach.TextChanged += new System.EventHandler(this.textBox_tenSach_TextChanged);
			// 
			// label_tenSach
			// 
			this.label_tenSach.AutoSize = true;
			this.label_tenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_tenSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.label_tenSach.Location = new System.Drawing.Point(34, 76);
			this.label_tenSach.Name = "label_tenSach";
			this.label_tenSach.Size = new System.Drawing.Size(82, 20);
			this.label_tenSach.TabIndex = 0;
			this.label_tenSach.Text = "Tên sách";
			this.label_tenSach.Click += new System.EventHandler(this.label_tenSach_Click);
			// 
			// textBox_SoLuong
			// 
			this.textBox_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_SoLuong.Location = new System.Drawing.Point(174, 236);
			this.textBox_SoLuong.Name = "textBox_SoLuong";
			this.textBox_SoLuong.ReadOnly = true;
			this.textBox_SoLuong.Size = new System.Drawing.Size(314, 26);
			this.textBox_SoLuong.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.label1.Location = new System.Drawing.Point(34, 239);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 20);
			this.label1.TabIndex = 10;
			this.label1.Text = "Số lượng còn";
			// 
			// ChiTiet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "ChiTiet";
			this.Text = "ChiTiet";
			this.Load += new System.EventHandler(this.ChiTiet_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_sach)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Exit)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox_sach;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBox_tacGia;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox_theLoai;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox_nhaXuatBan;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox_namXuatBan;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_tenSach;
		private System.Windows.Forms.Label label_tenSach;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox_Exit;
		private System.Windows.Forms.TextBox textBox_SoLuong;
		private System.Windows.Forms.Label label1;
	}
}