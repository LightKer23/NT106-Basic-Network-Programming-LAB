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
            listCalculate = new ListBox();
            label3 = new Label();
            txtNumberB = new TextBox();
            txtNumberA = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listCalculate);
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
            // listCalculate
            // 
            listCalculate.FormattingEnabled = true;
            listCalculate.ItemHeight = 18;
            listCalculate.Items.AddRange(new object[] { "Bảng cửu chương", "Tính toán giá trị" });
            listCalculate.Location = new Point(94, 99);
            listCalculate.Name = "listCalculate";
            listCalculate.Size = new Size(227, 22);
            listCalculate.TabIndex = 1;
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
            groupBox2.Font = new Font("Tahoma", 9F);
            groupBox2.Location = new Point(24, 193);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(521, 275);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.FlatAppearance.BorderColor = Color.Blue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 9F);
            button1.Location = new Point(411, 42);
            button1.Name = "button1";
            button1.Size = new Size(134, 46);
            button1.TabIndex = 2;
            button1.Text = "Tính toán giá trị";
            button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Tahoma", 9F);
            button4.Location = new Point(411, 104);
            button4.Name = "button4";
            button4.Size = new Size(134, 46);
            button4.TabIndex = 5;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // MultiplicationTableForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 495);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MultiplicationTableForm";
            Text = "Tính toán giá trị và bảng cửu chương";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtNumberB;
        private TextBox txtNumberA;
        private ListBox listCalculate;
        private Label label3;
        private GroupBox groupBox2;
        private Button button1;
        private Button button4;
    }
}