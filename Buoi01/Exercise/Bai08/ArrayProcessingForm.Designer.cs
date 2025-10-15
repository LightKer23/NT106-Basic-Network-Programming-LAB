namespace Exercise.Bai08
{
    partial class ArrayProcessingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArrayProcessingForm));
            groupBox1 = new GroupBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Tahoma", 9F);
            groupBox1.Location = new Point(26, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(465, 134);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7F, FontStyle.Italic);
            label2.Location = new Point(217, 72);
            label2.Name = "label2";
            label2.Size = new Size(224, 45);
            label2.TabIndex = 3;
            label2.Text = "Theo định dạng (Họ và tên, Điểm môn 1,\r\nĐiểm môn 2,...) cách nhau bởi dấu phẩy. \r\nVí dụ: Nguyễn Thị A, 7.5, 5, 8, 10, 9,10, 8.5\r\n";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(212, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 26);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 33);
            label1.Name = "label1";
            label1.Size = new Size(152, 18);
            label1.TabIndex = 2;
            label1.Text = "Nhập họ tên và điểm:";
            // 
            // groupBox2
            // 
            groupBox2.Font = new Font("Tahoma", 9F);
            groupBox2.Location = new Point(26, 173);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(465, 328);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sinh viên";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.FlatAppearance.BorderColor = Color.Blue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 9F);
            button1.Location = new Point(515, 34);
            button1.Name = "button1";
            button1.Size = new Size(99, 36);
            button1.TabIndex = 2;
            button1.Text = "In thông tin";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Tahoma", 9F);
            button4.Location = new Point(515, 121);
            button4.Name = "button4";
            button4.Size = new Size(99, 36);
            button4.TabIndex = 5;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonHighlight;
            button5.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Tahoma", 9F);
            button5.Location = new Point(515, 78);
            button5.Name = "button5";
            button5.Size = new Size(99, 36);
            button5.TabIndex = 6;
            button5.Text = "Xóa";
            button5.UseVisualStyleBackColor = false;
            // 
            // ArrayProcessingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 518);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ArrayProcessingForm";
            Text = "Quản lí điểm sinh viên";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private Button button1;
        private Button button4;
        private Button button5;
    }
}