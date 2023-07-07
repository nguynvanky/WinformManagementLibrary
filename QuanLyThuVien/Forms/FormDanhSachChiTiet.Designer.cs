
namespace QuanLyThuVien.Forms
{
	partial class FormDanhSachChiTiet
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel_main = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dgv_ChiTietThueSach = new Guna.UI2.WinForms.Guna2DataGridView();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_GiaHan = new Guna.UI2.WinForms.Guna2Button();
			this.btn_TraSach = new Guna.UI2.WinForms.Guna2Button();
			this.cbb_TrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
			this.panelControlBox = new System.Windows.Forms.Panel();
			this.iconPictureBox_Minimize = new FontAwesome.Sharp.IconPictureBox();
			this.iconPictureBox_Maximize = new FontAwesome.Sharp.IconPictureBox();
			this.iconPictureBox_Exit = new FontAwesome.Sharp.IconPictureBox();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietThueSach)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.panelControlBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Minimize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Maximize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Exit)).BeginInit();
			this.SuspendLayout();
			// 
			// panel_main
			// 
			this.panel_main.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel_main.Location = new System.Drawing.Point(0, 156);
			this.panel_main.Name = "panel_main";
			this.panel_main.Size = new System.Drawing.Size(1044, 486);
			this.panel_main.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dgv_ChiTietThueSach);
			this.panel2.Controls.Add(this.tableLayoutPanel1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 34);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1044, 122);
			this.panel2.TabIndex = 1;
			// 
			// dgv_ChiTietThueSach
			// 
			this.dgv_ChiTietThueSach.AllowUserToAddRows = false;
			this.dgv_ChiTietThueSach.AllowUserToDeleteRows = false;
			this.dgv_ChiTietThueSach.AllowUserToOrderColumns = true;
			this.dgv_ChiTietThueSach.AllowUserToResizeColumns = false;
			this.dgv_ChiTietThueSach.AllowUserToResizeRows = false;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(216)))), ((int)(((byte)(176)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgv_ChiTietThueSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgv_ChiTietThueSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(87)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(87)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_ChiTietThueSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgv_ChiTietThueSach.ColumnHeadersHeight = 30;
			this.dgv_ChiTietThueSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(216)))), ((int)(((byte)(176)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_ChiTietThueSach.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgv_ChiTietThueSach.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_ChiTietThueSach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_ChiTietThueSach.Location = new System.Drawing.Point(0, 0);
			this.dgv_ChiTietThueSach.MultiSelect = false;
			this.dgv_ChiTietThueSach.Name = "dgv_ChiTietThueSach";
			this.dgv_ChiTietThueSach.ReadOnly = true;
			this.dgv_ChiTietThueSach.RowHeadersVisible = false;
			this.dgv_ChiTietThueSach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgv_ChiTietThueSach.Size = new System.Drawing.Size(879, 122);
			this.dgv_ChiTietThueSach.TabIndex = 1;
			this.dgv_ChiTietThueSach.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgv_ChiTietThueSach.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgv_ChiTietThueSach.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgv_ChiTietThueSach.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgv_ChiTietThueSach.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgv_ChiTietThueSach.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgv_ChiTietThueSach.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_ChiTietThueSach.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgv_ChiTietThueSach.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgv_ChiTietThueSach.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_ChiTietThueSach.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgv_ChiTietThueSach.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgv_ChiTietThueSach.ThemeStyle.HeaderStyle.Height = 30;
			this.dgv_ChiTietThueSach.ThemeStyle.ReadOnly = true;
			this.dgv_ChiTietThueSach.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgv_ChiTietThueSach.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgv_ChiTietThueSach.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_ChiTietThueSach.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgv_ChiTietThueSach.ThemeStyle.RowsStyle.Height = 22;
			this.dgv_ChiTietThueSach.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_ChiTietThueSach.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.btn_GiaHan, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btn_TraSach, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.cbb_TrangThai, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(879, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(165, 122);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// btn_GiaHan
			// 
			this.btn_GiaHan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_GiaHan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_GiaHan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_GiaHan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_GiaHan.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_GiaHan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(87)))));
			this.btn_GiaHan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_GiaHan.ForeColor = System.Drawing.Color.White;
			this.btn_GiaHan.Location = new System.Drawing.Point(3, 43);
			this.btn_GiaHan.Name = "btn_GiaHan";
			this.btn_GiaHan.Size = new System.Drawing.Size(159, 34);
			this.btn_GiaHan.TabIndex = 1;
			this.btn_GiaHan.Text = "Gia hạn";
			// 
			// btn_TraSach
			// 
			this.btn_TraSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_TraSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_TraSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_TraSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_TraSach.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_TraSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(87)))));
			this.btn_TraSach.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_TraSach.ForeColor = System.Drawing.Color.White;
			this.btn_TraSach.Location = new System.Drawing.Point(3, 3);
			this.btn_TraSach.Name = "btn_TraSach";
			this.btn_TraSach.Size = new System.Drawing.Size(159, 34);
			this.btn_TraSach.TabIndex = 0;
			this.btn_TraSach.Text = "Trả sách";
			// 
			// cbb_TrangThai
			// 
			this.cbb_TrangThai.BackColor = System.Drawing.Color.Transparent;
			this.cbb_TrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbb_TrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbb_TrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbb_TrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbb_TrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbb_TrangThai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbb_TrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbb_TrangThai.ItemHeight = 30;
			this.cbb_TrangThai.Location = new System.Drawing.Point(3, 83);
			this.cbb_TrangThai.Name = "cbb_TrangThai";
			this.cbb_TrangThai.Size = new System.Drawing.Size(159, 36);
			this.cbb_TrangThai.TabIndex = 2;
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
			this.panelControlBox.Size = new System.Drawing.Size(1044, 34);
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
			this.iconPictureBox_Minimize.Location = new System.Drawing.Point(951, 5);
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
			this.iconPictureBox_Maximize.Location = new System.Drawing.Point(982, 5);
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
			this.iconPictureBox_Exit.Location = new System.Drawing.Point(1013, 5);
			this.iconPictureBox_Exit.Name = "iconPictureBox_Exit";
			this.iconPictureBox_Exit.Size = new System.Drawing.Size(25, 25);
			this.iconPictureBox_Exit.TabIndex = 0;
			this.iconPictureBox_Exit.TabStop = false;
			this.iconPictureBox_Exit.Click += new System.EventHandler(this.iconPictureBox_Exit_Click);
			// 
			// FormDanhSachChiTiet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1044, 642);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel_main);
			this.Controls.Add(this.panelControlBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormDanhSachChiTiet";
			this.Text = "FormDanhSachChiTiet";
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietThueSach)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panelControlBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Minimize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Maximize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Exit)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel_main;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private Guna.UI2.WinForms.Guna2Button btn_TraSach;
		private Guna.UI2.WinForms.Guna2Button btn_GiaHan;
		private Guna.UI2.WinForms.Guna2ComboBox cbb_TrangThai;
		private Guna.UI2.WinForms.Guna2DataGridView dgv_ChiTietThueSach;
		private System.Windows.Forms.Panel panelControlBox;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox_Minimize;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox_Maximize;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox_Exit;
	}
}