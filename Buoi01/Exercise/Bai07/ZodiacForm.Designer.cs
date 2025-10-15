namespace Exercise.Bai07
{
    partial class ZodiacForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZodiacForm));
            groupBox1 = new GroupBox();
            txtInput = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnFind = new Button();
            btnExit = new Button();
            label4 = new Label();
            lblOutput = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInput);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Tahoma", 9F);
            groupBox1.Location = new Point(27, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(428, 71);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(217, 25);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(197, 26);
            txtInput.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 27);
            label1.Name = "label1";
            label1.Size = new Size(190, 18);
            label1.TabIndex = 2;
            label1.Text = "Nhập ngày tháng năm sinh:";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblOutput);
            groupBox2.Font = new Font("Tahoma", 9F);
            groupBox2.Location = new Point(27, 115);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(428, 78);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả";
            // 
            // btnFind
            // 
            btnFind.BackColor = SystemColors.ButtonHighlight;
            btnFind.FlatAppearance.BorderColor = Color.Blue;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Tahoma", 9F);
            btnFind.Location = new Point(487, 30);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(99, 36);
            btnFind.TabIndex = 2;
            btnFind.Text = "Tìm";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ButtonHighlight;
            btnExit.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Tahoma", 9F);
            btnExit.Location = new Point(487, 72);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(99, 36);
            btnExit.TabIndex = 3;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Underline);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(493, 147);
            label4.Name = "label4";
            label4.Size = new Size(84, 18);
            label4.TabIndex = 6;
            label4.Text = "NT106.Q14";
            // 
            // lblOutput
            // 
            lblOutput.Location = new Point(21, 25);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(393, 43);
            lblOutput.TabIndex = 0;
            // 
            // ZodiacForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 222);
            Controls.Add(label4);
            Controls.Add(btnExit);
            Controls.Add(btnFind);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ZodiacForm";
            Text = "Cung hoàng đạo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtInput;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnFind;
        private Button btnExit;
        private Label label4;
        private Label lblOutput;
    }
}