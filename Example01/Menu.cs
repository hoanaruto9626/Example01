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
    public partial class Menu : Form
    {
        List<Book> sach = new List<Book>();

        public Menu()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Book book = new Book
            {
                Tensach = txtTenSach.Text,
                Tacgia = txtTacGia.Text,
                Gia = txtGia.Text,
                Soluong = txtSoLuong.Text
            };
            sach.Add(book);
            HienThiDanhSach();
            ClearTextBoxes();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (Book s in sach)
            {
                if (s.Tensach == txtTenSach.Text)
                {
                    s.Tacgia = txtTacGia.Text;
                    s.Gia = txtGia.Text;
                    s.Soluong = txtSoLuong.Text;
                    found = true;  // Đánh dấu là đã tìm thấy học sinh
                    break;
                }
            }

            if (found)
            {
                HienThiDanhSach();  // Cập nhật lại DataGridView
                ClearTextBoxes();    // Xóa các ô nhập
            }
            else
            {
                MessageBox.Show("Không tìm thấy sách với mã này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            sach.RemoveAll(hs => hs.Tensach == txtTenSach.Text);
            HienThiDanhSach();
            ClearTextBoxes();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
        private void ClearTextBoxes()
        {
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            txtGia.Text = "";
            txtSoLuong.Text = "";
        }

        private void HienThiDanhSach()
        {
            dgvSach.DataSource = null;
            dgvSach.DataSource = sach;
        }
    }

    public class Book
    {
        public string Tensach { get; set; }
        public string Tacgia { get; set; }
        public string Gia { get; set; }
        public string Soluong { get; set; }
    }
}
