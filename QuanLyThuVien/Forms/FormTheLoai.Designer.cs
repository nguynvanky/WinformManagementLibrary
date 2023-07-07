
namespace QuanLyThuVien.Forms
{
	partial class FormTheLoai
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
			this.cbb_TheLoai = new Guna.UI2.WinForms.Guna2ComboBox();
			this.flowLayoutPanel_TheLoai = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbb_TheLoai
			// 
			this.cbb_TheLoai.BackColor = System.Drawing.Color.Transparent;
			this.cbb_TheLoai.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbb_TheLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbb_TheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbb_TheLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbb_TheLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbb_TheLoai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbb_TheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbb_TheLoai.ItemHeight = 30;
			this.cbb_TheLoai.Location = new System.Drawing.Point(0, 0);
			this.cbb_TheLoai.Name = "cbb_TheLoai";
			this.cbb_TheLoai.Size = new System.Drawing.Size(800, 36);
			this.cbb_TheLoai.TabIndex = 0;
			this.cbb_TheLoai.SelectedIndexChanged += new System.EventHandler(this.cbb_TheLoai_SelectedIndexChanged);
			// 
			// flowLayoutPanel_TheLoai
			// 
			this.flowLayoutPanel_TheLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.flowLayoutPanel_TheLoai.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel_TheLoai.Location = new System.Drawing.Point(0, 42);
			this.flowLayoutPanel_TheLoai.Name = "flowLayoutPanel_TheLoai";
			this.flowLayoutPanel_TheLoai.Size = new System.Drawing.Size(800, 408);
			this.flowLayoutPanel_TheLoai.TabIndex = 4;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
			this.panel1.Controls.Add(this.cbb_TheLoai);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 42);
			this.panel1.TabIndex = 5;
			// 
			// FormTheLoai
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.flowLayoutPanel_TheLoai);
			this.Controls.Add(this.panel1);
			this.Name = "FormTheLoai";
			this.Text = "TheLoai";
			this.Load += new System.EventHandler(this.FormTheLoai_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2ComboBox cbb_TheLoai;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_TheLoai;
		private System.Windows.Forms.Panel panel1;
	}
}