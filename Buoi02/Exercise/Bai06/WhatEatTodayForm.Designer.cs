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
            btnAdd = new Button();
            btnFind = new Button();
            btnDel = new Button();
            btnExit = new Button();
            groupBox1 = new GroupBox();
            lblUser = new Label();
            pctDish = new PictureBox();
            lblNameDish = new Label();
            listView1 = new ListView();
            groupBox2 = new GroupBox();
            btnPickPic = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtInput = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctDish).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ButtonHighlight;
            btnAdd.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(471, 22);
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
            // lblUser
            // 
            lblUser.Location = new Point(230, 66);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(297, 31);
            lblUser.TabIndex = 2;
            // 
            // pctDish
            // 
            pctDish.Location = new Point(25, 25);
            pctDish.Name = "pctDish";
            pctDish.Size = new Size(179, 135);
            pctDish.TabIndex = 1;
            pctDish.TabStop = false;
            // 
            // lblNameDish
            // 
            lblNameDish.Location = new Point(230, 25);
            lblNameDish.Name = "lblNameDish";
            lblNameDish.Size = new Size(297, 31);
            lblNameDish.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.Location = new Point(28, 204);
            listView1.Name = "listView1";
            listView1.Size = new Size(437, 181);
            listView1.TabIndex = 18;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnPickPic);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtInput);
            groupBox2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(28, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(437, 177);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nhập";
            // 
            // btnPickPic
            // 
            btnPickPic.BackColor = SystemColors.ControlLight;
            btnPickPic.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnPickPic.FlatStyle = FlatStyle.Flat;
            btnPickPic.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPickPic.Location = new Point(258, 141);
            btnPickPic.Name = "btnPickPic";
            btnPickPic.Size = new Size(73, 27);
            btnPickPic.TabIndex = 33;
            btnPickPic.Text = "Chọn ảnh";
            btnPickPic.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(172, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(253, 26);
            textBox2.TabIndex = 32;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 26);
            textBox1.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 61);
            label5.Name = "label5";
            label5.Size = new Size(121, 18);
            label5.TabIndex = 30;
            label5.Text = "Nhập quyền hạn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 101);
            label3.Name = "label3";
            label3.Size = new Size(102, 18);
            label3.TabIndex = 29;
            label3.Text = "Nhập món ăn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 141);
            label2.Name = "label2";
            label2.Size = new Size(112, 18);
            label2.TabIndex = 28;
            label2.Text = "Thêm hình ảnh:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 21);
            label1.Name = "label1";
            label1.Size = new Size(150, 18);
            label1.TabIndex = 27;
            label1.Text = "Nhập tên người dùng:";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(172, 21);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(253, 26);
            txtInput.TabIndex = 26;
            // 
            // WhatEatTodayForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 600);
            Controls.Add(groupBox2);
            Controls.Add(listView1);
            Controls.Add(groupBox1);
            Controls.Add(btnExit);
            Controls.Add(btnDel);
            Controls.Add(btnFind);
            Controls.Add(btnAdd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WhatEatTodayForm";
            Text = "Hôm nay ăn gì?";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctDish).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAdd;
        private Button btnFind;
        private Button btnDel;
        private Button btnExit;
        private GroupBox groupBox1;
        private Label lblNameDish;
        private ListView listView1;
        private PictureBox pctDish;
        private Label lblUser;
        private GroupBox groupBox2;
        private Button btnPickPic;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtInput;
    }
}