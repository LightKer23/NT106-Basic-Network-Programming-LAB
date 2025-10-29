using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise.Bai02
{
    public partial class ReadFiletxtForm : Form
    {
        public ReadFiletxtForm()
        {
            InitializeComponent();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.Title = "Chọn file cần đọc";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    string content = sr.ReadToEnd();

                    fs.Seek(0, SeekOrigin.Begin);
                    string[] lines = File.ReadAllLines(fs.Name);
                    int lineCount = lines.Length;
                    int wordCount = content.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
                    int charCount = content.Length;

                    FileInfo fileInfo = new FileInfo(fs.Name);
                    long fileSize = fileInfo.Length;

                    txtBoxFIleName.Text = ofd.SafeFileName;
                    txtBoxSize.Text = $"{fileSize} bytes";
                    txtBoxURL.Text = fs.Name;
                    txtBoxLine.Text = lineCount.ToString();
                    txtBoxWord.Text = wordCount.ToString();
                    txtBoxChar.Text = charCount.ToString();

                    rtBoxOutput.Text = content;

                    sr.Close();
                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
