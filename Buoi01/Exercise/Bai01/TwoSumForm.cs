using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise.Bai01
{
    public partial class TwoSumForm : Form
    {
        public TwoSumForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumber2.Text.Trim()) || txtNumber2.Text.Trim() == "-")
                return;

            if (!int.TryParse(txtNumber2.Text.Trim(), out int number02))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber2.Clear();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumber1.Text.Trim()) || txtNumber1.Text.Trim() == "-")
                return;

            if (!int.TryParse(txtNumber1.Text.Trim(), out int number01))
            {
                MessageBox.Show($"Giá trị số nguyên nằm trong khoảng {int.MinValue} đến {int.MaxValue}. Vui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber1.Clear();
            }
        }

        private void btnCalcul_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumber1.Text.Trim()) && string.IsNullOrEmpty(txtNumber2.Text.Trim()))
            {
                MessageBox.Show("Số thứ nhất, số thứ hai không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtNumber1.Text.Trim()))
            {
                MessageBox.Show("Số thứ nhất không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtNumber2.Text.Trim()))
            {
                MessageBox.Show("Số thứ hai không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int number01 = Convert.ToInt32(txtNumber1.Text.Trim());
            int number02 = Convert.ToInt32(txtNumber2.Text.Trim());

            long sum = number01 + number02;
            lblResult.Text = sum.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtNumber1.Clear();
            txtNumber2.Clear();
            lblResult.Text = "0";
        }

        private void txtNumber1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && ((TextBox)sender).Text.Contains('-'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && ((TextBox)sender).SelectionStart != 0)
            {
                e.Handled = true;
            }
        }

        private void txtNumber2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && ((TextBox)sender).Text.Contains('-'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && ((TextBox)sender).SelectionStart != 0)
            {
                e.Handled = true;
            }
        }

        private void TwoSumForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void TwoSumForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
