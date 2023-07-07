
namespace QuanLyThuVien.Forms
{
	partial class FormChoThue
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
			this.panel_main = new System.Windows.Forms.Panel();
			this.cbb_DocGiaCu = new Guna.UI2.WinForms.Guna2ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.toggle_DocGiaCu = new Guna.UI2.WinForms.Guna2ToggleSwitch();
			this.dateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.btn_xacNhan = new System.Windows.Forms.Button();
			this.iconPictureBox_Exit = new FontAwesome.Sharp.IconPictureBox();
			this.textBox_soDienThoai = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox_diaChi = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox_hoTen = new System.Windows.Forms.TextBox();
			this.label_hoTen = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox_sach = new System.Windows.Forms.PictureBox();
			this.label_SoLuong = new System.Windows.Forms.Label();
			this.panel_main.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Exit)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_sach)).BeginInit();
			this.SuspendLayout();
			// 
			// panel_main
			// 
			this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
			this.panel_main.Controls.Add(this.cbb_DocGiaCu);
			this.panel_main.Controls.Add(this.label1);
			this.panel_main.Controls.Add(this.toggle_DocGiaCu);
			this.panel_main.Controls.Add(this.dateTimePicker);
			this.panel_main.Controls.Add(this.btn_xacNhan);
			this.panel_main.Controls.Add(this.iconPictureBox_Exit);
			this.panel_main.Controls.Add(this.textBox_soDienThoai);
			this.panel_main.Controls.Add(this.label5);
			this.panel_main.Controls.Add(this.textBox_diaChi);
			this.panel_main.Controls.Add(this.label4);
			this.panel_main.Controls.Add(this.label3);
			this.panel_main.Controls.Add(this.textBox_hoTen);
			this.panel_main.Controls.Add(this.label_hoTen);
			this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_main.Location = new System.Drawing.Point(300, 0);
			this.panel_main.Name = "panel_main";
			this.panel_main.Size = new System.Drawing.Size(500, 450);
			this.panel_main.TabIndex = 3;
			// 
			// cbb_DocGiaCu
			// 
			this.cbb_DocGiaCu.BackColor = System.Drawing.Color.Transparent;
			this.cbb_DocGiaCu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbb_DocGiaCu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbb_DocGiaCu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbb_DocGiaCu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbb_DocGiaCu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbb_DocGiaCu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbb_DocGiaCu.ItemHeight = 30;
			this.cbb_DocGiaCu.Location = new System.Drawing.Point(173, 55);
			this.cbb_DocGiaCu.Name = "cbb_DocGiaCu";
			this.cbb_DocGiaCu.Size = new System.Drawing.Size(313, 36);
			this.cbb_DocGiaCu.TabIndex = 13;
			this.cbb_DocGiaCu.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.label1.Location = new System.Drawing.Point(34, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 20);
			this.label1.TabIndex = 12;
			this.label1.Text = "Độc giả cũ";
			// 
			// toggle_DocGiaCu
			// 
			this.toggle_DocGiaCu.CheckedState.BorderColor = System.Drawing.Color.White;
			this.toggle_DocGiaCu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(180)))), ((int)(((byte)(87)))));
			this.toggle_DocGiaCu.CheckedState.InnerBorderColor = System.Drawing.Color.White;
			this.toggle_DocGiaCu.CheckedState.InnerColor = System.Drawing.Color.White;
			this.toggle_DocGiaCu.Location = new System.Drawing.Point(132, 64);
			this.toggle_DocGiaCu.Name = "toggle_DocGiaCu";
			this.toggle_DocGiaCu.Size = new System.Drawing.Size(35, 20);
			this.toggle_DocGiaCu.TabIndex = 11;
			this.toggle_DocGiaCu.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(87)))));
			this.toggle_DocGiaCu.UncheckedState.FillColor = System.Drawing.Color.White;
			this.toggle_DocGiaCu.UncheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(87)))));
			this.toggle_DocGiaCu.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(87)))));
			this.toggle_DocGiaCu.CheckedChanged += new System.EventHandler(this.toggle_DocGiaCu_CheckedChanged);
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
			this.dateTimePicker.Location = new System.Drawing.Point(173, 312);
			this.dateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(314, 36);
			this.dateTimePicker.TabIndex = 9;
			this.dateTimePicker.Value = new System.DateTime(2022, 12, 19, 0, 0, 0, 0);
			// 
			// btn_xacNhan
			// 
			this.btn_xacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_xacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_xacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xacNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.btn_xacNhan.Location = new System.Drawing.Point(209, 369);
			this.btn_xacNhan.Name = "btn_xacNhan";
			this.btn_xacNhan.Size = new System.Drawing.Size(137, 50);
			this.btn_xacNhan.TabIndex = 5;
			this.btn_xacNhan.Text = "Xác nhận";
			this.btn_xacNhan.UseVisualStyleBackColor = true;
			this.btn_xacNhan.Click += new System.EventHandler(this.btn_xacNhan_Click);
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
			// textBox_soDienThoai
			// 
			this.textBox_soDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_soDienThoai.Location = new System.Drawing.Point(172, 177);
			this.textBox_soDienThoai.Name = "textBox_soDienThoai";
			this.textBox_soDienThoai.Size = new System.Drawing.Size(314, 26);
			this.textBox_soDienThoai.TabIndex = 2;
			this.textBox_soDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_soDienThoai_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.label5.Location = new System.Drawing.Point(34, 180);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(115, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "Số điện thoại";
			// 
			// textBox_diaChi
			// 
			this.textBox_diaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_diaChi.Location = new System.Drawing.Point(172, 236);
			this.textBox_diaChi.Name = "textBox_diaChi";
			this.textBox_diaChi.Size = new System.Drawing.Size(314, 26);
			this.textBox_diaChi.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.label4.Location = new System.Drawing.Point(34, 239);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Địa chỉ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.label3.Location = new System.Drawing.Point(35, 321);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Ngày trả sách";
			// 
			// textBox_hoTen
			// 
			this.textBox_hoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_hoTen.Location = new System.Drawing.Point(172, 121);
			this.textBox_hoTen.Name = "textBox_hoTen";
			this.textBox_hoTen.Size = new System.Drawing.Size(314, 26);
			this.textBox_hoTen.TabIndex = 1;
			// 
			// label_hoTen
			// 
			this.label_hoTen.AutoSize = true;
			this.label_hoTen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label_hoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_hoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.label_hoTen.Location = new System.Drawing.Point(34, 124);
			this.label_hoTen.Name = "label_hoTen";
			this.label_hoTen.Size = new System.Drawing.Size(63, 20);
			this.label_hoTen.TabIndex = 0;
			this.label_hoTen.Text = "Họ tên";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(87)))));
			this.panel1.Controls.Add(this.label_SoLuong);
			this.panel1.Controls.Add(this.pictureBox_sach);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(300, 450);
			this.panel1.TabIndex = 2;
			// 
			// pictureBox_sach
			// 
			this.pictureBox_sach.Location = new System.Drawing.Point(25, 28);
			this.pictureBox_sach.Name = "pictureBox_sach";
			this.pictureBox_sach.Size = new System.Drawing.Size(251, 360);
			this.pictureBox_sach.TabIndex = 0;
			this.pictureBox_sach.TabStop = false;
			// 
			// label_SoLuong
			// 
			this.label_SoLuong.AutoSize = true;
			this.label_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_SoLuong.ForeColor = System.Drawing.Color.DarkRed;
			this.label_SoLuong.Location = new System.Drawing.Point(95, 395);
			this.label_SoLuong.Name = "label_SoLuong";
			this.label_SoLuong.Size = new System.Drawing.Size(104, 24);
			this.label_SoLuong.TabIndex = 1;
			this.label_SoLuong.Text = "Trạng thái";
			// 
			// FormChoThue
			// 
			this.AcceptButton = this.btn_xacNhan;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel_main);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormChoThue";
			this.Text = "FormChoThue";
			this.Load += new System.EventHandler(this.FormChoThue_Load);
			this.panel_main.ResumeLayout(false);
			this.panel_main.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Exit)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_sach)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel_main;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox_Exit;
		private System.Windows.Forms.TextBox textBox_soDienThoai;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox_diaChi;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox_hoTen;
		private System.Windows.Forms.Label label_hoTen;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox_sach;
		private System.Windows.Forms.Button btn_xacNhan;
		private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker;
		private Guna.UI2.WinForms.Guna2ToggleSwitch toggle_DocGiaCu;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2ComboBox cbb_DocGiaCu;
		private System.Windows.Forms.Label label_SoLuong;
	}
}