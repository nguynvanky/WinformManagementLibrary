
namespace QuanLyThuVien.Areas.FormsAdmin
{
	partial class Form_TacGia_Sua
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
			this.btn_LuuLai = new Guna.UI2.WinForms.Guna2Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
			this.textBox_NamSinh = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_TenTacGia = new System.Windows.Forms.TextBox();
			this.label_tenSach = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_LuuLai
			// 
			this.btn_LuuLai.AutoRoundedCorners = true;
			this.btn_LuuLai.BorderRadius = 21;
			this.btn_LuuLai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_LuuLai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_LuuLai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_LuuLai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_LuuLai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(87)))));
			this.btn_LuuLai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_LuuLai.ForeColor = System.Drawing.Color.White;
			this.btn_LuuLai.Location = new System.Drawing.Point(249, 185);
			this.btn_LuuLai.Name = "btn_LuuLai";
			this.btn_LuuLai.Size = new System.Drawing.Size(180, 45);
			this.btn_LuuLai.TabIndex = 11;
			this.btn_LuuLai.Text = "Lưu lại";
			this.btn_LuuLai.Click += new System.EventHandler(this.btn_LuuLai_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
			this.panel2.Controls.Add(this.iconPictureBox1);
			this.panel2.Controls.Add(this.btn_LuuLai);
			this.panel2.Controls.Add(this.textBox_NamSinh);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.textBox_TenTacGia);
			this.panel2.Controls.Add(this.label_tenSach);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(680, 260);
			this.panel2.TabIndex = 9;
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
			this.iconPictureBox1.Location = new System.Drawing.Point(643, 12);
			this.iconPictureBox1.Name = "iconPictureBox1";
			this.iconPictureBox1.Size = new System.Drawing.Size(25, 25);
			this.iconPictureBox1.TabIndex = 10;
			this.iconPictureBox1.TabStop = false;
			this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
			// 
			// textBox_NamSinh
			// 
			this.textBox_NamSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_NamSinh.Location = new System.Drawing.Point(165, 130);
			this.textBox_NamSinh.Name = "textBox_NamSinh";
			this.textBox_NamSinh.Size = new System.Drawing.Size(446, 26);
			this.textBox_NamSinh.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.label2.Location = new System.Drawing.Point(27, 135);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Năm Sinh";
			// 
			// textBox_TenTacGia
			// 
			this.textBox_TenTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_TenTacGia.Location = new System.Drawing.Point(165, 60);
			this.textBox_TenTacGia.Name = "textBox_TenTacGia";
			this.textBox_TenTacGia.Size = new System.Drawing.Size(446, 26);
			this.textBox_TenTacGia.TabIndex = 1;
			// 
			// label_tenSach
			// 
			this.label_tenSach.AutoSize = true;
			this.label_tenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_tenSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.label_tenSach.Location = new System.Drawing.Point(27, 63);
			this.label_tenSach.Name = "label_tenSach";
			this.label_tenSach.Size = new System.Drawing.Size(98, 20);
			this.label_tenSach.TabIndex = 0;
			this.label_tenSach.Text = "Tên tác giả";
			// 
			// Form_TacGia_Sua
			// 
			this.AcceptButton = this.btn_LuuLai;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(680, 260);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form_TacGia_Sua";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form_TacGia_Sua";
			this.Load += new System.EventHandler(this.Form_TacGia_Sua_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Button btn_LuuLai;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBox_NamSinh;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_TenTacGia;
		private System.Windows.Forms.Label label_tenSach;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
	}
}