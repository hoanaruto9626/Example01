using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public partial class form17 : Form
    {
        PictureBox pbBasket = new PictureBox();

        int xBasket = 300;
        int yBasket = 500;
        int xDelta = 30;

        public form17()
        {
            InitializeComponent();
            // Đảm bảo rằng form có thể nhận sự kiện KeyDown
            this.KeyPreview = true;

            // Gắn sự kiện KeyDown cho form
            this.KeyDown += new KeyEventHandler(form17_KeyDown);
        }

        private void form17_Load(object sender, EventArgs e)
        {
            pbBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBasket.Size = new Size(100, 100);
            pbBasket.Location = new Point(xBasket, yBasket);
            pbBasket.BackColor = Color.Transparent;

            this.Controls.Add(pbBasket);

            string imagePath = @"E:\DoAn C#\Example\Example\Images\basket.png";
            if (System.IO.File.Exists(imagePath))
            {
                pbBasket.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("Không tìm thấy file hình ảnh: " + imagePath);
            }

            // Đảm bảo form có thể nhận được sự kiện bàn phím
            this.Select();
        }

        private void form17_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right && xBasket < this.ClientSize.Width - pbBasket.Width)
            {
                xBasket += xDelta;  // Di chuyển giỏ sang phải
            }

            if (e.KeyCode == Keys.Left && xBasket > 0)
            {
                xBasket -= xDelta;  // Di chuyển giỏ sang trái
            }

            pbBasket.Location = new Point(xBasket, yBasket);  // Cập nhật vị trí giỏ
        }
    }
}
