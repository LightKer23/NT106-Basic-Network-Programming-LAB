using System.Windows.Forms;

namespace Exercise.Bai07
{
    partial class TraversalFolderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraversalFolderForm));
            splitContainer1 = new SplitContainer();
            tvFolder = new TreeView();
            groupBox1 = new GroupBox();
            picShowImage = new PictureBox();
            rtBoxShowTxt = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picShowImage).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tvFolder);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(923, 531);
            splitContainer1.SplitterDistance = 306;
            splitContainer1.TabIndex = 0;
            // 
            // tvFolder
            // 
            tvFolder.Dock = DockStyle.Fill;
            tvFolder.Location = new Point(0, 0);
            tvFolder.Name = "tvFolder";
            tvFolder.Size = new Size(306, 531);
            tvFolder.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(picShowImage);
            groupBox1.Controls.Add(rtBoxShowTxt);
            groupBox1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(610, 528);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hiển thị nội dung";
            // 
            // picShowImage
            // 
            picShowImage.Dock = DockStyle.Fill;
            picShowImage.Location = new Point(3, 22);
            picShowImage.Name = "picShowImage";
            picShowImage.Size = new Size(604, 503);
            picShowImage.TabIndex = 5;
            picShowImage.TabStop = false;
            // 
            // rtBoxShowTxt
            // 
            rtBoxShowTxt.Dock = DockStyle.Fill;
            rtBoxShowTxt.Location = new Point(3, 22);
            rtBoxShowTxt.Name = "rtBoxShowTxt";
            rtBoxShowTxt.Size = new Size(604, 503);
            rtBoxShowTxt.TabIndex = 3;
            rtBoxShowTxt.Text = "";
            // 
            // TraversalFolderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 531);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TraversalFolderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Duyệt cây thư mục";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picShowImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TreeView tvFolder;
        private GroupBox groupBox1;
        private PictureBox picShowImage;
        private RichTextBox rtBoxShowTxt;
    }
}