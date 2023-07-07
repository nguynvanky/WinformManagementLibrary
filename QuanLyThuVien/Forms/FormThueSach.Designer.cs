
namespace QuanLyThuVien.Forms
{
	partial class FormThueSach
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
			this.panel_Main = new System.Windows.Forms.Panel();
			this.panel_header = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel_header.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel_Main
			// 
			this.panel_Main.AutoScroll = true;
			this.panel_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_Main.Location = new System.Drawing.Point(0, 35);
			this.panel_Main.Name = "panel_Main";
			this.panel_Main.Size = new System.Drawing.Size(959, 488);
			this.panel_Main.TabIndex = 0;
			// 
			// panel_header
			// 
			this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.panel_header.Controls.Add(this.label1);
			this.panel_header.Controls.Add(this.label5);
			this.panel_header.Controls.Add(this.label6);
			this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel_header.Location = new System.Drawing.Point(0, 0);
			this.panel_header.Name = "panel_header";
			this.panel_header.Size = new System.Drawing.Size(959, 35);
			this.panel_header.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(527, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 18);
			this.label1.TabIndex = 9;
			this.label1.Text = "Số điện thoại";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(209, 7);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 18);
			this.label5.TabIndex = 8;
			this.label5.Text = "Địa chỉ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(43, 7);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 18);
			this.label6.TabIndex = 7;
			this.label6.Text = "Tên";
			// 
			// FormThueSach
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(959, 523);
			this.Controls.Add(this.panel_Main);
			this.Controls.Add(this.panel_header);
			this.Name = "FormThueSach";
			this.Text = "FormThueSach";
			this.Load += new System.EventHandler(this.FormThueSach_Load);
			this.panel_header.ResumeLayout(false);
			this.panel_header.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel_Main;
		private System.Windows.Forms.Panel panel_header;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}