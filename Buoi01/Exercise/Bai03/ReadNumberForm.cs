using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise.Bai03
{
    public partial class ReadNumberForm : Form
    {
        public ReadNumberForm()
        {
            InitializeComponent();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ReadNumberForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string number = txtNumber.Text;
            if (string.IsNullOrEmpty(number))
            {
                MessageBox.Show("Vui lòng điền số để đọc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (number.Length > 1 || number[0] < '0' || number[0] > '9')
            {
                MessageBox.Show("Vui lòng nhập số từ 0 đến 9!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (Convert.ToInt32(number))
            {
                case 0:
                    lblOutput.Text = "Không";
                    break;
                case 1:
                    lblOutput.Text = "Một";
                    break;
                case 2:
                    lblOutput.Text = "Hai";
                    break;
                case 3:
                    lblOutput.Text = "Ba";
                    break;
                case 4:
                    lblOutput.Text = "Bốn";
                    break;
                case 5:
                    lblOutput.Text = "Năm";
                    break;
                case 6:
                    lblOutput.Text = "Sáu";
                    break;
                case 7:
                    lblOutput.Text = "Bảy";
                    break;
                case 8:
                    lblOutput.Text = "Tám";
                    break;
                default:
                    lblOutput.Text = "Chín";
                    break;
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
