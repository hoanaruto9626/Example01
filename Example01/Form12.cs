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
    public partial class Form112 : Form
    {
        public Form112()
        {
            InitializeComponent();
        }

        private void Form112_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            dgvEmployee.Rows.Add(txtId.Text, txtName.Text, txtAge.Text, ckGender.Checked);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow != null)
            {
                int idx = dgvEmployee.CurrentCell.RowIndex;
                dgvEmployee.Rows.RemoveAt(idx);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvEmployee.Rows.Count - 1) // Tránh lỗi khi chọn hàng rỗng
            {
                int idx = e.RowIndex;
                txtId.Text = dgvEmployee.Rows[idx].Cells[0].Value?.ToString();
                txtName.Text = dgvEmployee.Rows[idx].Cells[1].Value?.ToString();
                txtAge.Text = dgvEmployee.Rows[idx].Cells[2].Value?.ToString();
                ckGender.Checked = bool.TryParse(dgvEmployee.Rows[idx].Cells[3].Value?.ToString(), out bool isMale) && isMale;
            }
        }
    }
}
