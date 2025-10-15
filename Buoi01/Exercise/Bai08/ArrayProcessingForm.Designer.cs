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
            txtArray = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblOutput = new Label();
            btnPrint = new Button();
            btnExit = new Button();
            btnDel = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtArray);
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
            // txtArray
            // 
            txtArray.Location = new Point(212, 33);
            txtArray.Name = "txtArray";
            txtArray.Size = new Size(229, 26);
            txtArray.TabIndex = 2;
            txtArray.TextChanged += txtArray_TextChanged;
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
            groupBox2.Controls.Add(lblOutput);
            groupBox2.Font = new Font("Tahoma", 9F);
            groupBox2.Location = new Point(26, 173);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(465, 328);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sinh viên";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // lblOutput
            // 
            lblOutput.Dock = DockStyle.Fill;
            lblOutput.Location = new Point(3, 22);
            lblOutput.Name = "lblOutput";
            lblOutput.Padding = new Padding(10);
            lblOutput.Size = new Size(459, 303);
            lblOutput.TabIndex = 0;
            lblOutput.Text = "Thông tin sẽ hiển thị tại đây...";
            // 
            // btnPrint
            // 
            btnPrint.BackColor = SystemColors.ButtonHighlight;
            btnPrint.FlatAppearance.BorderColor = Color.Blue;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Tahoma", 9F);
            btnPrint.Location = new Point(515, 34);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(99, 36);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "In thông tin";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ButtonHighlight;
            btnExit.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Tahoma", 9F);
            btnExit.Location = new Point(515, 121);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(99, 36);
            btnExit.TabIndex = 5;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = SystemColors.ButtonHighlight;
            btnDel.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Font = new Font("Tahoma", 9F);
            btnDel.Location = new Point(515, 78);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(99, 36);
            btnDel.TabIndex = 6;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // ArrayProcessingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 518);
            Controls.Add(btnDel);
            Controls.Add(btnExit);
            Controls.Add(btnPrint);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ArrayProcessingForm";
            Text = "Quản lí điểm sinh viên";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtArray;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private Button btnPrint;
        private Button btnExit;
        private Button btnDel;
        private Label lblOutput;
    }
}