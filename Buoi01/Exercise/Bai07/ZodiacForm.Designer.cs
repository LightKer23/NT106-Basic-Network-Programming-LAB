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
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Tahoma", 9F);
            groupBox1.Location = new Point(27, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(428, 71);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(217, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 26);
            textBox1.TabIndex = 2;
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
            groupBox2.Font = new Font("Tahoma", 9F);
            groupBox2.Location = new Point(27, 115);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(428, 78);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.FlatAppearance.BorderColor = Color.Blue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 9F);
            button1.Location = new Point(487, 30);
            button1.Name = "button1";
            button1.Size = new Size(99, 36);
            button1.TabIndex = 2;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 9F);
            button2.Location = new Point(487, 72);
            button2.Name = "button2";
            button2.Size = new Size(99, 36);
            button2.TabIndex = 3;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            // ZodiacForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 222);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ZodiacForm";
            Text = "Cung hoàng đạo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
        private Label label4;
    }
}