namespace Exercise.Bai01
{
    partial class ReadAndWriteFileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadAndWriteFileForm));
            btnReadFile = new Button();
            btnWriteFile = new Button();
            rtBoxOutput = new RichTextBox();
            SuspendLayout();
            // 
            // btnReadFile
            // 
            btnReadFile.BackColor = SystemColors.ButtonHighlight;
            btnReadFile.FlatStyle = FlatStyle.Flat;
            btnReadFile.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReadFile.Location = new Point(26, 20);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(120, 50);
            btnReadFile.TabIndex = 0;
            btnReadFile.Text = "Đọc File";
            btnReadFile.UseVisualStyleBackColor = false;
            // 
            // btnWriteFile
            // 
            btnWriteFile.BackColor = SystemColors.ButtonHighlight;
            btnWriteFile.FlatStyle = FlatStyle.Flat;
            btnWriteFile.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWriteFile.Location = new Point(26, 100);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(120, 50);
            btnWriteFile.TabIndex = 1;
            btnWriteFile.Text = "Ghi File";
            btnWriteFile.UseVisualStyleBackColor = false;
            // 
            // rtBoxOutput
            // 
            rtBoxOutput.Location = new Point(160, 20);
            rtBoxOutput.Name = "rtBoxOutput";
            rtBoxOutput.Size = new Size(429, 283);
            rtBoxOutput.TabIndex = 2;
            rtBoxOutput.Text = "";
            // 
            // ReadAndWriteFileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 330);
            Controls.Add(rtBoxOutput);
            Controls.Add(btnWriteFile);
            Controls.Add(btnReadFile);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReadAndWriteFileForm";
            Text = "Đọc và ghi File";
            ResumeLayout(false);
        }

        #endregion

        private Button btnReadFile;
        private Button btnWriteFile;
        private RichTextBox rtBoxOutput;
    }
}