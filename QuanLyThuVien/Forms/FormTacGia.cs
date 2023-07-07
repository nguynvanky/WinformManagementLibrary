using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms
{
	public partial class FormTacGia : Form
	{
		Library_Entities db = new Library_Entities();
		public FormTacGia()
		{
			InitializeComponent();
			cbb_tacgia.SelectionChangeCommitted += Cbb_tacgia_SelectionChangeCommitted;
		}

		private void Cbb_tacgia_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if (cbb_tacgia.SelectedItem == null)
			{
				MessageBox.Show("Vui lòng chọn tác giả", "Thông báo", MessageBoxButtons.OK);
				return;
			}
			else
			{
				flowLayoutPanel_tacgia.Controls.Clear();
				//flowLayoutPanel_tacgia.Visible = false;
				List<Sach> sachs = new List<Sach>();
				// tim theo tac gia
				sachs = db.Saches.Where(row => row.MaTacGia == (int)cbb_tacgia.SelectedValue).ToList();

				foreach (Sach item in sachs)
				{
					create_item_book(item);
				}
				flowLayoutPanel_tacgia.Visible = true;
			}
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
			right.Text = "Cho Thuê";
			right.Cursor = Cursors.Hand;
			right.Click += Right_Click;
			right.Tag = i.MaSach;
			//PICTURE
			PictureBox pic = new PictureBox();
			string imgBook = i.LinkHinh.ToString();
			string path = $@"Resources\{imgBook}";
			pic.Image = Image.FromFile(path);
			pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			//
			flowLayoutPanel_tacgia.Controls.Add(item);
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
			name.Font = new Font("Arial", 12);
			name.Dock = DockStyle.Fill;
			name.TextAlign = ContentAlignment.MiddleCenter;
			name.BringToFront();

			bottom.Controls.Add(left);
			bottom.Controls.Add(right);
			left.Font = new Font("Arial", 10);
			left.Dock = DockStyle.Left;
			right.Font = new Font("Arial", 10);
			right.Dock = DockStyle.Right;
			//
		}

		private void Left_Click(object sender, EventArgs e)
		{
			int x = int.Parse((sender as Button).Tag.ToString());
			Form f = new ChiTiet(x);
			f.StartPosition = FormStartPosition.CenterScreen;
			f.ShowDialog();
		}

		private void Right_Click(object sender, EventArgs e)
		{
			int x = int.Parse((sender as Button).Tag.ToString());
			Form f = new FormChoThue(x);
			f.StartPosition = FormStartPosition.CenterScreen;
			f.Show();
		}

		
		void load_data()
		{
			List<TacGia> tacGias = db.TacGias.ToList();
			cbb_tacgia.DataSource = tacGias;
			cbb_tacgia.DisplayMember = "TenTacGia";
			cbb_tacgia.ValueMember = "MaTacGia";
			cbb_tacgia.SelectedIndex = -1;

		}
		private void FormTacGia_Load(object sender, EventArgs e)
		{
			load_data();
		}
	}
}
