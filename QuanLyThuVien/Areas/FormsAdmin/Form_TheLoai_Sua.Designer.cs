
namespace QuanLyThuVien.Areas.FormsAdmin
{
	partial class Form_TheLoai_Sua
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
			this.btn_LuuLai = new Guna.UI2.WinForms.Guna2Button();
			this.iconPictureBox_Exit = new FontAwesome.Sharp.IconPictureBox();
			this.textBox_TheLoai = new System.Windows.Forms.TextBox();
			this.label_theLoai = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Exit)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
			this.panel2.Controls.Add(this.btn_LuuLai);
			this.panel2.Controls.Add(this.iconPictureBox_Exit);
			this.panel2.Controls.Add(this.textBox_TheLoai);
			this.panel2.Controls.Add(this.label_theLoai);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(624, 180);
			this.panel2.TabIndex = 10;
			// 
			// btn_LuuLai
			// 
			this.btn_LuuLai.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_LuuLai.AutoRoundedCorners = true;
			this.btn_LuuLai.BorderRadius = 21;
			this.btn_LuuLai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_LuuLai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_LuuLai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_LuuLai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_LuuLai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(87)))));
			this.btn_LuuLai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_LuuLai.ForeColor = System.Drawing.Color.White;
			this.btn_LuuLai.Location = new System.Drawing.Point(233, 110);
			this.btn_LuuLai.Name = "btn_LuuLai";
			this.btn_LuuLai.Size = new System.Drawing.Size(180, 45);
			this.btn_LuuLai.TabIndex = 11;
			this.btn_LuuLai.Text = "Lưu lại";
			// 
			// iconPictureBox_Exit
			// 
			this.iconPictureBox_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.iconPictureBox_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
			this.iconPictureBox_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.iconPictureBox_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.iconPictureBox_Exit.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
			this.iconPictureBox_Exit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.iconPictureBox_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconPictureBox_Exit.IconSize = 25;
			this.iconPictureBox_Exit.Location = new System.Drawing.Point(587, 4);
			this.iconPictureBox_Exit.Name = "iconPictureBox_Exit";
			this.iconPictureBox_Exit.Size = new System.Drawing.Size(25, 25);
			this.iconPictureBox_Exit.TabIndex = 2;
			this.iconPictureBox_Exit.TabStop = false;
			this.iconPictureBox_Exit.Click += new System.EventHandler(this.iconPictureBox_Exit_Click);
			// 
			// textBox_TheLoai
			// 
			this.textBox_TheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_TheLoai.Location = new System.Drawing.Point(129, 63);
			this.textBox_TheLoai.Name = "textBox_TheLoai";
			this.textBox_TheLoai.Size = new System.Drawing.Size(446, 26);
			this.textBox_TheLoai.TabIndex = 1;
			// 
			// label_theLoai
			// 
			this.label_theLoai.AutoSize = true;
			this.label_theLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_theLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.label_theLoai.Location = new System.Drawing.Point(36, 66);
			this.label_theLoai.Name = "label_theLoai";
			this.label_theLoai.Size = new System.Drawing.Size(78, 20);
			this.label_theLoai.TabIndex = 0;
			this.label_theLoai.Text = "Thể Loại";
			// 
			// Form_TheLoai_Sua
			// 
			this.AcceptButton = this.btn_LuuLai;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 180);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form_TheLoai_Sua";
			this.Text = "Form_TheLoai_Sua";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Exit)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private Guna.UI2.WinForms.Guna2Button btn_LuuLai;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox_Exit;
		private System.Windows.Forms.TextBox textBox_TheLoai;
		private System.Windows.Forms.Label label_theLoai;
	}
}