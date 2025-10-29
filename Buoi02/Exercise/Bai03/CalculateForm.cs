using Microsoft.EntityFrameworkCore.Query.Internal;
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
    public partial class CalculateForm : Form
    {
        private bool check;
        public CalculateForm()
        {
            InitializeComponent();
            check = true;
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists("input3.txt"))
            {
                MessageBox.Show("File input3.txt không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
                return;
            }

            string expression = File.ReadAllText("input3.txt").Trim();

            if (string.IsNullOrWhiteSpace(expression))
            {
                MessageBox.Show("File rỗng hoặc không có biểu thức hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
                return;
            }

            if (!expression.All(c => char.IsDigit(c) || "+-*/(). ".Contains(c)) || !IsParenthesesBalanced(expression))
            {
                MessageBox.Show("Biểu thức không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
                return;
            }

            check = true;
            rtBoxOutput.Text = expression;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtBoxOutput.Text))
            {
                MessageBox.Show("Vui lòng đọc file trước!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                check = true;
                double result = EvaluateInfix(rtBoxOutput.Text);

                if (result - (int)result > 0)
                    result = Math.Round(result, 2);

                rtBoxOutput.Text = $"{rtBoxOutput.Text} = {result}";
            }
            catch (Exception ex)
            {
                check = false;
                MessageBox.Show("Biểu thức không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtBoxOutput.Text))
            {
                MessageBox.Show("Không có nội dung để ghi vào file!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!check)
            {
                MessageBox.Show("Biểu thức không hợp lệ để ghi file!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string outputPath = Path.Combine(Application.StartupPath, "output3.txt");
            File.WriteAllText(outputPath, rtBoxOutput.Text);
            MessageBox.Show("Đã ghi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int Priority(string op)
        {
            return (op == "+" || op == "-") ? 1 :
                   (op == "*" || op == "/") ? 2 : 0;
        }

        private bool IsParenthesesBalanced(string expr)
        {
            Stack<char> st = new Stack<char>();
            foreach (char c in expr)
            {
                if (c == '(') st.Push(c);
                else if (c == ')')
                {
                    if (st.Count == 0) 
                        return false;
                    st.Pop();
                }
            }
            return st.Count == 0;
        }
        private double EvaluateInfix(string expression)
        {
            List<string> postfix = InfixToPostfix(expression);
            Stack<double> stack = new Stack<double>();

            foreach (var token in postfix)
            {
                if (double.TryParse(token, out double num))
                    stack.Push(num);
                else
                {
                    double b = stack.Pop();
                    double a = stack.Pop();
                    
                    if (b == 0 && token == "/")
                        throw new DivideByZeroException("Chia cho 0 không hợp lệ.");

                    switch (token)
                    {
                        case "+": stack.Push(a + b); break;
                        case "-": stack.Push(a - b); break;
                        case "*": stack.Push(a * b); break;
                        case "/": stack.Push(a / b); break;
                    }
                }
            }
            return stack.Pop();
        }

        private List<string> InfixToPostfix(string expression)
        {
            Stack<string> ops = new Stack<string>();
            List<string> output = new List<string>();
            string number = "";
            char prev = '\0';

            foreach (char c in expression)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    number += c;
                }
                else
                {
                    if (c == '-' && (prev == '\0' || "+-*/( ".Contains(prev)))
                    {
                        number = "-";
                    }
                    else
                    {
                        if (number != "")
                        {
                            output.Add(number);
                            number = "";
                        }

                        if (c == ' ') 
                            continue;

                        if (c == '(') 
                            ops.Push(c.ToString());
                        else if (c == ')')
                        {
                            while (ops.Peek() != "(")
                                output.Add(ops.Pop());
                            ops.Pop();
                        }
                        else
                        {
                            while (ops.Count > 0 && Priority(ops.Peek()) >= Priority(c.ToString()))
                                output.Add(ops.Pop());
                            ops.Push(c.ToString());
                        }
                    }
                }
                prev = c;
            }

            if (number != "")
                output.Add(number);

            while (ops.Count > 0)
                output.Add(ops.Pop());

            return output;
        }
    }
}
