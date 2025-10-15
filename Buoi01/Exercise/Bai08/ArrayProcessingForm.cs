using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise.Bai08
{
    public partial class ArrayProcessingForm : Form
    {
        public ArrayProcessingForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string input = txtArray.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] parts = input.Split(',', StringSplitOptions.RemoveEmptyEntries)
                                  .Select(p => p.Trim()).ToArray();

            if (parts.Length < 2)
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Cần có ít nhất 1 tên và 1 điểm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = parts[0];
            double[] scores = new double[parts.Length - 1];

            for (int i = 1; i < parts.Length; i++)
            {
                if (!double.TryParse(parts[i], out double score) || score < 0 || score > 10)
                {
                    MessageBox.Show($"Điểm '{parts[i]}' không hợp lệ (phải là số 0–10).", "Sai format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                scores[i - 1] = score;
            }

            MessageBox.Show("Đã nhập đúng format!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            double avg = scores.Average();
            double max = scores.Max();
            double min = scores.Min();
            int indexMax = Array.IndexOf(scores, max) + 1;
            int indexMin = Array.IndexOf(scores, min) + 1;
            int passCount = scores.Count(s => s >= 5);
            int failCount = scores.Length - passCount;

            string grade;
            if (avg >= 8 && scores.All(s => s >= 6.5))
                grade = "Giỏi";
            else if (avg >= 6.5 && scores.All(s => s >= 5))
                grade = "Khá";
            else if (avg >= 5 && scores.All(s => s >= 3.5))
                grade = "Trung bình";
            else
                grade = "Yếu";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Họ và tên: {name}");
            sb.AppendLine();

            for (int i = 0; i < scores.Length; i++)
            {
                sb.Append($"Môn {i + 1}: {scores[i],5}");
                if ((i + 1) % 3 == 0) sb.AppendLine();
                else sb.Append("    ");
            }

            sb.AppendLine("\n");
            sb.AppendLine($"Điểm trung bình: {avg:F2}");
            sb.AppendLine($"Môn cao nhất: Môn {indexMax} ({max})");
            sb.AppendLine($"Môn thấp nhất: Môn {indexMin} ({min})");
            sb.AppendLine($"Số môn đậu: {passCount}");
            sb.AppendLine($"Số môn rớt: {failCount}");
            sb.AppendLine($"Xếp loại: {grade}");

            lblOutput.Text = sb.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtArray.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtArray_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
