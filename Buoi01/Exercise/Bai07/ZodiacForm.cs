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

namespace Exercise.Bai07
{
    public partial class ZodiacForm : Form
    {
        public ZodiacForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e) 
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();
            DateTime birthDate;

            if (!DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng: dd/MM/yyyy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int day = birthDate.Day;
            int month = birthDate.Month;

            string zodiac = GetZodiacSign(day, month);
            lblOutput.Text = $"Cung hoàng đạo của bạn là: {zodiac}";
        }

        private string GetZodiacSign(int day, int month)
        {
            switch (month)
            {
                case 1:
                    if (day >= 21) return "Bảo Bình";
                    else return "Ma Kết";

                case 2:
                    if (day >= 20) return "Song Ngư";
                    else return "Bảo Bình";

                case 3:
                    if (day >= 21) return "Bạch Dương";
                    else return "Song Ngư";

                case 4:
                    if (day >= 21) return "Kim Ngưu";
                    else return "Bạch Dương";

                case 5:
                    if (day >= 22) return "Song Tử";
                    else return "Kim Ngưu";

                case 6:
                    if (day >= 22) return "Cự Giải";
                    else return "Song Tử";

                case 7:
                    if (day >= 23) return "Sư Tử";
                    else return "Cự Giải";

                case 8:
                    if (day >= 23) return "Xử Nữ";
                    else return "Sư Tử";

                case 9:
                    if (day >= 24) return "Thiên Bình";
                    else return "Xử Nữ";

                case 10:
                    if (day >= 24) return "Thần Nông";
                    else return "Thiên Bình";

                case 11:
                    if (day >= 23) return "Nhân Mã";
                    else return "Thần Nông";

                case 12:
                    if (day >= 22) return "Ma Kết";
                    else return "Nhân Mã";

                default:
                    return "Không xác định";
            }
        }

    }
}
