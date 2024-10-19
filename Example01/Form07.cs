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
    public partial class Form07 : Form
    {
        public Form07()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string msg = null;
            int disc = 0;
            if (rbMale.Checked == true)
            {
                msg += "Ông ";
            }
            if (rbFemale.Checked == true)
            {
                msg += "Bà ";
            }
            if (ckDiscount.Checked == true)
            {
                disc = 5;
                tbResult.Text = msg + tbName.Text + " được giảm giá " + disc.ToString() + "%" + "\r\n";
            }
        }

        private void ckDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDiscount.Checked == true)
            {
                tbDiscount.Enabled = true;
            }
            else
            {
                tbDiscount.Enabled = false;
            }
        }

        private void tbResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
