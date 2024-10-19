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
    public partial class Form09 : Form
    {
        public Form09()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoten = txtName.Text;
            string ngaysinh = dtpDate.Value.ToString("dd/MM/yyyy");
            string gioiTinh = rbMale.Checked ? "Nam" : "Nữ";
            string khoa = cb_Faculty.SelectedItem?.ToString() ?? "Chưa chọn";

            string thongTinSinhVien = $"{listBoxSinhVien.Items.Count + 1}. {hoten}\n" +
                                      $"- Giới tính: {gioiTinh}\n" +
                                      $"- Ngày sinh: {ngaysinh}\n" +
                                      $"- Khoa: {khoa}\n";

            listBoxSinhVien.Items.Add(thongTinSinhVien);

            txtName.Clear();
            rbMale.Checked = true;
            cb_Faculty.SelectedIndex = -1;
        }

        private void Form09_Load(object sender, EventArgs e)
        {

        }
    }
}
