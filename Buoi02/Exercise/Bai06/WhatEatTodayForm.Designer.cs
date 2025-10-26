namespace Exercise.Bai06
{
    partial class WhatEatTodayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WhatEatTodayForm));
            txtInput = new TextBox();
            label1 = new Label();
            btnAdd = new Button();
            btnFind = new Button();
            btnDel = new Button();
            btnExit = new Button();
            groupBox1 = new GroupBox();
            lblNameDish = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnPickPic = new Button();
            listView1 = new ListView();
            pctDish = new PictureBox();
            lblUser = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctDish).BeginInit();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(184, 30);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(253, 27);
            txtInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 30);
            label1.Name = "label1";
            label1.Size = new Size(150, 18);
            label1.TabIndex = 2;
            label1.Text = "Nhập tên người dùng:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ButtonHighlight;
            btnAdd.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(471, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 40);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnFind
            // 
            btnFind.BackColor = SystemColors.ButtonHighlight;
            btnFind.FlatAppearance.BorderColor = Color.Blue;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFind.Location = new Point(471, 204);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(100, 40);
            btnFind.TabIndex = 4;
            btnFind.Text = "Tìm món ăn";
            btnFind.UseVisualStyleBackColor = false;
            // 
            // btnDel
            // 
            btnDel.BackColor = SystemColors.ButtonHighlight;
            btnDel.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Font = new Font("Tahoma", 9F);
            btnDel.Location = new Point(471, 250);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(100, 40);
            btnDel.TabIndex = 5;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ButtonHighlight;
            btnExit.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Tahoma", 9F);
            btnExit.Location = new Point(471, 296);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 40);
            btnExit.TabIndex = 6;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblUser);
            groupBox1.Controls.Add(pctDish);
            groupBox1.Controls.Add(lblNameDish);
            groupBox1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(28, 394);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(543, 183);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kết quả";
            // 
            // lblNameDish
            // 
            lblNameDish.Location = new Point(230, 25);
            lblNameDish.Name = "lblNameDish";
            lblNameDish.Size = new Size(297, 31);
            lblNameDish.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 150);
            label2.Name = "label2";
            label2.Size = new Size(112, 18);
            label2.TabIndex = 12;
            label2.Text = "Thêm hình ảnh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 110);
            label3.Name = "label3";
            label3.Size = new Size(102, 18);
            label3.TabIndex = 13;
            label3.Text = "Nhập món ăn:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 70);
            label5.Name = "label5";
            label5.Size = new Size(121, 18);
            label5.TabIndex = 14;
            label5.Text = "Nhập quyền hạn:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(184, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 27);
            textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(184, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(253, 27);
            textBox2.TabIndex = 16;
            // 
            // btnPickPic
            // 
            btnPickPic.BackColor = SystemColors.ControlLight;
            btnPickPic.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnPickPic.FlatStyle = FlatStyle.Flat;
            btnPickPic.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPickPic.Location = new Point(270, 150);
            btnPickPic.Name = "btnPickPic";
            btnPickPic.Size = new Size(73, 27);
            btnPickPic.TabIndex = 17;
            btnPickPic.Text = "Chọn ảnh";
            btnPickPic.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            listView1.Location = new Point(28, 204);
            listView1.Name = "listView1";
            listView1.Size = new Size(409, 181);
            listView1.TabIndex = 18;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pctDish
            // 
            pctDish.Location = new Point(25, 25);
            pctDish.Name = "pctDish";
            pctDish.Size = new Size(179, 135);
            pctDish.TabIndex = 1;
            pctDish.TabStop = false;
            // 
            // lblUser
            // 
            lblUser.Location = new Point(230, 66);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(297, 31);
            lblUser.TabIndex = 2;
            // 
            // WhatEatTodayForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 600);
            Controls.Add(listView1);
            Controls.Add(btnPickPic);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(btnExit);
            Controls.Add(btnDel);
            Controls.Add(btnFind);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(txtInput);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WhatEatTodayForm";
            Text = "Hôm nay ăn gì?";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctDish).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtInput;
        private Label label1;
        private Button btnAdd;
        private Button btnFind;
        private Button btnDel;
        private Button btnExit;
        private GroupBox groupBox1;
        private Label lblNameDish;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnPickPic;
        private ListView listView1;
        private PictureBox pctDish;
        private Label lblUser;
    }
}