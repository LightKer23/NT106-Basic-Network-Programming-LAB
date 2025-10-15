using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exercise.Bai06
{
    public partial class MultiplicationTableForm : Form
    {
        public MultiplicationTableForm()
        {
            InitializeComponent();
            LoadComboBoxItems();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNumberB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateInput(out int A, out int B)
        {
            A = 0;
            B = 0;

            if (cboCalculate.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn kiểu tính!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCalculate.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNumberA.Text))
            {
                MessageBox.Show("Vui lòng nhập giá trị A!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumberA.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNumberB.Text))
            {
                MessageBox.Show("Vui lòng nhập giá trị B!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumberB.Focus();
                return false;
            }

            if (!int.TryParse(txtNumberA.Text.Trim(), out A))
            {
                MessageBox.Show("Giá trị A phải là số nguyên hợp lệ!\n" +
                    "Ví dụ: 5, -3, 100",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumberA.Focus();
                txtNumberA.SelectAll();
                return false;
            }

            if (!int.TryParse(txtNumberB.Text.Trim(), out B))
            {
                MessageBox.Show("Giá trị B phải là số nguyên hợp lệ!\n" +
                    "Ví dụ: 5, -3, 100",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumberB.Focus();
                txtNumberB.SelectAll();
                return false;
            }

            return true;
        }

        private bool ValidateBusinessLogic(int A, int B, int calcType)
        {
            switch (calcType)
            {
                case 0:
                    if (A < B)
                    {
                        MessageBox.Show($"Để tạo bảng cửu chương từ B đến A:\n" +
                            $"A ({A}) phải lớn hơn hoặc bằng B ({B})!",
                            "Lỗi logic", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (A - B > 20)
                    {
                        var confirm = MessageBox.Show(
                            $"Sẽ tạo {A - B + 1} bảng cửu chương (từ {B} đến {A}).\n" +
                            "Kết quả có thể rất dài. Bạn có muốn tiếp tục?",
                            "Xác nhận",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
                        if (confirm == DialogResult.No)
                            return false;
                    }
                    break;

                case 1:
                    int factValue = A - B;
                    if (factValue < 0)
                    {
                        MessageBox.Show($"Không thể tính giai thừa của số âm!\n" +
                            $"(A - B)! = ({A} - {B})! = {factValue}!",
                            "Lỗi toán học", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (factValue > 100000)
                    {
                        MessageBox.Show($"Giá trị (A - B) = {factValue} quá lớn!\n" +
                            "Giới hạn: (A - B) ≤ 100000",
                            "Lỗi giới hạn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (factValue > 1000)
                    {
                        var confirm = MessageBox.Show(
                            $"Tính {factValue}! sẽ cho kết quả rất lớn.\n" +
                            "Bạn có muốn tiếp tục?",
                            "Cảnh báo",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                        if (confirm == DialogResult.No)
                            return false;
                    }
                    break;

                case 2:
                    if (B < 0)
                    {
                        MessageBox.Show("B phải là số không âm để tính tổng lũy thừa!\n" +
                            $"B hiện tại: {B}",
                            "Lỗi điều kiện", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (B > 100000)
                    {
                        MessageBox.Show($"Giá trị B = {B} quá lớn!\n" +
                            "Giới hạn: B ≤ 100000",
                            "Lỗi giới hạn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (Math.Abs(A) > 10 && B > 100)
                    {
                        var confirm = MessageBox.Show(
                            $"Với A = {A} và B = {B}, kết quả sẽ rất lớn!\n" +
                            "Bạn có muốn tiếp tục?",
                            "Cảnh báo",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                        if (confirm == DialogResult.No)
                            return false;
                    }
                    break;

                case 3:
                    if (A < B)
                    {
                        MessageBox.Show($"Để tạo bảng cửu chương: A phải ≥ B\n" +
                            $"Hiện tại: A = {A}, B = {B}",
                            "Lỗi logic", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (A - B < 0)
                    {
                        MessageBox.Show($"Không thể tính giai thừa của số âm!\n" +
                            $"(A - B) = {A - B}",
                            "Lỗi toán học", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (B < 0)
                    {
                        MessageBox.Show($"B phải không âm để tính tổng lũy thừa!\n" +
                            $"B = {B}",
                            "Lỗi điều kiện", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if ((A - B > 20) || (A - B > 1000) || (Math.Abs(A) > 10 && B > 100))
                    {
                        var confirm = MessageBox.Show(
                            "Một hoặc nhiều phép tính sẽ cho kết quả rất lớn.\n" +
                            "Bạn có muốn tiếp tục?",
                            "Cảnh báo",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                        if (confirm == DialogResult.No)
                            return false;
                    }
                    break;
            }

            return true;
        }

        private string GenerateMultiplicationTable(int A, int B)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("BẢNG CỬU CHƯƠNG TỪ B ĐẾN A");
            sb.AppendLine($"(Từ {B} đến {A})");
            sb.AppendLine();

            for (int i = B; i <= A; i++)
            {
                sb.AppendLine($"--- Bảng cửu chương {i} ---");
                for (int j = 1; j <= 10; j++)
                {
                    sb.AppendLine($"{i,3} x {j,2} = {i * j,4}");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }

        private string CalculateFactorial(int A, int B)
        {
            int n = A - B;
            StringBuilder sb = new StringBuilder();

            try
            {
                sb.AppendLine("GIAI THỪA");
                sb.AppendLine($"({A} - {B})! = {n}!");
                sb.AppendLine();

                BigInteger factorial = CalculateFactorialValue(n);

                string factorialStr = factorial.ToString();
                sb.AppendLine($"Kết quả có {factorialStr.Length} chữ số");
                sb.AppendLine();

                if (factorialStr.Length > 1000)
                {
                    sb.AppendLine("150 chữ số đầu:");
                    sb.AppendLine(factorialStr.Substring(0, 150));
                    sb.AppendLine("...");
                    sb.AppendLine();
                    sb.AppendLine("150 chữ số cuối:");
                    sb.AppendLine(factorialStr.Substring(factorialStr.Length - 150));
                }
                else
                {
                    sb.AppendLine("Kết quả đầy đủ:");
                    sb.AppendLine(factorialStr);
                }
            }
            catch (Exception ex)
            {
                sb.AppendLine($"Lỗi: {ex.Message}");
            }

            return sb.ToString();
        }

        private BigInteger CalculateFactorialValue(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            BigInteger result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        private string CalculateSum(int A, int B)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("TỔNG LŨY THỪA");
            sb.AppendLine($"S = A^1 + A^2 + A^3 + ... + A^B");
            sb.AppendLine($"S = {A}^1 + {A}^2 + {A}^3 + ... + {A}^{B}");
            sb.AppendLine();

            try
            {
                if (A == 0)
                {
                    sb.AppendLine("Kết quả: S = 0");
                    sb.AppendLine("(Vì 0^i = 0 với mọi i > 0)");
                    return sb.ToString();
                }

                if (A == 1)
                {
                    sb.AppendLine($"Kết quả: S = {B}");
                    sb.AppendLine("(Vì 1^i = 1 với mọi i)");
                    return sb.ToString();
                }

                if (A == -1)
                {
                    int result = B % 2 == 0 ? 0 : -1;
                    sb.AppendLine($"Kết quả: S = {result}");
                    sb.AppendLine("(Vì (-1)^i xen kẽ giữa -1 và 1)");
                    return sb.ToString();
                }

                BigInteger sum = 0;
                for (int i = 1; i <= B; i++)
                {
                    BigInteger power = BigInteger.Pow(A, i);
                    sum += power;
                }

                string sumStr = sum.ToString();
                sb.AppendLine($"Kết quả có {sumStr.Length} chữ số");
                sb.AppendLine();

                if (sumStr.Length > 1000)
                {
                    sb.AppendLine("150 chữ số đầu:");
                    sb.AppendLine(sumStr.Substring(0, 150));
                    sb.AppendLine("...");
                    sb.AppendLine();
                    sb.AppendLine("150 chữ số cuối:");
                    sb.AppendLine(sumStr.Substring(sumStr.Length - 150));
                }
                else
                {
                    sb.AppendLine("Kết quả đầy đủ:");
                    sb.AppendLine(sumStr);
                }
            }
            catch (Exception ex)
            {
                sb.AppendLine($"Lỗi: {ex.Message}");
            }

            return sb.ToString();
        }

        private void LoadComboBoxItems()
        {
            cboCalculate.Items.Clear();
            cboCalculate.Items.Add("Bảng cửu chương (B → A)");
            cboCalculate.Items.Add("Tính toán giá trị");
            cboCalculate.SelectedIndex = 1;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput(out int A, out int B))
                    return;

                int selectedIndex = cboCalculate.SelectedIndex;
                if (!ValidateBusinessLogic(A, B, selectedIndex))
                    return;

                StringBuilder result = new StringBuilder();
                result.AppendLine($"A = {A}, B = {B}");
                result.AppendLine(new string('=', 60));
                result.AppendLine();

                switch (selectedIndex)
                {
                    case 0:
                        result.Append(GenerateMultiplicationTable(A, B));
                        break;
                    case 1:
                        result.Append(CalculateFactorial(A, B));
                        result.AppendLine("\n" + new string('=', 43) + "\n");
                        result.Append(CalculateSum(A, B));
                        break;
                }

                rtbResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi không xác định: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back &&
                e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '-')
            {
                if (txt.SelectionStart != 0 || txt.Text.Contains("-"))
                {
                    e.Handled = true;
                }
            }
        }

        private void cboCalculate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rtbResult != null)
                rtbResult.Clear();
        }
    }
}
