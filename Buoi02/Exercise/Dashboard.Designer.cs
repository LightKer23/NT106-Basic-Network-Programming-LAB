namespace Exercise
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            btnBai01 = new Button();
            btnBai02 = new Button();
            btnBai05 = new Button();
            btnBai07 = new Button();
            btnBai03 = new Button();
            btnBai04 = new Button();
            btnBai06 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnBai01
            // 
            btnBai01.BackColor = SystemColors.ButtonHighlight;
            btnBai01.FlatStyle = FlatStyle.Flat;
            btnBai01.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBai01.Location = new Point(28, 26);
            btnBai01.Name = "btnBai01";
            btnBai01.Size = new Size(120, 60);
            btnBai01.TabIndex = 0;
            btnBai01.Text = "Bài 01";
            btnBai01.UseVisualStyleBackColor = false;
            btnBai01.Click += btnBai01_Click;
            // 
            // btnBai02
            // 
            btnBai02.BackColor = SystemColors.ButtonHighlight;
            btnBai02.FlatStyle = FlatStyle.Flat;
            btnBai02.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBai02.Location = new Point(168, 26);
            btnBai02.Name = "btnBai02";
            btnBai02.Size = new Size(120, 60);
            btnBai02.TabIndex = 1;
            btnBai02.Text = "Bài 02";
            btnBai02.UseVisualStyleBackColor = false;
            btnBai02.Click += btnBai02_Click;
            // 
            // btnBai05
            // 
            btnBai05.BackColor = SystemColors.ButtonHighlight;
            btnBai05.FlatStyle = FlatStyle.Flat;
            btnBai05.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBai05.Location = new Point(28, 129);
            btnBai05.Name = "btnBai05";
            btnBai05.Size = new Size(120, 60);
            btnBai05.TabIndex = 2;
            btnBai05.Text = "Bài 05";
            btnBai05.UseVisualStyleBackColor = false;
            btnBai05.Click += btnBai05_Click;
            // 
            // btnBai07
            // 
            btnBai07.BackColor = SystemColors.ButtonHighlight;
            btnBai07.FlatStyle = FlatStyle.Flat;
            btnBai07.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBai07.Location = new Point(310, 129);
            btnBai07.Name = "btnBai07";
            btnBai07.Size = new Size(120, 60);
            btnBai07.TabIndex = 3;
            btnBai07.Text = "Bài 07";
            btnBai07.UseVisualStyleBackColor = false;
            btnBai07.Click += btnBai07_Click;
            // 
            // btnBai03
            // 
            btnBai03.BackColor = SystemColors.ButtonHighlight;
            btnBai03.FlatStyle = FlatStyle.Flat;
            btnBai03.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBai03.Location = new Point(310, 26);
            btnBai03.Name = "btnBai03";
            btnBai03.Size = new Size(120, 60);
            btnBai03.TabIndex = 4;
            btnBai03.Text = "Bài 03";
            btnBai03.UseVisualStyleBackColor = false;
            btnBai03.Click += btnBai03_Click;
            // 
            // btnBai04
            // 
            btnBai04.BackColor = SystemColors.ButtonHighlight;
            btnBai04.FlatStyle = FlatStyle.Flat;
            btnBai04.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBai04.Location = new Point(450, 26);
            btnBai04.Name = "btnBai04";
            btnBai04.Size = new Size(120, 60);
            btnBai04.TabIndex = 5;
            btnBai04.Text = "Bài 04";
            btnBai04.UseVisualStyleBackColor = false;
            btnBai04.Click += btnBai04_Click;
            // 
            // btnBai06
            // 
            btnBai06.BackColor = SystemColors.ButtonHighlight;
            btnBai06.FlatStyle = FlatStyle.Flat;
            btnBai06.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBai06.Location = new Point(168, 129);
            btnBai06.Name = "btnBai06";
            btnBai06.Size = new Size(120, 60);
            btnBai06.TabIndex = 6;
            btnBai06.Text = "Bài 06";
            btnBai06.UseVisualStyleBackColor = false;
            btnBai06.Click += btnBai06_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Tahoma", 10F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(465, 151);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 7;
            label1.Text = "NT106.Q14";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 208);
            Controls.Add(label1);
            Controls.Add(btnBai06);
            Controls.Add(btnBai04);
            Controls.Add(btnBai03);
            Controls.Add(btnBai07);
            Controls.Add(btnBai05);
            Controls.Add(btnBai02);
            Controls.Add(btnBai01);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBai01;
        private Button btnBai02;
        private Button btnBai05;
        private Button btnBai07;
        private Button btnBai03;
        private Button btnBai04;
        private Button btnBai06;
        private Label label1;
    }
}
