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
    public partial class StudentManagementForm : Form
    {
        private List<Student> students = new List<Student>();
        private int currentPage = 0;

        public StudentManagementForm()
        {
            InitializeComponent();
        }

        private bool ValidateInput(out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(txtBoxFullName.Text))
            {
                errorMessage = "Vui lòng nhập họ và tên!";
                return false;
            }

            if (string.IsNullOrEmpty(txtID.Text))
            {
                errorMessage = "Vui lòng nhập MSSV!";
                return false;
            }

            if (!int.TryParse(txtID.Text, out int id) || txtID.Text.Length != 8)
            {
                errorMessage = "MSSV phải là số nguyên và phải có 8 chữ số!";
                return false;
            }

            string phone = txtBoxPhone.Text.Trim();
            if (string.IsNullOrWhiteSpace(phone) || phone.Length != 10 || !phone.All(char.IsDigit) || !phone.StartsWith("0"))
            {
                errorMessage = "Số điện thoại phải gồm 10 chữ số và bắt đầu bằng số 0!";
                return false;
            }

            if (!float.TryParse(txtBoxScore1.Text, out float score1) || score1 < 0 || score1 > 10)
            {
                errorMessage = "Điểm môn 1 phải từ 0 đến 10!";
                return false;
            }

            if (!float.TryParse(txtBoxScore2.Text, out float score2) || score2 < 0 || score2 > 10)
            {
                errorMessage = "Điểm môn 2 phải từ 0 đến 10!";
                return false;
            }

            if (!float.TryParse(txtBoxScore3.Text, out float score3) || score3 < 0 || score3 > 10)
            {
                errorMessage = "Điểm môn 3 phải từ 0 đến 10!";
                return false;
            }

            return true;
        }

        private void UpdateRichTextBox()
        {
            rtBoxShowTxt.Clear();

            for (int i = 0; i < students.Count; i++)
            {
                var s = students[i];
                rtBoxShowTxt.AppendText($"{s.FullName}\n");
                rtBoxShowTxt.AppendText($"{s.ID}\n");
                rtBoxShowTxt.AppendText($"{s.Phone}\n");
                rtBoxShowTxt.AppendText($"{s.Score1}\n");
                rtBoxShowTxt.AppendText($"{s.Score2}\n");
                rtBoxShowTxt.AppendText($"{s.Score3}\n");
                if (s.Average > 0)
                {
                    rtBoxShowTxt.AppendText($"Điểm TB: {s.Average:F2}\n");
                }
                rtBoxShowTxt.AppendText("\n");
            }
        }

        private void ClearInputFields()
        {
            txtBoxFullName.Clear();
            txtID.Clear();
            txtBoxPhone.Clear();
            txtBoxScore1.Clear();
            txtBoxScore2.Clear();
            txtBoxScore3.Clear();
        }

        private void ClearOutputFields()
        {
            txtBoxPrintFullName.Clear();
            txtBoxPrintID.Clear();
            txtBoxPrintPhone.Clear();
            txtBoxPrintScore1.Clear();
            txtBoxPrintScore2.Clear();
            txtBoxPrintScore3.Clear();
            txtBoxPrintAverage.Clear();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < students.Count - 1)
            {
                currentPage++;
                DisplayCurrentStudent();
                UpdateNavigationButtons();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var student = new Student(
                txtBoxFullName.Text.Trim(),
                int.Parse(txtID.Text),
                txtBoxPhone.Text.Trim(),
                float.Parse(txtBoxScore1.Text),
                float.Parse(txtBoxScore2.Text),
                float.Parse(txtBoxScore3.Text)
            );

            students.Add(student);
            ClearInputFields();
            MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnWriteFileInput_Click(object sender, EventArgs e)
        {
            if (students.Count == 0)
            {
                MessageBox.Show("Chưa có sinh viên nào để ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (StreamWriter writer = new StreamWriter("input4.txt"))
                {
                    foreach (var student in students)
                    {
                        writer.WriteLine($"{student.FullName},{student.ID},{student.Phone},{student.Score1},{student.Score2},{student.Score3}");
                    }
                }
                MessageBox.Show("Ghi file input4.txt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateNavigationButtons()
        {
            btnPrev.Enabled = currentPage > 0;
            btnNext.Enabled = currentPage < students.Count - 1;
            lblPage.Text = students.Count > 0 ? (currentPage + 1).ToString() : "0";
        }

        private void DisplayCurrentStudent()
        {
            if (students.Count == 0)
            {
                ClearOutputFields();
                lblPage.Text = "0";
                return;
            }

            if (currentPage >= 0 && currentPage < students.Count)
            {
                var student = students[currentPage];
                txtBoxPrintFullName.Text = student.FullName;
                txtBoxPrintID.Text = student.ID.ToString();
                txtBoxPrintPhone.Text = student.Phone;
                txtBoxPrintScore1.Text = student.Score1.ToString();
                txtBoxPrintScore2.Text = student.Score2.ToString();
                txtBoxPrintScore3.Text = student.Score3.ToString();
                txtBoxPrintAverage.Text = student.Average > 0 ? student.Average.ToString("F2") : "";
                lblPage.Text = (currentPage + 1).ToString();
            }
        }

        private void btnReadFileInput_Click(object sender, EventArgs e)
        {
            if (!File.Exists("input4.txt"))
            {
                MessageBox.Show("File input4.txt không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                students.Clear();
                string[] lines = File.ReadAllLines("input4.txt");

                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        var student = Student.FromString(line);
                        if (student != null)
                        {
                            students.Add(student);
                        }
                    }
                }

                UpdateRichTextBox();
                currentPage = 0;
                DisplayCurrentStudent();
                UpdateNavigationButtons();
                MessageBox.Show($"Đọc file thành công! Có {students.Count} sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (students.Count == 0)
            {
                MessageBox.Show("Chưa có sinh viên nào để tính điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var student in students)
            {
                student.CalculateAverage();
            }

            DisplayCurrentStudent();
            UpdateRichTextBox();
            MessageBox.Show("Tính điểm trung bình thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnWriteFileOutput_Click(object sender, EventArgs e)
        {
            if (students.Count == 0)
            {
                MessageBox.Show("Chưa có sinh viên nào để ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (students.Any(s => s.Average == 0))
            {
                MessageBox.Show("Vui lòng tính điểm trung bình trước khi ghi file output!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (StreamWriter writer = new StreamWriter("output4.txt"))
                {
                    writer.WriteLine("KẾT QUẢ ĐIỂM TRUNG BÌNH CÁC SINH VIÊN");
                    writer.WriteLine();

                    foreach (var student in students)
                    {
                        writer.WriteLine($"Họ tên: {student.FullName}");
                        writer.WriteLine($"MSSV: {student.ID}");
                        writer.WriteLine($"Số điện thoại: {student.Phone}");
                        writer.WriteLine($"Điểm môn 1: {student.Score1}");
                        writer.WriteLine($"Điểm môn 2: {student.Score2}");
                        writer.WriteLine($"Điểm môn 3: {student.Score3}");
                        writer.WriteLine($"Điểm trung bình: {student.Average:F2}");
                        writer.WriteLine();
                    }
                }
                MessageBox.Show("Ghi file output4.txt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                DisplayCurrentStudent();
                UpdateNavigationButtons();
            }
        }
    }
}
