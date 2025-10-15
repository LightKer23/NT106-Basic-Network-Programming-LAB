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
            lblOutput = new Label();
            groupBox1 = new GroupBox();
            txtNumber = new TextBox();
            label1 = new Label();
            btnExit = new Button();
            label6 = new Label();
            groupBox2.SuspendLayout();
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
            btnRead.Click += btnRead_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblOutput);
            groupBox2.Font = new Font("Tahoma", 9F);
            groupBox2.Location = new Point(24, 98);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(398, 58);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả:";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // lblOutput
            // 
            lblOutput.Location = new Point(72, 22);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(309, 25);
            lblOutput.TabIndex = 0;
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
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ButtonHighlight;
            btnExit.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Tahoma", 9F);
            btnExit.Location = new Point(457, 68);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(99, 36);
            btnExit.TabIndex = 8;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
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
            Controls.Add(btnExit);
            Controls.Add(btnRead);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReadNumberForm";
            Text = "Đọc số";
            Load += ReadNumberForm_Load;
            groupBox2.ResumeLayout(false);
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
        private Button btnExit;
        private Label label6;
        private Label lblOutput;
    }
}