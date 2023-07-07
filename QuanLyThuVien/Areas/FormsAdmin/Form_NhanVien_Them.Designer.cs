
namespace QuanLyThuVien.Areas.FormsAdmin
{
	partial class Form_NhanVien_Them
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
			this.textBox_MatKhau = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
			this.btn_Them = new Guna.UI2.WinForms.Guna2Button();
			this.textBox_TenTaiKhoan = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_HoTen = new System.Windows.Forms.TextBox();
			this.label_tenSach = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
			this.panel2.Controls.Add(this.textBox_MatKhau);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.iconPictureBox1);
			this.panel2.Controls.Add(this.btn_Them);
			this.panel2.Controls.Add(this.textBox_TenTaiKhoan);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.textBox_HoTen);
			this.panel2.Controls.Add(this.label_tenSach);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(701, 300);
			this.panel2.TabIndex = 9;
			// 
			// textBox_MatKhau
			// 
			this.textBox_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_MatKhau.Location = new System.Drawing.Point(174, 180);
			this.textBox_MatKhau.Name = "textBox_MatKhau";
			this.textBox_MatKhau.Size = new System.Drawing.Size(446, 26);
			this.textBox_MatKhau.TabIndex = 14;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.label1.Location = new System.Drawing.Point(36, 183);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 20);
			this.label1.TabIndex = 13;
			this.label1.Text = "Mật khẩu";
			// 
			// iconPictureBox1
			// 
			this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
			this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
			this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconPictureBox1.IconSize = 25;
			this.iconPictureBox1.Location = new System.Drawing.Point(664, 12);
			this.iconPictureBox1.Name = "iconPictureBox1";
			this.iconPictureBox1.Size = new System.Drawing.Size(25, 25);
			this.iconPictureBox1.TabIndex = 12;
			this.iconPictureBox1.TabStop = false;
			this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
			// 
			// btn_Them
			// 
			this.btn_Them.AutoRoundedCorners = true;
			this.btn_Them.BorderRadius = 21;
			this.btn_Them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Them.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(87)))));
			this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Them.ForeColor = System.Drawing.Color.White;
			this.btn_Them.Location = new System.Drawing.Point(290, 243);
			this.btn_Them.Name = "btn_Them";
			this.btn_Them.Size = new System.Drawing.Size(180, 45);
			this.btn_Them.TabIndex = 11;
			this.btn_Them.Text = "Thêm";
			this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
			// 
			// textBox_TenTaiKhoan
			// 
			this.textBox_TenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_TenTaiKhoan.Location = new System.Drawing.Point(174, 120);
			this.textBox_TenTaiKhoan.Name = "textBox_TenTaiKhoan";
			this.textBox_TenTaiKhoan.Size = new System.Drawing.Size(446, 26);
			this.textBox_TenTaiKhoan.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.label2.Location = new System.Drawing.Point(36, 126);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tên tài khoản";
			// 
			// textBox_HoTen
			// 
			this.textBox_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_HoTen.Location = new System.Drawing.Point(174, 63);
			this.textBox_HoTen.Name = "textBox_HoTen";
			this.textBox_HoTen.Size = new System.Drawing.Size(446, 26);
			this.textBox_HoTen.TabIndex = 1;
			// 
			// label_tenSach
			// 
			this.label_tenSach.AutoSize = true;
			this.label_tenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_tenSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.label_tenSach.Location = new System.Drawing.Point(36, 66);
			this.label_tenSach.Name = "label_tenSach";
			this.label_tenSach.Size = new System.Drawing.Size(63, 20);
			this.label_tenSach.TabIndex = 0;
			this.label_tenSach.Text = "Họ tên";
			// 
			// Form_NhanVien_Them
			// 
			this.AcceptButton = this.btn_Them;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(701, 300);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form_NhanVien_Them";
			this.Text = "Form_NhanVien_Them";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBox_MatKhau;
		private System.Windows.Forms.Label label1;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
		private Guna.UI2.WinForms.Guna2Button btn_Them;
		private System.Windows.Forms.TextBox textBox_TenTaiKhoan;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_HoTen;
		private System.Windows.Forms.Label label_tenSach;
	}
}