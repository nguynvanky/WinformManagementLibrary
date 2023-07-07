
namespace QuanLyThuVien.Forms
{
	partial class FormQuenMatKhau
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
			this.panelControlBox = new System.Windows.Forms.Panel();
			this.iconPictureBox_Minimize = new FontAwesome.Sharp.IconPictureBox();
			this.iconPictureBox_Maximize = new FontAwesome.Sharp.IconPictureBox();
			this.iconPictureBox_Exit = new FontAwesome.Sharp.IconPictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_XacNhan = new System.Windows.Forms.Button();
			this.labelXacNhanMatKhau = new System.Windows.Forms.Label();
			this.textBoxXacNhanMatKhau = new System.Windows.Forms.TextBox();
			this.labelMatKhauMoi = new System.Windows.Forms.Label();
			this.textBoxMatKhau = new System.Windows.Forms.TextBox();
			this.labelTaiKhoan = new System.Windows.Forms.Label();
			this.textBoxTaiKhoan = new System.Windows.Forms.TextBox();
			this.Check_same_pass = new System.Windows.Forms.ErrorProvider(this.components);
			this.panelControlBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Minimize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Maximize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Exit)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Check_same_pass)).BeginInit();
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
			this.panelControlBox.Size = new System.Drawing.Size(334, 40);
			this.panelControlBox.TabIndex = 2;
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
			this.iconPictureBox_Minimize.Location = new System.Drawing.Point(241, 8);
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
			this.iconPictureBox_Maximize.Location = new System.Drawing.Point(272, 8);
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
			this.iconPictureBox_Exit.Location = new System.Drawing.Point(303, 8);
			this.iconPictureBox_Exit.Name = "iconPictureBox_Exit";
			this.iconPictureBox_Exit.Size = new System.Drawing.Size(25, 25);
			this.iconPictureBox_Exit.TabIndex = 0;
			this.iconPictureBox_Exit.TabStop = false;
			this.iconPictureBox_Exit.Click += new System.EventHandler(this.iconPictureBox_Exit_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.panel1.Controls.Add(this.btn_XacNhan);
			this.panel1.Controls.Add(this.labelXacNhanMatKhau);
			this.panel1.Controls.Add(this.textBoxXacNhanMatKhau);
			this.panel1.Controls.Add(this.labelMatKhauMoi);
			this.panel1.Controls.Add(this.textBoxMatKhau);
			this.panel1.Controls.Add(this.labelTaiKhoan);
			this.panel1.Controls.Add(this.textBoxTaiKhoan);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(334, 421);
			this.panel1.TabIndex = 3;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// btn_XacNhan
			// 
			this.btn_XacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_XacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_XacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_XacNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(87)))));
			this.btn_XacNhan.Location = new System.Drawing.Point(116, 274);
			this.btn_XacNhan.Name = "btn_XacNhan";
			this.btn_XacNhan.Size = new System.Drawing.Size(104, 25);
			this.btn_XacNhan.TabIndex = 11;
			this.btn_XacNhan.Text = "Xác nhận";
			this.btn_XacNhan.UseVisualStyleBackColor = true;
			this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
			// 
			// labelXacNhanMatKhau
			// 
			this.labelXacNhanMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelXacNhanMatKhau.AutoSize = true;
			this.labelXacNhanMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelXacNhanMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(87)))));
			this.labelXacNhanMatKhau.Location = new System.Drawing.Point(32, 181);
			this.labelXacNhanMatKhau.Name = "labelXacNhanMatKhau";
			this.labelXacNhanMatKhau.Size = new System.Drawing.Size(132, 16);
			this.labelXacNhanMatKhau.TabIndex = 10;
			this.labelXacNhanMatKhau.Text = "Nhập lại mật khẩu";
			// 
			// textBoxXacNhanMatKhau
			// 
			this.textBoxXacNhanMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxXacNhanMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxXacNhanMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxXacNhanMatKhau.Location = new System.Drawing.Point(35, 206);
			this.textBoxXacNhanMatKhau.Name = "textBoxXacNhanMatKhau";
			this.textBoxXacNhanMatKhau.Size = new System.Drawing.Size(262, 22);
			this.textBoxXacNhanMatKhau.TabIndex = 9;
			this.textBoxXacNhanMatKhau.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// labelMatKhauMoi
			// 
			this.labelMatKhauMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelMatKhauMoi.AutoSize = true;
			this.labelMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMatKhauMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(87)))));
			this.labelMatKhauMoi.Location = new System.Drawing.Point(32, 112);
			this.labelMatKhauMoi.Name = "labelMatKhauMoi";
			this.labelMatKhauMoi.Size = new System.Drawing.Size(99, 16);
			this.labelMatKhauMoi.TabIndex = 8;
			this.labelMatKhauMoi.Text = "Mật khẩu mới";
			// 
			// textBoxMatKhau
			// 
			this.textBoxMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxMatKhau.Location = new System.Drawing.Point(35, 137);
			this.textBoxMatKhau.Name = "textBoxMatKhau";
			this.textBoxMatKhau.Size = new System.Drawing.Size(262, 22);
			this.textBoxMatKhau.TabIndex = 7;
			this.textBoxMatKhau.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// labelTaiKhoan
			// 
			this.labelTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTaiKhoan.AutoSize = true;
			this.labelTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(87)))));
			this.labelTaiKhoan.Location = new System.Drawing.Point(32, 42);
			this.labelTaiKhoan.Name = "labelTaiKhoan";
			this.labelTaiKhoan.Size = new System.Drawing.Size(78, 16);
			this.labelTaiKhoan.TabIndex = 6;
			this.labelTaiKhoan.Text = "Tài Khoản";
			// 
			// textBoxTaiKhoan
			// 
			this.textBoxTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxTaiKhoan.Location = new System.Drawing.Point(35, 67);
			this.textBoxTaiKhoan.Name = "textBoxTaiKhoan";
			this.textBoxTaiKhoan.Size = new System.Drawing.Size(262, 22);
			this.textBoxTaiKhoan.TabIndex = 5;
			// 
			// Check_same_pass
			// 
			this.Check_same_pass.ContainerControl = this;
			// 
			// FormQuenMatKhau
			// 
			this.AcceptButton = this.btn_XacNhan;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 461);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelControlBox);
			this.Name = "FormQuenMatKhau";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormQuenMatKhau";
			this.Load += new System.EventHandler(this.FormQuenMatKhau_Load);
			this.panelControlBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Minimize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Maximize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Exit)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Check_same_pass)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelControlBox;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox_Minimize;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox_Maximize;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox_Exit;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label labelXacNhanMatKhau;
		private System.Windows.Forms.TextBox textBoxXacNhanMatKhau;
		private System.Windows.Forms.Label labelMatKhauMoi;
		private System.Windows.Forms.TextBox textBoxMatKhau;
		private System.Windows.Forms.Label labelTaiKhoan;
		private System.Windows.Forms.TextBox textBoxTaiKhoan;
		private System.Windows.Forms.Button btn_XacNhan;
		private System.Windows.Forms.ErrorProvider Check_same_pass;
	}
}