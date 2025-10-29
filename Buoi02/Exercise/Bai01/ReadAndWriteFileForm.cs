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
    public partial class ReadAndWriteFileForm : Form
    {
        public ReadAndWriteFileForm()
        {
            InitializeComponent();
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists("input1.txt"))
            {
                MessageBox.Show("File input1.txt không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string content = File.ReadAllText("input1.txt");
            rtBoxOutput.Text = content;
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(rtBoxOutput.Text))
            {
                MessageBox.Show("Không có nội dung để ghi vào file!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            File.WriteAllText("output1.txt", rtBoxOutput.Text.ToUpper());
            MessageBox.Show("Đã ghi nội dung vào file output1.txt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
