namespace Exercise.Bai03
{
    partial class CalculateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateForm));
            btnReadFile = new Button();
            btnCalculate = new Button();
            btnWriteFile = new Button();
            rtBoxOutput = new RichTextBox();
            SuspendLayout();
            // 
            // btnReadFile
            // 
            btnReadFile.BackColor = SystemColors.ButtonHighlight;
            btnReadFile.FlatStyle = FlatStyle.Flat;
            btnReadFile.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReadFile.Location = new Point(28, 25);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(100, 40);
            btnReadFile.TabIndex = 0;
            btnReadFile.Text = "Đọc File";
            btnReadFile.UseVisualStyleBackColor = false;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.ButtonHighlight;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(28, 90);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(100, 40);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "Tính toán";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnWriteFile
            // 
            btnWriteFile.BackColor = SystemColors.ButtonHighlight;
            btnWriteFile.FlatStyle = FlatStyle.Flat;
            btnWriteFile.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWriteFile.Location = new Point(28, 156);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(100, 40);
            btnWriteFile.TabIndex = 2;
            btnWriteFile.Text = "Ghi File";
            btnWriteFile.UseVisualStyleBackColor = false;
            btnWriteFile.Click += btnWriteFile_Click;
            // 
            // rtBoxOutput
            // 
            rtBoxOutput.Location = new Point(162, 25);
            rtBoxOutput.Name = "rtBoxOutput";
            rtBoxOutput.Size = new Size(455, 171);
            rtBoxOutput.TabIndex = 3;
            rtBoxOutput.Text = "";
            // 
            // CalculateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 220);
            Controls.Add(rtBoxOutput);
            Controls.Add(btnWriteFile);
            Controls.Add(btnCalculate);
            Controls.Add(btnReadFile);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CalculateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tính toán";
            ResumeLayout(false);
        }

        #endregion

        private Button btnReadFile;
        private Button btnCalculate;
        private Button btnWriteFile;
        private RichTextBox rtBoxOutput;
    }
}