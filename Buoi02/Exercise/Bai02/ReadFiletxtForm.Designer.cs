namespace Exercise.Bai02
{
    partial class ReadFiletxtForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadFiletxtForm));
            grpBoxInput = new GroupBox();
            lblFileName = new Label();
            lblChar = new Label();
            lblWord = new Label();
            lblLine = new Label();
            lblURL = new Label();
            lblSize = new Label();
            txtBoxFIleName = new TextBox();
            txtBoxChar = new TextBox();
            txtBoxWord = new TextBox();
            txtBoxLine = new TextBox();
            txtBoxURL = new TextBox();
            txtBoxSize = new TextBox();
            btnReadFile = new Button();
            btnClose = new Button();
            rtBoxOutput = new RichTextBox();
            grpBoxInput.SuspendLayout();
            SuspendLayout();
            // 
            // grpBoxInput
            // 
            grpBoxInput.Controls.Add(txtBoxChar);
            grpBoxInput.Controls.Add(txtBoxWord);
            grpBoxInput.Controls.Add(txtBoxLine);
            grpBoxInput.Controls.Add(txtBoxURL);
            grpBoxInput.Controls.Add(txtBoxSize);
            grpBoxInput.Controls.Add(txtBoxFIleName);
            grpBoxInput.Controls.Add(lblSize);
            grpBoxInput.Controls.Add(lblURL);
            grpBoxInput.Controls.Add(lblLine);
            grpBoxInput.Controls.Add(lblWord);
            grpBoxInput.Controls.Add(lblChar);
            grpBoxInput.Controls.Add(lblFileName);
            grpBoxInput.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpBoxInput.Location = new Point(21, 21);
            grpBoxInput.Name = "grpBoxInput";
            grpBoxInput.Size = new Size(410, 250);
            grpBoxInput.TabIndex = 1;
            grpBoxInput.TabStop = false;
            grpBoxInput.Text = "Nhập";
            // 
            // lblFileName
            // 
            lblFileName.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFileName.Location = new Point(20, 30);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(81, 23);
            lblFileName.TabIndex = 1;
            lblFileName.Text = "Tên File:";
            // 
            // lblChar
            // 
            lblChar.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChar.Location = new Point(20, 205);
            lblChar.Name = "lblChar";
            lblChar.Size = new Size(81, 23);
            lblChar.TabIndex = 2;
            lblChar.Text = "Số kí tự:";
            // 
            // lblWord
            // 
            lblWord.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWord.Location = new Point(20, 170);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(81, 23);
            lblWord.TabIndex = 3;
            lblWord.Text = "Số từ:";
            // 
            // lblLine
            // 
            lblLine.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLine.Location = new Point(20, 135);
            lblLine.Name = "lblLine";
            lblLine.Size = new Size(81, 23);
            lblLine.TabIndex = 4;
            lblLine.Text = "Số dòng:";
            // 
            // lblURL
            // 
            lblURL.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblURL.Location = new Point(20, 100);
            lblURL.Name = "lblURL";
            lblURL.Size = new Size(81, 23);
            lblURL.TabIndex = 5;
            lblURL.Text = "URL:";
            // 
            // lblSize
            // 
            lblSize.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSize.Location = new Point(20, 65);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(96, 23);
            lblSize.TabIndex = 6;
            lblSize.Text = "Kích thước:";
            // 
            // txtBoxFIleName
            // 
            txtBoxFIleName.Location = new Point(160, 30);
            txtBoxFIleName.Name = "txtBoxFIleName";
            txtBoxFIleName.Size = new Size(220, 28);
            txtBoxFIleName.TabIndex = 2;
            // 
            // txtBoxChar
            // 
            txtBoxChar.Location = new Point(160, 205);
            txtBoxChar.Name = "txtBoxChar";
            txtBoxChar.Size = new Size(221, 28);
            txtBoxChar.TabIndex = 3;
            // 
            // txtBoxWord
            // 
            txtBoxWord.Location = new Point(160, 170);
            txtBoxWord.Name = "txtBoxWord";
            txtBoxWord.Size = new Size(221, 28);
            txtBoxWord.TabIndex = 4;
            // 
            // txtBoxLine
            // 
            txtBoxLine.Location = new Point(160, 135);
            txtBoxLine.Name = "txtBoxLine";
            txtBoxLine.Size = new Size(221, 28);
            txtBoxLine.TabIndex = 5;
            // 
            // txtBoxURL
            // 
            txtBoxURL.Location = new Point(160, 100);
            txtBoxURL.Name = "txtBoxURL";
            txtBoxURL.Size = new Size(221, 28);
            txtBoxURL.TabIndex = 6;
            txtBoxURL.TextChanged += txtBoxURL_TextChanged;
            // 
            // txtBoxSize
            // 
            txtBoxSize.Location = new Point(160, 65);
            txtBoxSize.Name = "txtBoxSize";
            txtBoxSize.Size = new Size(220, 28);
            txtBoxSize.TabIndex = 7;
            // 
            // btnReadFile
            // 
            btnReadFile.BackColor = SystemColors.ButtonHighlight;
            btnReadFile.FlatAppearance.BorderColor = Color.Blue;
            btnReadFile.FlatStyle = FlatStyle.Flat;
            btnReadFile.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReadFile.Location = new Point(231, 297);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(200, 40);
            btnReadFile.TabIndex = 2;
            btnReadFile.Text = "Đọc File";
            btnReadFile.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ButtonHighlight;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(21, 297);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(200, 40);
            btnClose.TabIndex = 3;
            btnClose.Text = "Thoát";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // rtBoxOutput
            // 
            rtBoxOutput.Location = new Point(456, 29);
            rtBoxOutput.Name = "rtBoxOutput";
            rtBoxOutput.Size = new Size(417, 242);
            rtBoxOutput.TabIndex = 4;
            rtBoxOutput.Text = "";
            // 
            // ReadFiletxtForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 356);
            Controls.Add(rtBoxOutput);
            Controls.Add(btnClose);
            Controls.Add(btnReadFile);
            Controls.Add(grpBoxInput);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReadFiletxtForm";
            Text = "Đọc thông tin File .txt";
            grpBoxInput.ResumeLayout(false);
            grpBoxInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxInput;
        private Label lblFileName;
        private TextBox txtBoxChar;
        private TextBox txtBoxWord;
        private TextBox txtBoxLine;
        private TextBox txtBoxURL;
        private TextBox txtBoxSize;
        private TextBox txtBoxFIleName;
        private Label lblSize;
        private Label lblURL;
        private Label lblLine;
        private Label lblWord;
        private Label lblChar;
        private Button btnReadFile;
        private Button btnClose;
        private RichTextBox rtBoxOutput;
    }
}