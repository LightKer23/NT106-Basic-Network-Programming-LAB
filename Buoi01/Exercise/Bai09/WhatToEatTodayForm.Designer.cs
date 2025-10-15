namespace Exercise.Bai09
{
    partial class WhatToEatTodayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WhatToEatTodayForm));
            txtInput = new TextBox();
            label1 = new Label();
            btnAdd = new Button();
            btnFind = new Button();
            btnDel = new Button();
            btnExit = new Button();
            groupBox1 = new GroupBox();
            lblOuput = new Label();
            label4 = new Label();
            lstDishes = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(136, 33);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(253, 27);
            txtInput.TabIndex = 1;
            txtInput.TextChanged += txtInput_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 37);
            label1.Name = "label1";
            label1.Size = new Size(102, 18);
            label1.TabIndex = 2;
            label1.Text = "Nhập món ăn:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ButtonHighlight;
            btnAdd.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(406, 26);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 40);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = SystemColors.ButtonHighlight;
            btnFind.FlatAppearance.BorderColor = Color.Blue;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFind.Location = new Point(406, 86);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(100, 40);
            btnFind.TabIndex = 4;
            btnFind.Text = "Tìm món ăn";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = SystemColors.ButtonHighlight;
            btnDel.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Font = new Font("Tahoma", 9F);
            btnDel.Location = new Point(406, 132);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(100, 40);
            btnDel.TabIndex = 5;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ButtonHighlight;
            btnExit.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Tahoma", 9F);
            btnExit.Location = new Point(406, 178);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 40);
            btnExit.TabIndex = 6;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblOuput);
            groupBox1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(28, 355);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 92);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kết quả";
            // 
            // lblOuput
            // 
            lblOuput.Location = new Point(18, 33);
            lblOuput.Name = "lblOuput";
            lblOuput.Size = new Size(323, 46);
            lblOuput.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Underline);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(414, 397);
            label4.Name = "label4";
            label4.Size = new Size(84, 18);
            label4.TabIndex = 8;
            label4.Text = "NT106.Q14";
            // 
            // lstDishes
            // 
            lstDishes.FormattingEnabled = true;
            lstDishes.Location = new Point(28, 86);
            lstDishes.Name = "lstDishes";
            lstDishes.Size = new Size(361, 264);
            lstDishes.TabIndex = 9;
            // 
            // WhatToEatTodayForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 460);
            Controls.Add(lstDishes);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(btnExit);
            Controls.Add(btnDel);
            Controls.Add(btnFind);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(txtInput);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WhatToEatTodayForm";
            Text = "Hôm nay ăn gì?";
            Load += WhatToEatTodayForm_Load;
            groupBox1.ResumeLayout(false);
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
        private Label label4;
        private Label lblOuput;
        private ListBox lstDishes;
    }
}