using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise.Bai04
{
    public partial class ReadNumberAdvanceForm : Form
    {
        public ReadNumberAdvanceForm()
        {
            InitializeComponent();
        }

        private void ReadNumberAdvanceForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string input = txtNumber.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Vui lòng nhập số để tiến hành đọc!",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(input, out long number) || input.Length > 12)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ (không quá 12 chữ số).",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (number == 0)
            {
                rtbOutput.Text = "Không";
                return;
            }

            rtbOutput.Text = number > 0 ? ReadNumber(number) : "Âm " + ReadNumber(Math.Abs(number));
        }

        private string ReadNumber(long number)
        {
            string[] units = { "", "nghìn", "triệu", "tỷ" };
            string result = "";
            int groupIndex = 0;

            while (number > 0)
            {
                int threeDigits = (int)(number % 1000);
                number /= 1000;

                if (threeDigits > 0)
                {
                    string groupText = ReadThreeDigits(threeDigits);
                    if (groupIndex > 0) groupText += " " + units[groupIndex];
                    result = groupText + (result == "" ? "" : ", " + result);
                }

                groupIndex++;
            }

            result = char.ToUpper(result[0]) + result.Substring(1);

            return result.Trim();
        }

        private string ReadThreeDigits(int number)
        {
            string[] numText =
            {
                "không", "một", "hai", "ba", "bốn",
                "năm", "sáu", "bảy", "tám", "chín"
            };

            int hundreds = number / 100;
            int tens = (number / 10) % 10;
            int ones = number % 10;

            string result = "";

            if (hundreds > 0)
            {
                result += numText[hundreds] + " trăm";
                if (tens == 0 && ones > 0)
                    result += " lẻ";
            }

            if (tens > 1)
            {
                result += " " + numText[tens] + " mươi";
                if (ones == 1) result += " mốt";
                else if (ones == 5) result += " lăm";
                else if (ones > 0) result += " " + numText[ones];
            }
            else if (tens == 1)
            {
                result += " mười";
                if (ones == 5) result += " lăm";
                else if (ones > 0) result += " " + numText[ones];
            }
            else if (tens == 0 && hundreds == 0 && ones > 0)
            {
                result += numText[ones];
            }
            else if (tens == 0 && ones > 0)
            {
                result += " " + numText[ones];
            }

            return result.Trim();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
