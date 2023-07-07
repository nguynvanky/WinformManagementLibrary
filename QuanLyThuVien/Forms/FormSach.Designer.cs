
namespace QuanLyThuVien.Forms
{
	partial class FormSach
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
			this.flowLayoutPanel_Sach = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// flowLayoutPanel_Sach
			// 
			this.flowLayoutPanel_Sach.AutoScroll = true;
			this.flowLayoutPanel_Sach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.flowLayoutPanel_Sach.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel_Sach.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel_Sach.Name = "flowLayoutPanel_Sach";
			this.flowLayoutPanel_Sach.Size = new System.Drawing.Size(800, 450);
			this.flowLayoutPanel_Sach.TabIndex = 1;
			this.flowLayoutPanel_Sach.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel_Sach_Paint);
			// 
			// FormSach
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.flowLayoutPanel_Sach);
			this.Name = "FormSach";
			this.Text = "FormSach";
			this.Load += new System.EventHandler(this.FormSach_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Sach;
	}
}