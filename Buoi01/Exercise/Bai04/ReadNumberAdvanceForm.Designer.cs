namespace Exercise.Bai04
{
    partial class ReadNumberAdvanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadNumberAdvanceForm));
            label6 = new Label();
            button1 = new Button();
            btnRead = new Button();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            txtNumber = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Underline);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(550, 135);
            label6.Name = "label6";
            label6.Size = new Size(84, 18);
            label6.TabIndex = 16;
            label6.Text = "NT106.Q14";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 9F);
            button1.Location = new Point(542, 71);
            button1.Name = "button1";
            button1.Size = new Size(99, 36);
            button1.TabIndex = 15;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnRead
            // 
            btnRead.BackColor = SystemColors.ButtonHighlight;
            btnRead.FlatAppearance.BorderColor = Color.Blue;
            btnRead.FlatStyle = FlatStyle.Flat;
            btnRead.Font = new Font("Tahoma", 9F);
            btnRead.Location = new Point(542, 29);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(99, 36);
            btnRead.TabIndex = 14;
            btnRead.Text = "Đọc";
            btnRead.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Font = new Font("Tahoma", 9F);
            groupBox2.Location = new Point(31, 111);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(482, 58);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNumber);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Tahoma", 9F);
            groupBox1.Location = new Point(31, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(482, 77);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(277, 30);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(187, 26);
            txtNumber.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 33);
            label1.Name = "label1";
            label1.Size = new Size(251, 18);
            label1.TabIndex = 1;
            label1.Text = "Nhập số nguyên có ít hơn 12 chữ số:";
            // 
            // ReadNumberAdvanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 191);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(btnRead);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReadNumberAdvanceForm";
            Text = "Đọc số nâng cao";
            Load += ReadNumberAdvanceForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Button button1;
        private Button btnRead;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox txtNumber;
        private Label label1;
    }
}