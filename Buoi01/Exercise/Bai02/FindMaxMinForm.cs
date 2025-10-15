using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Exercise.Bai02
{
    public partial class FindMaxMinForm : Form
    {
        public FindMaxMinForm()
        {
            InitializeComponent();
        }

        private void FindMaxMinForm_Load(object sender, EventArgs e)
        {

        }

        private void txtNumber2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtNumber1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '.' && txtNumber1.Text.Contains('.'))
                e.Handled = true;

            if (e.KeyChar == '-' && txtNumber1.SelectionStart != 0)
                e.Handled = true;
        }

        private void txtNumber2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '.' && txtNumber2.Text.Contains('.'))
                e.Handled = true;

            if (e.KeyChar == '-' && txtNumber2.SelectionStart != 0)
                e.Handled = true;
        }

        private void txtNumber3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '.' && txtNumber3.Text.Contains('.'))
                e.Handled = true;

            if (e.KeyChar == '-' && txtNumber3.SelectionStart != 0)
                e.Handled = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumber1.Text) ||
                string.IsNullOrWhiteSpace(txtNumber2.Text) ||
                string.IsNullOrWhiteSpace(txtNumber3.Text))
            {
                MessageBox.Show("Không được bỏ trống ô nhập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                double n1 = double.Parse(txtNumber1.Text, CultureInfo.InvariantCulture);
                double n2 = double.Parse(txtNumber2.Text, CultureInfo.InvariantCulture);
                double n3 = double.Parse(txtNumber3.Text, CultureInfo.InvariantCulture);

                if (double.IsInfinity(n1) || double.IsInfinity(n2) || double.IsInfinity(n3))
                {
                    MessageBox.Show("Giá trị nhập quá lớn hoặc quá nhỏ!", "Lỗi tràn số", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double max = Math.Max(n1, Math.Max(n2, n3));
                double min = Math.Min(n1, Math.Min(n2, n3));

                lblMax.Text = max.ToString(CultureInfo.InvariantCulture);
                lblMin.Text = min.ToString(CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtNumber1.Clear();
            txtNumber2.Clear();
            txtNumber3.Clear();
            lblMax.Text = "";
            lblMin.Text = "";
            txtNumber1.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
