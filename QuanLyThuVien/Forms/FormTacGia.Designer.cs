
namespace QuanLyThuVien.Forms
{
	partial class FormTacGia
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
			this.flowLayoutPanel_tacgia = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbb_tacgia = new Guna.UI2.WinForms.Guna2ComboBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel_tacgia
			// 
			this.flowLayoutPanel_tacgia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.flowLayoutPanel_tacgia.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel_tacgia.Location = new System.Drawing.Point(0, 42);
			this.flowLayoutPanel_tacgia.Name = "flowLayoutPanel_tacgia";
			this.flowLayoutPanel_tacgia.Size = new System.Drawing.Size(800, 408);
			this.flowLayoutPanel_tacgia.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.panel1.Controls.Add(this.cbb_tacgia);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 42);
			this.panel1.TabIndex = 3;
			// 
			// cbb_tacgia
			// 
			this.cbb_tacgia.BackColor = System.Drawing.Color.Transparent;
			this.cbb_tacgia.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbb_tacgia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbb_tacgia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbb_tacgia.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbb_tacgia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbb_tacgia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbb_tacgia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbb_tacgia.ItemHeight = 30;
			this.cbb_tacgia.Location = new System.Drawing.Point(0, 0);
			this.cbb_tacgia.Name = "cbb_tacgia";
			this.cbb_tacgia.Size = new System.Drawing.Size(800, 36);
			this.cbb_tacgia.TabIndex = 0;
			// 
			// FormTacGia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.flowLayoutPanel_tacgia);
			this.Controls.Add(this.panel1);
			this.Name = "FormTacGia";
			this.Text = "TacGia";
			this.Load += new System.EventHandler(this.FormTacGia_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_tacgia;
		private System.Windows.Forms.Panel panel1;
		private Guna.UI2.WinForms.Guna2ComboBox cbb_tacgia;
	}
}