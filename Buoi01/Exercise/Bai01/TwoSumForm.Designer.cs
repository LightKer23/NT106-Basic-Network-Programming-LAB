namespace Exercise.Bai01
{
    partial class TwoSumForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TwoSumForm));
            groupBox1 = new GroupBox();
            txtNumber2 = new TextBox();
            txtNumber1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblResult = new Label();
            btnCalcul = new Button();
            btnDel = new Button();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNumber2);
            groupBox1.Controls.Add(txtNumber1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Tahoma", 9F);
            groupBox1.Location = new Point(24, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(341, 98);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Số hạng";
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(131, 58);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(180, 26);
            txtNumber2.TabIndex = 3;
            txtNumber2.TextAlign = HorizontalAlignment.Right;
            txtNumber2.TextChanged += textBox2_TextChanged;
            txtNumber2.KeyPress += txtNumber2_KeyPress;
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(131, 24);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(180, 26);
            txtNumber1.TabIndex = 1;
            txtNumber1.TextAlign = HorizontalAlignment.Right;
            txtNumber1.TextChanged += txtNumber1_TextChanged;
            txtNumber1.KeyPress += txtNumber1_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 61);
            label2.Name = "label2";
            label2.Size = new Size(79, 18);
            label2.TabIndex = 2;
            label2.Text = "Số thứ hai:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 28);
            label1.Name = "label1";
            label1.Size = new Size(90, 18);
            label1.TabIndex = 1;
            label1.Text = "Số thứ nhất:";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblResult);
            groupBox2.Font = new Font("Tahoma", 9F);
            groupBox2.Location = new Point(24, 122);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(341, 51);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tổng";
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Tahoma", 9F);
            lblResult.ForeColor = SystemColors.ActiveCaptionText;
            lblResult.Location = new Point(11, 22);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(300, 18);
            lblResult.TabIndex = 0;
            lblResult.Text = "0";
            lblResult.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCalcul
            // 
            btnCalcul.BackColor = SystemColors.ButtonHighlight;
            btnCalcul.FlatAppearance.BorderColor = Color.Blue;
            btnCalcul.FlatStyle = FlatStyle.Flat;
            btnCalcul.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcul.Location = new Point(396, 25);
            btnCalcul.Name = "btnCalcul";
            btnCalcul.Size = new Size(99, 36);
            btnCalcul.TabIndex = 2;
            btnCalcul.Text = "Tính";
            btnCalcul.UseVisualStyleBackColor = false;
            btnCalcul.Click += btnCalcul_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = SystemColors.ButtonHighlight;
            btnDel.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Location = new Point(396, 68);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(99, 36);
            btnDel.TabIndex = 4;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Underline);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(406, 143);
            label4.Name = "label4";
            label4.Size = new Size(84, 18);
            label4.TabIndex = 5;
            label4.Text = "NT106.Q14";
            // 
            // TwoSumForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 195);
            Controls.Add(label4);
            Controls.Add(btnDel);
            Controls.Add(btnCalcul);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Tahoma", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TwoSumForm";
            Text = "Tính tổng hai số nguyên";
            FormClosing += TwoSumForm_FormClosing;
            FormClosed += TwoSumForm_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private GroupBox groupBox2;
        private Button btnCalcul;
        private Button btnDel;
        private Label lblResult;
        private Label label4;
    }
}