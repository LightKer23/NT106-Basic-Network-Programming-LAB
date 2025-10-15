namespace Exercise.Bai03
{
    partial class ReadNumberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadNumberForm));
            btnRead = new Button();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            txtNumber = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.BackColor = SystemColors.ButtonHighlight;
            btnRead.FlatAppearance.BorderColor = Color.Blue;
            btnRead.FlatStyle = FlatStyle.Flat;
            btnRead.Font = new Font("Tahoma", 9F);
            btnRead.Location = new Point(457, 26);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(99, 36);
            btnRead.TabIndex = 7;
            btnRead.Text = "Đọc";
            btnRead.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Font = new Font("Tahoma", 9F);
            groupBox2.Location = new Point(24, 98);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(398, 58);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả:";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNumber);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Tahoma", 9F);
            groupBox1.Location = new Point(24, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(398, 77);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(221, 30);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(160, 26);
            txtNumber.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 33);
            label1.Name = "label1";
            label1.Size = new Size(195, 18);
            label1.TabIndex = 1;
            label1.Text = "Nhập số nguyên từ 0 đến 9:";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 9F);
            button1.Location = new Point(457, 68);
            button1.Name = "button1";
            button1.Size = new Size(99, 36);
            button1.TabIndex = 8;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Underline);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(463, 121);
            label6.Name = "label6";
            label6.Size = new Size(84, 18);
            label6.TabIndex = 11;
            label6.Text = "NT106.Q14";
            // 
            // ReadNumberForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 175);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(btnRead);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReadNumberForm";
            Text = "Đọc số";
            Load += ReadNumberForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRead;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox txtNumber;
        private Label label1;
        private Button button1;
        private Label label6;
    }
}