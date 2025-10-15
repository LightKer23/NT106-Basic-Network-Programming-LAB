namespace Exercise.Bai02
{
    partial class FindMaxMinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindMaxMinForm));
            btnFind = new Button();
            groupBox2 = new GroupBox();
            lblMin = new Label();
            lblMax = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            txtNumber3 = new TextBox();
            label3 = new Label();
            txtNumber2 = new TextBox();
            txtNumber1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnExit = new Button();
            btnDel = new Button();
            label6 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnFind
            // 
            btnFind.BackColor = SystemColors.ButtonHighlight;
            btnFind.FlatAppearance.BorderColor = Color.Blue;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Tahoma", 9F);
            btnFind.Location = new Point(379, 23);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(99, 36);
            btnFind.TabIndex = 7;
            btnFind.Text = "Tìm";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblMin);
            groupBox2.Controls.Add(lblMax);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Tahoma", 9F);
            groupBox2.Location = new Point(20, 149);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(327, 88);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả:";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // lblMin
            // 
            lblMin.Location = new Point(142, 54);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(168, 25);
            lblMin.TabIndex = 13;
            // 
            // lblMax
            // 
            lblMax.Location = new Point(142, 28);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(168, 25);
            lblMax.TabIndex = 12;
            lblMax.Click += label7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 54);
            label5.Name = "label5";
            label5.Size = new Size(113, 18);
            label5.TabIndex = 11;
            label5.Text = "Giá trị nhỏ nhất:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 28);
            label4.Name = "label4";
            label4.Size = new Size(107, 18);
            label4.TabIndex = 10;
            label4.Text = "Giá trị lớn nhất:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNumber3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNumber2);
            groupBox1.Controls.Add(txtNumber1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Tahoma", 9F);
            groupBox1.Location = new Point(20, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 134);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập";
            // 
            // txtNumber3
            // 
            txtNumber3.Location = new Point(119, 94);
            txtNumber3.Name = "txtNumber3";
            txtNumber3.Size = new Size(180, 26);
            txtNumber3.TabIndex = 5;
            txtNumber3.KeyPress += txtNumber3_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 92);
            label3.Name = "label3";
            label3.Size = new Size(77, 18);
            label3.TabIndex = 4;
            label3.Text = "Số thứ ba:";
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(119, 62);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(180, 26);
            txtNumber2.TabIndex = 3;
            txtNumber2.TextChanged += txtNumber2_TextChanged;
            txtNumber2.KeyPress += txtNumber2_KeyPress;
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(119, 29);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(180, 26);
            txtNumber1.TabIndex = 1;
            txtNumber1.KeyPress += txtNumber1_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 62);
            label2.Name = "label2";
            label2.Size = new Size(79, 18);
            label2.TabIndex = 2;
            label2.Text = "Số thứ hai:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 32);
            label1.Name = "label1";
            label1.Size = new Size(90, 18);
            label1.TabIndex = 1;
            label1.Text = "Số thứ nhất:";
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ButtonHighlight;
            btnExit.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Tahoma", 9F);
            btnExit.Location = new Point(379, 107);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(99, 36);
            btnExit.TabIndex = 8;
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
            btnDel.Location = new Point(379, 65);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(99, 36);
            btnDel.TabIndex = 9;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Underline);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(388, 186);
            label6.Name = "label6";
            label6.Size = new Size(84, 18);
            label6.TabIndex = 10;
            label6.Text = "NT106.Q14";
            // 
            // FindMaxMinForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 256);
            Controls.Add(label6);
            Controls.Add(btnDel);
            Controls.Add(btnExit);
            Controls.Add(btnFind);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FindMaxMinForm";
            Text = "Tìm số lớn nhất, nhỏ nhất";
            Load += FindMaxMinForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnFind;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox txtNumber3;
        private Label label3;
        private TextBox txtNumber2;
        private TextBox txtNumber1;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Button btnExit;
        private Button btnDel;
        private Label label6;
        private Label lblMax;
        private Label lblMin;
    }
}