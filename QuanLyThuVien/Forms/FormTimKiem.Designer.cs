
namespace QuanLyThuVien.Forms
{
	partial class FormTimKiem
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
			this.iconButton_TimKiem = new FontAwesome.Sharp.IconButton();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel_Sach = new System.Windows.Forms.FlowLayoutPanel();
			this.comboBox_TimKiem = new Guna.UI2.WinForms.Guna2ComboBox();
			this.textBox_TimKiem = new Guna.UI2.WinForms.Guna2TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// iconButton_TimKiem
			// 
			this.iconButton_TimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.iconButton_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton_TimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
			this.iconButton_TimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
			this.iconButton_TimKiem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
			this.iconButton_TimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton_TimKiem.IconSize = 20;
			this.iconButton_TimKiem.Location = new System.Drawing.Point(777, 3);
			this.iconButton_TimKiem.Name = "iconButton_TimKiem";
			this.iconButton_TimKiem.Size = new System.Drawing.Size(81, 36);
			this.iconButton_TimKiem.TabIndex = 1;
			this.iconButton_TimKiem.UseVisualStyleBackColor = true;
			this.iconButton_TimKiem.Click += new System.EventHandler(this.iconButton_TimKiem_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.Controls.Add(this.textBox_TimKiem, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.comboBox_TimKiem, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.iconButton_TimKiem, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(861, 42);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// flowLayoutPanel_Sach
			// 
			this.flowLayoutPanel_Sach.AutoScroll = true;
			this.flowLayoutPanel_Sach.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel_Sach.Location = new System.Drawing.Point(0, 42);
			this.flowLayoutPanel_Sach.Name = "flowLayoutPanel_Sach";
			this.flowLayoutPanel_Sach.Size = new System.Drawing.Size(861, 437);
			this.flowLayoutPanel_Sach.TabIndex = 4;
			// 
			// comboBox_TimKiem
			// 
			this.comboBox_TimKiem.BackColor = System.Drawing.Color.Transparent;
			this.comboBox_TimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBox_TimKiem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.comboBox_TimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_TimKiem.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.comboBox_TimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.comboBox_TimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_TimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.comboBox_TimKiem.ItemHeight = 30;
			this.comboBox_TimKiem.Location = new System.Drawing.Point(433, 3);
			this.comboBox_TimKiem.Name = "comboBox_TimKiem";
			this.comboBox_TimKiem.Size = new System.Drawing.Size(338, 36);
			this.comboBox_TimKiem.TabIndex = 0;
			// 
			// textBox_TimKiem
			// 
			this.textBox_TimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBox_TimKiem.DefaultText = "";
			this.textBox_TimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.textBox_TimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.textBox_TimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.textBox_TimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.textBox_TimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_TimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.textBox_TimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_TimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.textBox_TimKiem.Location = new System.Drawing.Point(4, 4);
			this.textBox_TimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox_TimKiem.Name = "textBox_TimKiem";
			this.textBox_TimKiem.PasswordChar = '\0';
			this.textBox_TimKiem.PlaceholderText = "";
			this.textBox_TimKiem.SelectedText = "";
			this.textBox_TimKiem.Size = new System.Drawing.Size(422, 34);
			this.textBox_TimKiem.TabIndex = 0;
			// 
			// FormTimKiem
			// 
			this.AcceptButton = this.iconButton_TimKiem;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.ClientSize = new System.Drawing.Size(861, 479);
			this.Controls.Add(this.flowLayoutPanel_Sach);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "FormTimKiem";
			this.Text = "FormTimKiem";
			this.Load += new System.EventHandler(this.FormTimKiem_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private FontAwesome.Sharp.IconButton iconButton_TimKiem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Sach;
		private Guna.UI2.WinForms.Guna2ComboBox comboBox_TimKiem;
		private Guna.UI2.WinForms.Guna2TextBox textBox_TimKiem;
	}
}