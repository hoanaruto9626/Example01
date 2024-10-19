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
    public partial class Article_21 : Form
    {
        List<Employee> lst;
        public Article_21()
        {
            InitializeComponent();
        }

        private void Article_21_Load(object sender, EventArgs e)
        {
            lst = GetData();
            foreach (Employee em in lst)
            {
                dgvEmployee.Rows.Add(em.Id, em.Name, em.Age);
            }
        }

        public List<Employee> GetData()
        {
            List<Employee> lst = new List<Employee>();
            Employee em = new Employee();
            em.Id = "53418";
            em.Name = "Trần Tiến";
            em.Age = 20;
            lst.Add(em);

            em = new Employee();
            em.Id = "53416";
            em.Name = "Nguyễn Cường";
            em.Age = 25;
            lst.Add(em);

            em = new Employee();
            em.Id = "53417";
            em.Name = "Nguyễn Hảo";
            em.Age = 23;
            lst.Add(em);
            return lst;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Id = txtId.Text;
            em.Name = txtName.Text;
            if (int.TryParse(txtAge.Text, out int age))
            {
                em.Age = age;
            }
            em.Gender = ckGender.Checked;
            lst.Add(em);
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

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
