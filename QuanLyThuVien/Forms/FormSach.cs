using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms
{
	public partial class FormSach : Form
	{
		Library_Entities db = new Library_Entities();
		string user;
		public FormSach()
		{
			InitializeComponent();
		}
		public FormSach(string _user)
		{
			user = _user;
			InitializeComponent();
		}
		private void create_item_book(Sach i)
		{
			// item
			Panel item = new Panel();
			item.Size = new Size(220, 250);
			item.BorderStyle = BorderStyle.FixedSingle;
			item.Margin = new Padding(20);
			//top
			Panel top = new Panel();
			//bottom
			Panel bottom = new Panel();
			//middle
			Panel middle = new Panel();
			//lable
			Label name = new Label();
			//buttonleft
			Button left = new Button();
			left.Size = new Size(109, 30);
			left.FlatStyle = FlatStyle.Flat;
			left.ForeColor = Color.FromArgb(60, 35, 23);
			left.Text = "Chi tiết";
			left.Cursor = Cursors.Hand;
			left.Click += Left_Click;
			left.Tag = i.MaSach;
			//buttonright
			Button right = new Button();
			right.Size = new Size(109, 30);
			right.FlatStyle = FlatStyle.Flat;
			right.ForeColor = Color.FromArgb(60, 35, 23);
			right.Text = "Cho Mượn";
			right.Cursor = Cursors.Hand;
			right.Click += Right_Click;
			right.Tag = i.MaSach;
			//PICTURE
			PictureBox pic = new PictureBox();
			string imgBook = i.LinkHinh.ToString();
			string path = $@"..\..\Resources\{imgBook}";
			pic.Image = Image.FromFile(path);
			pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			//
			flowLayoutPanel_Sach.Controls.Add(item);
			item.BringToFront();
			item.BackColor = Color.FromArgb(224, 216, 176);
			item.BorderStyle = BorderStyle.None;
			item.Controls.Add(top);
			top.Dock = DockStyle.Top;
			top.Size = new Size(250, 150);
			top.BringToFront();
			//
			top.Controls.Add(pic);
			pic.Dock = DockStyle.Fill;
			pic.BringToFront();

			item.Controls.Add(bottom);
			bottom.Dock = DockStyle.Bottom;
			bottom.Size = new Size(200, 30);
			bottom.BringToFront();

			item.Controls.Add(middle);
			middle.Dock = DockStyle.Fill;
			middle.BringToFront();

			middle.Controls.Add(name);
			name.ForeColor = Color.FromArgb(60, 35, 23);
			name.Text = i.TenSach;
			name.Font = new Font("Arial",12);
			name.Dock = DockStyle.Fill;
			name.TextAlign = ContentAlignment.MiddleCenter;
			name.BringToFront();

			bottom.Controls.Add(left);
			bottom.Controls.Add(right);
			left.Font = new Font("Arial",10);
			left.Dock = DockStyle.Left;
			right.Font = new Font("Arial", 10);
			right.Dock = DockStyle.Right;
			//
		}
		private void Load_Books()
		{
			flowLayoutPanel_Sach.Controls.Clear();
			flowLayoutPanel_Sach.Visible = false;
			List<Sach> sachs = db.Saches.ToList();
			foreach (Sach i in sachs)
			{
				create_item_book(i);
			}
			flowLayoutPanel_Sach.Visible = true ;
		}

		private void Right_Click(object sender, EventArgs e)
		{
			int x = int.Parse((sender as Button).Tag.ToString());
			FormChoThue f = new FormChoThue(x);
			f.user = user;
			f.StartPosition = FormStartPosition.CenterScreen;
			f.Show();

		}

		private void Left_Click(object sender, EventArgs e)
		{
			int x = int.Parse((sender as Button).Tag.ToString());
			ChiTiet f = new ChiTiet(x);
			f.StartPosition = FormStartPosition.CenterScreen;
			f.ShowDialog();
		}

		private void FormSach_Load(object sender, EventArgs e)
		{
			Load_Books();
		}

		private void flowLayoutPanel_Sach_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
