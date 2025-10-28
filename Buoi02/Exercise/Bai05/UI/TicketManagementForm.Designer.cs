namespace Exercise.Bai05
{
    partial class TicketManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketManagementForm));
            lblLegendTitle = new Label();
            grpCustomer = new GroupBox();
            txtCustomerName = new TextBox();
            lblName = new Label();
            grpBooking = new GroupBox();
            lblProgress = new Label();
            btnReset = new Button();
            btnBookTicket = new Button();
            cboSeat = new ComboBox();
            progressBar = new ProgressBar();
            cboRoom = new ComboBox();
            cboMovie = new ComboBox();
            lblRoom = new Label();
            lblSeat = new Label();
            lblMovie = new Label();
            grpSeatMap = new GroupBox();
            pnlSeatMap = new Panel();
            pnlBooked = new Panel();
            pnlVIP = new Panel();
            pnlNormal = new Panel();
            pnlRescue = new Panel();
            grpSelected = new GroupBox();
            lblTotal = new Label();
            lstSelectedTickets = new ListBox();
            grpResult = new GroupBox();
            txtResult = new TextBox();
            pnlLegend = new Panel();
            lblVip = new Label();
            lblBooked = new Label();
            lblNormal = new Label();
            lblRescue = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            menuSystem = new ToolStripMenuItem();
            menuResetAll = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            grpFile = new GroupBox();
            btnStatistics = new Button();
            btnLoadFromFile = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            grpCustomer.SuspendLayout();
            grpBooking.SuspendLayout();
            grpSeatMap.SuspendLayout();
            grpSelected.SuspendLayout();
            grpResult.SuspendLayout();
            pnlLegend.SuspendLayout();
            menuStrip1.SuspendLayout();
            grpFile.SuspendLayout();
            SuspendLayout();
            // 
            // lblLegendTitle
            // 
            lblLegendTitle.Font = new Font("Tahoma", 9F);
            lblLegendTitle.Location = new Point(490, 9);
            lblLegendTitle.Name = "lblLegendTitle";
            lblLegendTitle.Size = new Size(100, 23);
            lblLegendTitle.TabIndex = 0;
            // 
            // grpCustomer
            // 
            grpCustomer.Controls.Add(txtCustomerName);
            grpCustomer.Controls.Add(lblName);
            grpCustomer.Font = new Font("Tahoma", 9F);
            grpCustomer.Location = new Point(20, 125);
            grpCustomer.Name = "grpCustomer";
            grpCustomer.Size = new Size(450, 71);
            grpCustomer.TabIndex = 3;
            grpCustomer.TabStop = false;
            grpCustomer.Text = "Thông Tin Khách Hàng";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(162, 28);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(271, 26);
            txtCustomerName.TabIndex = 4;
            // 
            // lblName
            // 
            lblName.Location = new Point(25, 30);
            lblName.Name = "lblName";
            lblName.Size = new Size(80, 20);
            lblName.TabIndex = 4;
            lblName.Text = "Họ và tên:";
            // 
            // grpBooking
            // 
            grpBooking.Controls.Add(lblProgress);
            grpBooking.Controls.Add(btnReset);
            grpBooking.Controls.Add(btnBookTicket);
            grpBooking.Controls.Add(cboSeat);
            grpBooking.Controls.Add(progressBar);
            grpBooking.Controls.Add(cboRoom);
            grpBooking.Controls.Add(cboMovie);
            grpBooking.Controls.Add(lblRoom);
            grpBooking.Controls.Add(lblSeat);
            grpBooking.Controls.Add(lblMovie);
            grpBooking.Font = new Font("Tahoma", 9F);
            grpBooking.Location = new Point(20, 202);
            grpBooking.Name = "grpBooking";
            grpBooking.Size = new Size(450, 200);
            grpBooking.TabIndex = 4;
            grpBooking.TabStop = false;
            grpBooking.Text = "Đặt Vé";
            // 
            // lblProgress
            // 
            lblProgress.Location = new Point(415, 122);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(60, 20);
            lblProgress.TabIndex = 11;
            lblProgress.Text = "0%";
            lblProgress.TextAlign = ContentAlignment.MiddleLeft;
            lblProgress.Visible = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.ButtonHighlight;
            btnReset.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Location = new Point(313, 146);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 35);
            btnReset.TabIndex = 7;
            btnReset.Text = "Làm mới";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnBookTicket
            // 
            btnBookTicket.BackColor = SystemColors.ButtonHighlight;
            btnBookTicket.FlatAppearance.BorderColor = Color.Blue;
            btnBookTicket.FlatStyle = FlatStyle.Flat;
            btnBookTicket.Location = new Point(162, 146);
            btnBookTicket.Name = "btnBookTicket";
            btnBookTicket.Size = new Size(120, 35);
            btnBookTicket.TabIndex = 6;
            btnBookTicket.Text = "Đặt Vé";
            btnBookTicket.UseVisualStyleBackColor = false;
            btnBookTicket.Click += btnBookTicket_Click;
            // 
            // cboSeat
            // 
            cboSeat.FormattingEnabled = true;
            cboSeat.Location = new Point(162, 89);
            cboSeat.Name = "cboSeat";
            cboSeat.Size = new Size(271, 26);
            cboSeat.TabIndex = 5;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(5, 119);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(400, 25);
            progressBar.TabIndex = 10;
            progressBar.Visible = false;
            // 
            // cboRoom
            // 
            cboRoom.FormattingEnabled = true;
            cboRoom.Location = new Point(162, 56);
            cboRoom.Name = "cboRoom";
            cboRoom.Size = new Size(271, 26);
            cboRoom.TabIndex = 4;
            cboRoom.SelectedIndexChanged += cboRoom_SelectedIndexChanged;
            // 
            // cboMovie
            // 
            cboMovie.FormattingEnabled = true;
            cboMovie.Location = new Point(162, 23);
            cboMovie.Name = "cboMovie";
            cboMovie.Size = new Size(271, 26);
            cboMovie.TabIndex = 3;
            cboMovie.SelectedIndexChanged += cboMovie_SelectedIndexChanged;
            // 
            // lblRoom
            // 
            lblRoom.Location = new Point(25, 56);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(140, 20);
            lblRoom.TabIndex = 2;
            lblRoom.Text = "Chọn Phòng Chiếu:";
            // 
            // lblSeat
            // 
            lblSeat.Location = new Point(25, 89);
            lblSeat.Name = "lblSeat";
            lblSeat.Size = new Size(140, 20);
            lblSeat.TabIndex = 1;
            lblSeat.Text = "Chọn Chỗ Ngồi:";
            // 
            // lblMovie
            // 
            lblMovie.Location = new Point(25, 23);
            lblMovie.Name = "lblMovie";
            lblMovie.Size = new Size(100, 20);
            lblMovie.TabIndex = 0;
            lblMovie.Text = "Chọn Phim:";
            // 
            // grpSeatMap
            // 
            grpSeatMap.Controls.Add(pnlSeatMap);
            grpSeatMap.Font = new Font("Tahoma", 9F);
            grpSeatMap.Location = new Point(20, 408);
            grpSeatMap.Name = "grpSeatMap";
            grpSeatMap.Size = new Size(450, 288);
            grpSeatMap.TabIndex = 5;
            grpSeatMap.TabStop = false;
            grpSeatMap.Text = "Sơ Đồ Chỗ Ngồi";
            // 
            // pnlSeatMap
            // 
            pnlSeatMap.AutoScroll = true;
            pnlSeatMap.BackColor = Color.White;
            pnlSeatMap.Location = new Point(10, 25);
            pnlSeatMap.Name = "pnlSeatMap";
            pnlSeatMap.Size = new Size(430, 257);
            pnlSeatMap.TabIndex = 0;
            // 
            // pnlBooked
            // 
            pnlBooked.BackColor = Color.Red;
            pnlBooked.BorderStyle = BorderStyle.FixedSingle;
            pnlBooked.Location = new Point(547, 3);
            pnlBooked.Name = "pnlBooked";
            pnlBooked.Size = new Size(20, 20);
            pnlBooked.TabIndex = 3;
            // 
            // pnlVIP
            // 
            pnlVIP.BackColor = Color.Gold;
            pnlVIP.BorderStyle = BorderStyle.FixedSingle;
            pnlVIP.Location = new Point(419, 4);
            pnlVIP.Name = "pnlVIP";
            pnlVIP.Size = new Size(20, 20);
            pnlVIP.TabIndex = 2;
            // 
            // pnlNormal
            // 
            pnlNormal.BackColor = Color.Blue;
            pnlNormal.BorderStyle = BorderStyle.FixedSingle;
            pnlNormal.Location = new Point(244, 5);
            pnlNormal.Name = "pnlNormal";
            pnlNormal.Size = new Size(20, 20);
            pnlNormal.TabIndex = 1;
            // 
            // pnlRescue
            // 
            pnlRescue.BackColor = Color.Green;
            pnlRescue.BorderStyle = BorderStyle.FixedSingle;
            pnlRescue.Location = new Point(112, 5);
            pnlRescue.Name = "pnlRescue";
            pnlRescue.Size = new Size(20, 20);
            pnlRescue.TabIndex = 1;
            // 
            // grpSelected
            // 
            grpSelected.Controls.Add(lblTotal);
            grpSelected.Controls.Add(lstSelectedTickets);
            grpSelected.Font = new Font("Tahoma", 9F);
            grpSelected.Location = new Point(490, 20);
            grpSelected.Name = "grpSelected";
            grpSelected.Size = new Size(470, 258);
            grpSelected.TabIndex = 6;
            grpSelected.TabStop = false;
            grpSelected.Text = "Vé Đã Chọn";
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            lblTotal.ForeColor = Color.Red;
            lblTotal.Location = new Point(17, 213);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(440, 25);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Tổng tiền: 0đ";
            // 
            // lstSelectedTickets
            // 
            lstSelectedTickets.FormattingEnabled = true;
            lstSelectedTickets.ItemHeight = 18;
            lstSelectedTickets.Location = new Point(17, 28);
            lstSelectedTickets.Name = "lstSelectedTickets";
            lstSelectedTickets.Size = new Size(440, 166);
            lstSelectedTickets.TabIndex = 0;
            // 
            // grpResult
            // 
            grpResult.Controls.Add(txtResult);
            grpResult.Font = new Font("Tahoma", 9F);
            grpResult.Location = new Point(490, 291);
            grpResult.Name = "grpResult";
            grpResult.Size = new Size(470, 412);
            grpResult.TabIndex = 7;
            grpResult.TabStop = false;
            grpResult.Text = "Thông Tin Thanh Toán";
            // 
            // txtResult
            // 
            txtResult.BackColor = SystemColors.ButtonHighlight;
            txtResult.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResult.Location = new Point(15, 25);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.ScrollBars = ScrollBars.Vertical;
            txtResult.Size = new Size(440, 373);
            txtResult.TabIndex = 5;
            // 
            // pnlLegend
            // 
            pnlLegend.BorderStyle = BorderStyle.FixedSingle;
            pnlLegend.Controls.Add(pnlBooked);
            pnlLegend.Controls.Add(pnlVIP);
            pnlLegend.Controls.Add(pnlNormal);
            pnlLegend.Controls.Add(pnlRescue);
            pnlLegend.Controls.Add(lblVip);
            pnlLegend.Controls.Add(lblBooked);
            pnlLegend.Controls.Add(lblNormal);
            pnlLegend.Controls.Add(lblRescue);
            pnlLegend.Controls.Add(label1);
            pnlLegend.Location = new Point(20, 709);
            pnlLegend.Name = "pnlLegend";
            pnlLegend.Size = new Size(940, 30);
            pnlLegend.TabIndex = 1;
            // 
            // lblVip
            // 
            lblVip.Location = new Point(442, 3);
            lblVip.Name = "lblVip";
            lblVip.Size = new Size(100, 20);
            lblVip.TabIndex = 8;
            lblVip.Text = "Vip (2x giá)";
            // 
            // lblBooked
            // 
            lblBooked.Location = new Point(573, 3);
            lblBooked.Name = "lblBooked";
            lblBooked.Size = new Size(100, 20);
            lblBooked.TabIndex = 9;
            lblBooked.Text = "Đã đặt";
            // 
            // lblNormal
            // 
            lblNormal.Location = new Point(270, 3);
            lblNormal.Name = "lblNormal";
            lblNormal.Size = new Size(134, 22);
            lblNormal.TabIndex = 10;
            lblNormal.Text = "Thường (Giá gốc)";
            // 
            // lblRescue
            // 
            lblRescue.Location = new Point(138, 3);
            lblRescue.Name = "lblRescue";
            lblRescue.Size = new Size(100, 20);
            lblRescue.TabIndex = 11;
            lblRescue.Text = "Vớt (1/4 giá)";
            // 
            // label1
            // 
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label1.Location = new Point(5, 4);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 8;
            label1.Text = "Chú thích:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuSystem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(978, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuSystem
            // 
            menuSystem.DropDownItems.AddRange(new ToolStripItem[] { menuResetAll, menuExit });
            menuSystem.Name = "menuSystem";
            menuSystem.Size = new Size(85, 24);
            menuSystem.Text = "Hệ thống";
            // 
            // menuResetAll
            // 
            menuResetAll.Name = "menuResetAll";
            menuResetAll.Size = new Size(181, 26);
            menuResetAll.Text = "Khởi động lại";
            menuResetAll.Click += menuResetAll_Click;
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(181, 26);
            menuExit.Text = "Thoát";
            menuExit.Click += menuExit_Click;
            // 
            // grpFile
            // 
            grpFile.Controls.Add(btnStatistics);
            grpFile.Controls.Add(btnLoadFromFile);
            grpFile.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpFile.Location = new Point(20, 31);
            grpFile.Name = "grpFile";
            grpFile.Size = new Size(450, 90);
            grpFile.TabIndex = 9;
            grpFile.TabStop = false;
            grpFile.Text = "Quản Lý File";
            // 
            // btnStatistics
            // 
            btnStatistics.BackColor = SystemColors.ButtonHighlight;
            btnStatistics.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            btnStatistics.FlatStyle = FlatStyle.Flat;
            btnStatistics.Location = new Point(271, 30);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(130, 40);
            btnStatistics.TabIndex = 9;
            btnStatistics.Text = "Xuất thống kê";
            btnStatistics.UseVisualStyleBackColor = false;
            btnStatistics.Click += btnStatistics_Click;
            // 
            // btnLoadFromFile
            // 
            btnLoadFromFile.BackColor = SystemColors.ButtonHighlight;
            btnLoadFromFile.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            btnLoadFromFile.FlatStyle = FlatStyle.Flat;
            btnLoadFromFile.Location = new Point(71, 30);
            btnLoadFromFile.Name = "btnLoadFromFile";
            btnLoadFromFile.Size = new Size(130, 40);
            btnLoadFromFile.TabIndex = 8;
            btnLoadFromFile.Text = "Đọc File";
            btnLoadFromFile.UseVisualStyleBackColor = false;
            btnLoadFromFile.Click += btnLoadFromFile_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // TicketManagementForm
            // 
            ClientSize = new Size(978, 751);
            Controls.Add(grpFile);
            Controls.Add(pnlLegend);
            Controls.Add(grpResult);
            Controls.Add(grpSelected);
            Controls.Add(grpSeatMap);
            Controls.Add(grpBooking);
            Controls.Add(grpCustomer);
            Controls.Add(lblLegendTitle);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "TicketManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Phòng Vé";
            grpCustomer.ResumeLayout(false);
            grpCustomer.PerformLayout();
            grpBooking.ResumeLayout(false);
            grpSeatMap.ResumeLayout(false);
            grpSelected.ResumeLayout(false);
            grpResult.ResumeLayout(false);
            grpResult.PerformLayout();
            pnlLegend.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grpFile.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblLegendTitle;
        private GroupBox grpCustomer;
        private Label lblName;
        private TextBox txtCustomerName;
        private GroupBox grpBooking;
        private GroupBox grpSeatMap;
        private GroupBox grpSelected;
        private GroupBox grpResult;
        private ComboBox cboMovie;
        private Label lblRoom;
        private Label lblSeat;
        private Label lblMovie;
        private Button btnReset;
        private Button btnBookTicket;
        private ComboBox cboSeat;
        private ComboBox cboRoom;
        private ListBox lstSelectedTickets;
        private Label lblTotal;
        private Panel pnlSeatMap;
        private Panel pnlNormal;
        private Panel pnlRescue;
        private Panel pnlLegend;
        private Label label1;
        private TextBox txtResult;
        private Label lblVip;
        private Label lblBooked;
        private Label lblNormal;
        private Label lblRescue;
        private Panel pnlVIP;
        private Panel pnlBooked;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuSystem;
        private ToolStripMenuItem menuResetAll;
        private ToolStripMenuItem menuExit;
        private GroupBox grpFile;
        private Button btnLoadFromFile;
        private Button btnStatistics;
        private ProgressBar progressBar;
        private Label lblProgress;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}