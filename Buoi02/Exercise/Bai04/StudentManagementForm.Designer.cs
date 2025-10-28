namespace Exercise.Bai04
{
    partial class StudentManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentManagementForm));
            grpBoxInput = new GroupBox();
            txtID = new TextBox();
            txtBoxPhone = new TextBox();
            txtBoxScore3 = new TextBox();
            txtBoxScore2 = new TextBox();
            txtBoxScore1 = new TextBox();
            txtBoxFullName = new TextBox();
            lblID = new Label();
            lblPhone = new Label();
            lblScore1 = new Label();
            lblScore2 = new Label();
            lblScore3 = new Label();
            lblFullName = new Label();
            grpBoxOutput = new GroupBox();
            txtBoxPrintAverage = new TextBox();
            label7 = new Label();
            txtBoxPrintID = new TextBox();
            txtBoxPrintPhone = new TextBox();
            txtBoxPrintScore3 = new TextBox();
            txtBoxPrintScore2 = new TextBox();
            txtBoxPrintScore1 = new TextBox();
            txtBoxPrintFullName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            richTextBox1 = new RichTextBox();
            btnWriteFileInput = new Button();
            btnReadFileInput = new Button();
            btnAdd = new Button();
            lblPage = new Label();
            btnNext = new Button();
            btnPrev = new Button();
            lblNotes = new Label();
            btnCalculate = new Button();
            btnWriteFileOutput = new Button();
            grpBoxInput.SuspendLayout();
            grpBoxOutput.SuspendLayout();
            SuspendLayout();
            // 
            // grpBoxInput
            // 
            grpBoxInput.Controls.Add(txtID);
            grpBoxInput.Controls.Add(txtBoxPhone);
            grpBoxInput.Controls.Add(txtBoxScore3);
            grpBoxInput.Controls.Add(txtBoxScore2);
            grpBoxInput.Controls.Add(txtBoxScore1);
            grpBoxInput.Controls.Add(txtBoxFullName);
            grpBoxInput.Controls.Add(lblID);
            grpBoxInput.Controls.Add(lblPhone);
            grpBoxInput.Controls.Add(lblScore1);
            grpBoxInput.Controls.Add(lblScore2);
            grpBoxInput.Controls.Add(lblScore3);
            grpBoxInput.Controls.Add(lblFullName);
            grpBoxInput.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpBoxInput.Location = new Point(25, 22);
            grpBoxInput.Name = "grpBoxInput";
            grpBoxInput.Size = new Size(353, 210);
            grpBoxInput.TabIndex = 1;
            grpBoxInput.TabStop = false;
            grpBoxInput.Text = "Nhập";
            // 
            // txtID
            // 
            txtID.Location = new Point(135, 50);
            txtID.Name = "txtID";
            txtID.Size = new Size(202, 26);
            txtID.TabIndex = 11;
            // 
            // txtBoxPhone
            // 
            txtBoxPhone.Location = new Point(135, 80);
            txtBoxPhone.Name = "txtBoxPhone";
            txtBoxPhone.Size = new Size(202, 26);
            txtBoxPhone.TabIndex = 10;
            // 
            // txtBoxScore3
            // 
            txtBoxScore3.Location = new Point(135, 170);
            txtBoxScore3.Name = "txtBoxScore3";
            txtBoxScore3.Size = new Size(202, 26);
            txtBoxScore3.TabIndex = 9;
            // 
            // txtBoxScore2
            // 
            txtBoxScore2.Location = new Point(135, 140);
            txtBoxScore2.Name = "txtBoxScore2";
            txtBoxScore2.Size = new Size(202, 26);
            txtBoxScore2.TabIndex = 8;
            // 
            // txtBoxScore1
            // 
            txtBoxScore1.Location = new Point(135, 110);
            txtBoxScore1.Name = "txtBoxScore1";
            txtBoxScore1.Size = new Size(202, 26);
            txtBoxScore1.TabIndex = 7;
            // 
            // txtBoxFullName
            // 
            txtBoxFullName.Location = new Point(135, 20);
            txtBoxFullName.Name = "txtBoxFullName";
            txtBoxFullName.Size = new Size(202, 26);
            txtBoxFullName.TabIndex = 2;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.Location = new Point(20, 50);
            lblID.Name = "lblID";
            lblID.Size = new Size(50, 18);
            lblID.TabIndex = 6;
            lblID.Text = "MSSV:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(20, 80);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(97, 18);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Số điện thoại:";
            // 
            // lblScore1
            // 
            lblScore1.AutoSize = true;
            lblScore1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScore1.Location = new Point(20, 110);
            lblScore1.Name = "lblScore1";
            lblScore1.Size = new Size(93, 18);
            lblScore1.TabIndex = 4;
            lblScore1.Text = "Điểm môn 1:";
            // 
            // lblScore2
            // 
            lblScore2.AutoSize = true;
            lblScore2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScore2.Location = new Point(20, 140);
            lblScore2.Name = "lblScore2";
            lblScore2.Size = new Size(93, 18);
            lblScore2.TabIndex = 3;
            lblScore2.Text = "Điểm môn 2:";
            // 
            // lblScore3
            // 
            lblScore3.AutoSize = true;
            lblScore3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScore3.Location = new Point(20, 170);
            lblScore3.Name = "lblScore3";
            lblScore3.Size = new Size(93, 18);
            lblScore3.TabIndex = 2;
            lblScore3.Text = "Điểm môn 3:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(20, 20);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(78, 18);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Họ và tên:";
            // 
            // grpBoxOutput
            // 
            grpBoxOutput.BackColor = SystemColors.ButtonFace;
            grpBoxOutput.Controls.Add(txtBoxPrintAverage);
            grpBoxOutput.Controls.Add(label7);
            grpBoxOutput.Controls.Add(txtBoxPrintID);
            grpBoxOutput.Controls.Add(txtBoxPrintPhone);
            grpBoxOutput.Controls.Add(txtBoxPrintScore3);
            grpBoxOutput.Controls.Add(txtBoxPrintScore2);
            grpBoxOutput.Controls.Add(txtBoxPrintScore1);
            grpBoxOutput.Controls.Add(txtBoxPrintFullName);
            grpBoxOutput.Controls.Add(label1);
            grpBoxOutput.Controls.Add(label2);
            grpBoxOutput.Controls.Add(label3);
            grpBoxOutput.Controls.Add(label4);
            grpBoxOutput.Controls.Add(label5);
            grpBoxOutput.Controls.Add(label6);
            grpBoxOutput.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpBoxOutput.Location = new Point(25, 336);
            grpBoxOutput.Name = "grpBoxOutput";
            grpBoxOutput.Size = new Size(353, 249);
            grpBoxOutput.TabIndex = 2;
            grpBoxOutput.TabStop = false;
            grpBoxOutput.Text = "Kết quả";
            // 
            // txtBoxPrintAverage
            // 
            txtBoxPrintAverage.BackColor = SystemColors.ControlLight;
            txtBoxPrintAverage.Location = new Point(135, 200);
            txtBoxPrintAverage.Name = "txtBoxPrintAverage";
            txtBoxPrintAverage.ReadOnly = true;
            txtBoxPrintAverage.Size = new Size(202, 26);
            txtBoxPrintAverage.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 200);
            label7.Name = "label7";
            label7.Size = new Size(70, 18);
            label7.TabIndex = 12;
            label7.Text = "Điểm TB:";
            // 
            // txtBoxPrintID
            // 
            txtBoxPrintID.BackColor = SystemColors.ControlLight;
            txtBoxPrintID.Location = new Point(135, 50);
            txtBoxPrintID.Name = "txtBoxPrintID";
            txtBoxPrintID.ReadOnly = true;
            txtBoxPrintID.Size = new Size(202, 26);
            txtBoxPrintID.TabIndex = 11;
            // 
            // txtBoxPrintPhone
            // 
            txtBoxPrintPhone.BackColor = SystemColors.ControlLight;
            txtBoxPrintPhone.Location = new Point(135, 80);
            txtBoxPrintPhone.Name = "txtBoxPrintPhone";
            txtBoxPrintPhone.ReadOnly = true;
            txtBoxPrintPhone.Size = new Size(202, 26);
            txtBoxPrintPhone.TabIndex = 10;
            // 
            // txtBoxPrintScore3
            // 
            txtBoxPrintScore3.BackColor = SystemColors.ControlLight;
            txtBoxPrintScore3.Location = new Point(135, 170);
            txtBoxPrintScore3.Name = "txtBoxPrintScore3";
            txtBoxPrintScore3.ReadOnly = true;
            txtBoxPrintScore3.Size = new Size(202, 26);
            txtBoxPrintScore3.TabIndex = 9;
            // 
            // txtBoxPrintScore2
            // 
            txtBoxPrintScore2.BackColor = SystemColors.ControlLight;
            txtBoxPrintScore2.Location = new Point(135, 140);
            txtBoxPrintScore2.Name = "txtBoxPrintScore2";
            txtBoxPrintScore2.ReadOnly = true;
            txtBoxPrintScore2.Size = new Size(202, 26);
            txtBoxPrintScore2.TabIndex = 8;
            // 
            // txtBoxPrintScore1
            // 
            txtBoxPrintScore1.BackColor = SystemColors.ControlLight;
            txtBoxPrintScore1.Location = new Point(135, 110);
            txtBoxPrintScore1.Name = "txtBoxPrintScore1";
            txtBoxPrintScore1.ReadOnly = true;
            txtBoxPrintScore1.Size = new Size(202, 26);
            txtBoxPrintScore1.TabIndex = 7;
            // 
            // txtBoxPrintFullName
            // 
            txtBoxPrintFullName.BackColor = SystemColors.ControlLight;
            txtBoxPrintFullName.Location = new Point(135, 20);
            txtBoxPrintFullName.Name = "txtBoxPrintFullName";
            txtBoxPrintFullName.ReadOnly = true;
            txtBoxPrintFullName.Size = new Size(202, 26);
            txtBoxPrintFullName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 50);
            label1.Name = "label1";
            label1.Size = new Size(50, 18);
            label1.TabIndex = 6;
            label1.Text = "MSSV:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 80);
            label2.Name = "label2";
            label2.Size = new Size(97, 18);
            label2.TabIndex = 5;
            label2.Text = "Số điện thoại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 110);
            label3.Name = "label3";
            label3.Size = new Size(93, 18);
            label3.TabIndex = 4;
            label3.Text = "Điểm môn 1:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 140);
            label4.Name = "label4";
            label4.Size = new Size(93, 18);
            label4.TabIndex = 3;
            label4.Text = "Điểm môn 2:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 170);
            label5.Name = "label5";
            label5.Size = new Size(93, 18);
            label5.TabIndex = 2;
            label5.Text = "Điểm môn 3:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(20, 20);
            label6.Name = "label6";
            label6.Size = new Size(78, 18);
            label6.TabIndex = 1;
            label6.Text = "Họ và tên:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(417, 33);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(350, 371);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // btnWriteFileInput
            // 
            btnWriteFileInput.BackColor = SystemColors.ButtonHighlight;
            btnWriteFileInput.FlatAppearance.BorderColor = Color.Blue;
            btnWriteFileInput.FlatStyle = FlatStyle.Flat;
            btnWriteFileInput.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWriteFileInput.Location = new Point(173, 236);
            btnWriteFileInput.Name = "btnWriteFileInput";
            btnWriteFileInput.Size = new Size(205, 40);
            btnWriteFileInput.TabIndex = 4;
            btnWriteFileInput.Text = "Ghi vào File \"input4.txt\"";
            btnWriteFileInput.UseVisualStyleBackColor = false;
            // 
            // btnReadFileInput
            // 
            btnReadFileInput.BackColor = SystemColors.ButtonHighlight;
            btnReadFileInput.FlatStyle = FlatStyle.Flat;
            btnReadFileInput.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReadFileInput.Location = new Point(417, 416);
            btnReadFileInput.Name = "btnReadFileInput";
            btnReadFileInput.Size = new Size(170, 40);
            btnReadFileInput.TabIndex = 5;
            btnReadFileInput.Text = "Đọc File \"input4.txt\"";
            btnReadFileInput.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ButtonHighlight;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(25, 236);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(140, 40);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // lblPage
            // 
            lblPage.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPage.Location = new Point(188, 597);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(32, 24);
            lblPage.TabIndex = 7;
            lblPage.Text = "0";
            lblPage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.BackColor = SystemColors.ButtonHighlight;
            btnNext.FlatAppearance.BorderColor = Color.Black;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(287, 591);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(91, 30);
            btnNext.TabIndex = 8;
            btnNext.Text = "Tiếp theo>";
            btnNext.TextAlign = ContentAlignment.MiddleRight;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.BackColor = SystemColors.ButtonHighlight;
            btnPrev.FlatAppearance.BorderColor = Color.Black;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrev.Location = new Point(25, 591);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(90, 30);
            btnPrev.TabIndex = 9;
            btnPrev.Text = "<Trước đó";
            btnPrev.TextAlign = ContentAlignment.MiddleLeft;
            btnPrev.UseVisualStyleBackColor = false;
            // 
            // lblNotes
            // 
            lblNotes.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotes.Location = new Point(417, 524);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(353, 61);
            lblNotes.TabIndex = 10;
            lblNotes.Text = "Chú thích:\r\nTính điểm TB: tính điểm trung bình và sẽ xuất ra \"Kết quả\"";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.ButtonHighlight;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(600, 416);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(170, 40);
            btnCalculate.TabIndex = 11;
            btnCalculate.Text = "Tính điểm TB";
            btnCalculate.UseVisualStyleBackColor = false;
            // 
            // btnWriteFileOutput
            // 
            btnWriteFileOutput.BackColor = SystemColors.ButtonHighlight;
            btnWriteFileOutput.FlatStyle = FlatStyle.Flat;
            btnWriteFileOutput.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWriteFileOutput.Location = new Point(417, 468);
            btnWriteFileOutput.Name = "btnWriteFileOutput";
            btnWriteFileOutput.Size = new Size(353, 40);
            btnWriteFileOutput.TabIndex = 12;
            btnWriteFileOutput.Text = "Ghi vào File \"output4.txt\"";
            btnWriteFileOutput.UseVisualStyleBackColor = false;
            // 
            // StudentManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 641);
            Controls.Add(btnWriteFileOutput);
            Controls.Add(btnCalculate);
            Controls.Add(lblNotes);
            Controls.Add(btnPrev);
            Controls.Add(btnNext);
            Controls.Add(lblPage);
            Controls.Add(btnAdd);
            Controls.Add(btnReadFileInput);
            Controls.Add(btnWriteFileInput);
            Controls.Add(richTextBox1);
            Controls.Add(grpBoxOutput);
            Controls.Add(grpBoxInput);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StudentManagementForm";
            Text = "Quản lí sinh viên";
            grpBoxInput.ResumeLayout(false);
            grpBoxInput.PerformLayout();
            grpBoxOutput.ResumeLayout(false);
            grpBoxOutput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxInput;
        private Label lblID;
        private Label lblPhone;
        private Label lblScore1;
        private Label lblScore2;
        private Label lblScore3;
        private Label lblFullName;
        private TextBox txtBoxFullName;
        private TextBox txtID;
        private TextBox txtBoxPhone;
        private TextBox txtBoxScore3;
        private TextBox txtBoxScore2;
        private TextBox txtBoxScore1;
        private GroupBox grpBoxOutput;
        private TextBox txtBoxPrintID;
        private TextBox txtBoxPrintPhone;
        private TextBox txtBoxPrintScore3;
        private TextBox txtBoxPrintScore2;
        private TextBox txtBoxPrintScore1;
        private TextBox txtBoxPrintFullName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtBoxPrintAverage;
        private Label label7;
        private RichTextBox richTextBox1;
        private Button btnWriteFileInput;
        private Button btnReadFileInput;
        private Button btnAdd;
        private Label lblPage;
        private Button btnNext;
        private Button btnPrev;
        private Label lblNotes;
        private Button btnCalculate;
        private Button btnWriteFileOutput;
    }
}