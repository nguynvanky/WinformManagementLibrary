
namespace QuanLyThuVien.Forms
{
	partial class FormDangNhap
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
			this.panelControlBox = new System.Windows.Forms.Panel();
			this.iconPictureBox_Minimize = new FontAwesome.Sharp.IconPictureBox();
			this.iconPictureBox_Maximize = new FontAwesome.Sharp.IconPictureBox();
			this.iconPictureBox_Exit = new FontAwesome.Sharp.IconPictureBox();
			this.textBoxTaiKhoan = new System.Windows.Forms.TextBox();
			this.labelTaiKhoan = new System.Windows.Forms.Label();
			this.labelMatKhau = new System.Windows.Forms.Label();
			this.textBoxMatKhau = new System.Windows.Forms.TextBox();
			this.btn_DangNhap = new System.Windows.Forms.Button();
			this.linkLabel_QuenMatKhau = new System.Windows.Forms.LinkLabel();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelControlBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Minimize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Maximize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Exit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControlBox
			// 
			this.panelControlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
			this.panelControlBox.Controls.Add(this.iconPictureBox_Minimize);
			this.panelControlBox.Controls.Add(this.iconPictureBox_Maximize);
			this.panelControlBox.Controls.Add(this.iconPictureBox_Exit);
			this.panelControlBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControlBox.Location = new System.Drawing.Point(0, 0);
			this.panelControlBox.Name = "panelControlBox";
			this.panelControlBox.Size = new System.Drawing.Size(384, 40);
			this.panelControlBox.TabIndex = 1;
			this.panelControlBox.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControlBox_Paint);
			this.panelControlBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControlBox_MouseDown);
			// 
			// iconPictureBox_Minimize
			// 
			this.iconPictureBox_Minimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.iconPictureBox_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
			this.iconPictureBox_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.iconPictureBox_Minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.iconPictureBox_Minimize.IconChar = FontAwesome.Sharp.IconChar.CompressArrowsAlt;
			this.iconPictureBox_Minimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.iconPictureBox_Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconPictureBox_Minimize.IconSize = 25;
			this.iconPictureBox_Minimize.Location = new System.Drawing.Point(291, 8);
			this.iconPictureBox_Minimize.Name = "iconPictureBox_Minimize";
			this.iconPictureBox_Minimize.Size = new System.Drawing.Size(25, 25);
			this.iconPictureBox_Minimize.TabIndex = 2;
			this.iconPictureBox_Minimize.TabStop = false;
			this.iconPictureBox_Minimize.Click += new System.EventHandler(this.iconPictureBox_Minimize_Click);
			// 
			// iconPictureBox_Maximize
			// 
			this.iconPictureBox_Maximize.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.iconPictureBox_Maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
			this.iconPictureBox_Maximize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.iconPictureBox_Maximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.iconPictureBox_Maximize.IconChar = FontAwesome.Sharp.IconChar.ExpandArrowsAlt;
			this.iconPictureBox_Maximize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.iconPictureBox_Maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconPictureBox_Maximize.IconSize = 25;
			this.iconPictureBox_Maximize.Location = new System.Drawing.Point(322, 8);
			this.iconPictureBox_Maximize.Name = "iconPictureBox_Maximize";
			this.iconPictureBox_Maximize.Size = new System.Drawing.Size(25, 25);
			this.iconPictureBox_Maximize.TabIndex = 1;
			this.iconPictureBox_Maximize.TabStop = false;
			this.iconPictureBox_Maximize.Click += new System.EventHandler(this.iconPictureBox_Maximize_Click);
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
			this.iconPictureBox_Exit.Location = new System.Drawing.Point(353, 8);
			this.iconPictureBox_Exit.Name = "iconPictureBox_Exit";
			this.iconPictureBox_Exit.Size = new System.Drawing.Size(25, 25);
			this.iconPictureBox_Exit.TabIndex = 0;
			this.iconPictureBox_Exit.TabStop = false;
			this.iconPictureBox_Exit.Click += new System.EventHandler(this.iconPictureBox_Exit_Click);
			// 
			// textBoxTaiKhoan
			// 
			this.textBoxTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(87)))));
			this.textBoxTaiKhoan.Location = new System.Drawing.Point(96, 284);
			this.textBoxTaiKhoan.Name = "textBoxTaiKhoan";
			this.textBoxTaiKhoan.Size = new System.Drawing.Size(202, 26);
			this.textBoxTaiKhoan.TabIndex = 3;
			this.textBoxTaiKhoan.TextChanged += new System.EventHandler(this.textBoxTaiKhoan_TextChanged);
			this.textBoxTaiKhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTaiKhoan_KeyPress);
			// 
			// labelTaiKhoan
			// 
			this.labelTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTaiKhoan.AutoSize = true;
			this.labelTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(87)))));
			this.labelTaiKhoan.Location = new System.Drawing.Point(93, 259);
			this.labelTaiKhoan.Name = "labelTaiKhoan";
			this.labelTaiKhoan.Size = new System.Drawing.Size(78, 16);
			this.labelTaiKhoan.TabIndex = 4;
			this.labelTaiKhoan.Text = "Tài Khoản";
			// 
			// labelMatKhau
			// 
			this.labelMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelMatKhau.AutoSize = true;
			this.labelMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(87)))));
			this.labelMatKhau.Location = new System.Drawing.Point(93, 329);
			this.labelMatKhau.Name = "labelMatKhau";
			this.labelMatKhau.Size = new System.Drawing.Size(71, 16);
			this.labelMatKhau.TabIndex = 6;
			this.labelMatKhau.Text = "Mật Khẩu";
			// 
			// textBoxMatKhau
			// 
			this.textBoxMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(87)))));
			this.textBoxMatKhau.Location = new System.Drawing.Point(96, 354);
			this.textBoxMatKhau.Name = "textBoxMatKhau";
			this.textBoxMatKhau.PasswordChar = '*';
			this.textBoxMatKhau.Size = new System.Drawing.Size(202, 26);
			this.textBoxMatKhau.TabIndex = 5;
			this.textBoxMatKhau.TextChanged += new System.EventHandler(this.textBoxMatKhau_TextChanged);
			// 
			// btn_DangNhap
			// 
			this.btn_DangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_DangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(87)))));
			this.btn_DangNhap.Location = new System.Drawing.Point(149, 440);
			this.btn_DangNhap.Name = "btn_DangNhap";
			this.btn_DangNhap.Size = new System.Drawing.Size(100, 50);
			this.btn_DangNhap.TabIndex = 7;
			this.btn_DangNhap.Text = "Đăng Nhập";
			this.btn_DangNhap.UseVisualStyleBackColor = true;
			this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
			// 
			// linkLabel_QuenMatKhau
			// 
			this.linkLabel_QuenMatKhau.ActiveLinkColor = System.Drawing.Color.MediumPurple;
			this.linkLabel_QuenMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel_QuenMatKhau.AutoSize = true;
			this.linkLabel_QuenMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel_QuenMatKhau.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(87)))));
			this.linkLabel_QuenMatKhau.Location = new System.Drawing.Point(192, 396);
			this.linkLabel_QuenMatKhau.Name = "linkLabel_QuenMatKhau";
			this.linkLabel_QuenMatKhau.Size = new System.Drawing.Size(106, 15);
			this.linkLabel_QuenMatKhau.TabIndex = 9;
			this.linkLabel_QuenMatKhau.TabStop = true;
			this.linkLabel_QuenMatKhau.Text = "Quên Mật Khẩu";
			this.linkLabel_QuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(139, 103);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(120, 120);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// FormDangNhap
			// 
			this.AcceptButton = this.btn_DangNhap;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.ClientSize = new System.Drawing.Size(384, 611);
			this.Controls.Add(this.linkLabel_QuenMatKhau);
			this.Controls.Add(this.btn_DangNhap);
			this.Controls.Add(this.labelMatKhau);
			this.Controls.Add(this.textBoxMatKhau);
			this.Controls.Add(this.labelTaiKhoan);
			this.Controls.Add(this.textBoxTaiKhoan);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panelControlBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormDangNhap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormDangNhap";
			this.Load += new System.EventHandler(this.FormDangNhap_Load);
			this.panelControlBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Minimize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Maximize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Exit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelControlBox;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox_Minimize;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox_Maximize;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox_Exit;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox textBoxTaiKhoan;
		private System.Windows.Forms.Label labelTaiKhoan;
		private System.Windows.Forms.Label labelMatKhau;
		private System.Windows.Forms.TextBox textBoxMatKhau;
		private System.Windows.Forms.Button btn_DangNhap;
		private System.Windows.Forms.LinkLabel linkLabel_QuenMatKhau;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}