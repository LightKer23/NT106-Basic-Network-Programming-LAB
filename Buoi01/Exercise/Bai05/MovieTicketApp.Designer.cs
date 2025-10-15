namespace Exercise.Bai05
{
    partial class MovieTicketApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieTicketApp));
            lblLegendTitle = new Label();
            grpCustomer = new GroupBox();
            txtCustomerName = new TextBox();
            lblName = new Label();
            grpBooking = new GroupBox();
            btnDelete = new Button();
            btnBookTicket = new Button();
            cboSeat = new ComboBox();
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
            grpCustomer.SuspendLayout();
            grpBooking.SuspendLayout();
            grpSeatMap.SuspendLayout();
            grpSelected.SuspendLayout();
            grpResult.SuspendLayout();
            pnlLegend.SuspendLayout();
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
            grpCustomer.Location = new Point(20, 20);
            grpCustomer.Name = "grpCustomer";
            grpCustomer.Size = new Size(450, 80);
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
            txtCustomerName.TextChanged += textBox1_TextChanged;
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
            grpBooking.Controls.Add(btnDelete);
            grpBooking.Controls.Add(btnBookTicket);
            grpBooking.Controls.Add(cboSeat);
            grpBooking.Controls.Add(cboRoom);
            grpBooking.Controls.Add(cboMovie);
            grpBooking.Controls.Add(lblRoom);
            grpBooking.Controls.Add(lblSeat);
            grpBooking.Controls.Add(lblMovie);
            grpBooking.Font = new Font("Tahoma", 9F);
            grpBooking.Location = new Point(20, 106);
            grpBooking.Name = "grpBooking";
            grpBooking.Size = new Size(450, 200);
            grpBooking.TabIndex = 4;
            grpBooking.TabStop = false;
            grpBooking.Text = "Đặt Vé";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ButtonHighlight;
            btnDelete.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(313, 146);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 35);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
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
            btnBookTicket.Click += BtnBookTicket_Click;
            // 
            // cboSeat
            // 
            cboSeat.FormattingEnabled = true;
            cboSeat.Location = new Point(162, 89);
            cboSeat.Name = "cboSeat";
            cboSeat.Size = new Size(271, 26);
            cboSeat.TabIndex = 5;
            // 
            // cboRoom
            // 
            cboRoom.FormattingEnabled = true;
            cboRoom.Location = new Point(162, 56);
            cboRoom.Name = "cboRoom";
            cboRoom.Size = new Size(271, 26);
            cboRoom.TabIndex = 4;
            cboRoom.SelectedIndexChanged += CboRoom_SelectedIndexChanged;
            // 
            // cboMovie
            // 
            cboMovie.FormattingEnabled = true;
            cboMovie.Location = new Point(162, 23);
            cboMovie.Name = "cboMovie";
            cboMovie.Size = new Size(271, 26);
            cboMovie.TabIndex = 3;
            cboMovie.SelectedIndexChanged += CboMovie_SelectedIndexChanged;
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
            grpSeatMap.Location = new Point(20, 320);
            grpSeatMap.Name = "grpSeatMap";
            grpSeatMap.Size = new Size(450, 300);
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
            pnlSeatMap.Size = new Size(430, 265);
            pnlSeatMap.TabIndex = 0;
            // 
            // pnlBooked
            // 
            pnlBooked.BackColor = Color.FromArgb(244, 67, 54);
            pnlBooked.BorderStyle = BorderStyle.FixedSingle;
            pnlBooked.Location = new Point(547, 3);
            pnlBooked.Name = "pnlBooked";
            pnlBooked.Size = new Size(20, 20);
            pnlBooked.TabIndex = 3;
            // 
            // pnlVIP
            // 
            pnlVIP.BackColor = Color.FromArgb(255, 193, 7);
            pnlVIP.BorderStyle = BorderStyle.FixedSingle;
            pnlVIP.Location = new Point(419, 4);
            pnlVIP.Name = "pnlVIP";
            pnlVIP.Size = new Size(20, 20);
            pnlVIP.TabIndex = 2;
            pnlVIP.Paint += pnlVIP_Paint;
            // 
            // pnlNormal
            // 
            pnlNormal.BackColor = Color.FromArgb(33, 150, 243);
            pnlNormal.BorderStyle = BorderStyle.FixedSingle;
            pnlNormal.Location = new Point(244, 5);
            pnlNormal.Name = "pnlNormal";
            pnlNormal.Size = new Size(20, 20);
            pnlNormal.TabIndex = 1;
            // 
            // pnlRescue
            // 
            pnlRescue.BackColor = Color.FromArgb(76, 175, 80);
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
            grpSelected.Size = new Size(470, 250);
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
            grpResult.Location = new Point(492, 280);
            grpResult.Name = "grpResult";
            grpResult.Size = new Size(470, 340);
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
            txtResult.Size = new Size(440, 300);
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
            pnlLegend.Location = new Point(20, 631);
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
            // MovieTicketApp
            // 
            ClientSize = new Size(982, 673);
            Controls.Add(pnlLegend);
            Controls.Add(grpResult);
            Controls.Add(grpSelected);
            Controls.Add(grpSeatMap);
            Controls.Add(grpBooking);
            Controls.Add(grpCustomer);
            Controls.Add(lblLegendTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MovieTicketApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Phòng Vé";
            Load += MovieTicketApp_Load;
            grpCustomer.ResumeLayout(false);
            grpCustomer.PerformLayout();
            grpBooking.ResumeLayout(false);
            grpSeatMap.ResumeLayout(false);
            grpSelected.ResumeLayout(false);
            grpResult.ResumeLayout(false);
            grpResult.PerformLayout();
            pnlLegend.ResumeLayout(false);
            ResumeLayout(false);
        }
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
        private Button btnDelete;
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
    }

    #endregion
}