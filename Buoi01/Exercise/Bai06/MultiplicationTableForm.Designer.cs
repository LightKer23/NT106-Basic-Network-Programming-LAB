namespace Exercise.Bai06
{
    partial class MultiplicationTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiplicationTableForm));
            groupBox1 = new GroupBox();
            cboCalculate = new ComboBox();
            label3 = new Label();
            txtNumberB = new TextBox();
            txtNumberA = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            rtbResult = new RichTextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboCalculate);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNumberB);
            groupBox1.Controls.Add(txtNumberA);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Tahoma", 9F);
            groupBox1.Location = new Point(24, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 143);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập";
            // 
            // cboCalculate
            // 
            cboCalculate.FormattingEnabled = true;
            cboCalculate.Location = new Point(94, 95);
            cboCalculate.Name = "cboCalculate";
            cboCalculate.Size = new Size(227, 26);
            cboCalculate.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 99);
            label3.Name = "label3";
            label3.Size = new Size(68, 18);
            label3.TabIndex = 4;
            label3.Text = "Kiểu tính:";
            // 
            // txtNumberB
            // 
            txtNumberB.Location = new Point(94, 59);
            txtNumberB.Name = "txtNumberB";
            txtNumberB.Size = new Size(227, 26);
            txtNumberB.TabIndex = 3;
            txtNumberB.TextChanged += txtNumberB_TextChanged;
            // 
            // txtNumberA
            // 
            txtNumberA.Location = new Point(94, 27);
            txtNumberA.Name = "txtNumberA";
            txtNumberA.Size = new Size(227, 26);
            txtNumberA.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 61);
            label2.Name = "label2";
            label2.Size = new Size(61, 18);
            label2.TabIndex = 2;
            label2.Text = "Nhập B:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 27);
            label1.Name = "label1";
            label1.Size = new Size(61, 18);
            label1.TabIndex = 1;
            label1.Text = "Nhập A:";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rtbResult);
            groupBox2.Font = new Font("Tahoma", 9F);
            groupBox2.Location = new Point(24, 193);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(521, 275);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // rtbResult
            // 
            rtbResult.BackColor = SystemColors.ButtonHighlight;
            rtbResult.BorderStyle = BorderStyle.FixedSingle;
            rtbResult.Location = new Point(10, 25);
            rtbResult.Name = "rtbResult";
            rtbResult.ReadOnly = true;
            rtbResult.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbResult.Size = new Size(501, 240);
            rtbResult.TabIndex = 0;
            rtbResult.Text = "";
            rtbResult.Click += btnCalculate_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.ButtonHighlight;
            btnCalculate.FlatAppearance.BorderColor = Color.Blue;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Tahoma", 9F);
            btnCalculate.Location = new Point(411, 42);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(134, 46);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Tính toán giá trị";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ButtonHighlight;
            btnExit.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Tahoma", 9F);
            btnExit.Location = new Point(411, 104);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(134, 46);
            btnExit.TabIndex = 5;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // MultiplicationTableForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 495);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MultiplicationTableForm";
            Text = "Tính toán giá trị và bảng cửu chương";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtNumberB;
        private TextBox txtNumberA;
        private Label label3;
        private GroupBox groupBox2;
        private Button btnCalculate;
        private Button btnExit;
        private ComboBox cboCalculate;
        private RichTextBox rtbResult;
    }
}