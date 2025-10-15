using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise.Bai05
{
    public partial class MovieTicketApp : Form
    {
        private TicketService ticketService;
        private Customer currentCustomer;
        public MovieTicketApp()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            ticketService = new TicketService();
            currentCustomer = new Customer();

            cboMovie.Items.Clear();
            foreach (var movie in ticketService.Movies.Values)
            {
                cboMovie.Items.Add(movie);
            }
        }

        private void CboMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMovie.SelectedItem is Movie selectedMovie)
            {
                cboRoom.Items.Clear();
                foreach (int room in selectedMovie.Rooms)
                {
                    cboRoom.Items.Add($"Phòng {room}");
                }

                if (cboRoom.Items.Count > 0)
                {
                    cboRoom.SelectedIndex = 0;
                }
            }
        }

        private void CboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRoom.SelectedItem != null)
            {
                int room = int.Parse(cboRoom.SelectedItem.ToString().Replace("Phòng ", ""));
                LoadAvailableSeats(room);
                DrawSeatMap(room);
            }
        }

        private void LoadAvailableSeats(int room)
        {
            cboSeat.Items.Clear();
            var availableSeats = ticketService.GetAvailableSeats(room);

            foreach (string seatCode in availableSeats)
            {
                Seat seat = ticketService.GetSeat(room, seatCode);
                cboSeat.Items.Add($"{seatCode} ({seat.GetTypeName()})");
            }

            if (cboSeat.Items.Count > 0)
            {
                cboSeat.SelectedIndex = 0;
            }
        }

        private void DrawSeatMap(int room)
        {
            pnlSeatMap.Controls.Clear();

            string[] rows = { "A", "B", "C" };
            int buttonSize = 60;
            int spacing = 10;

            Label lblScreen = new Label
            {
                Text = "MÀN HÌNH",
                Location = new Point(120, 10),
                Size = new Size(200, 30),
                Font = new Font("Arial", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.LightGray
            };
            pnlSeatMap.Controls.Add(lblScreen);

            for (int i = 0; i < rows.Length; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    string seatCode = $"{rows[i]}{j}";
                    Seat seat = ticketService.GetSeat(room, seatCode);

                    Button btnSeat = new Button
                    {
                        Text = seatCode,
                        Size = new Size(buttonSize, buttonSize),
                        Location = new Point(j * (buttonSize + spacing) + 30,
                                            i * (buttonSize + spacing) + 50),
                        Font = new Font("Arial", 9, FontStyle.Bold)
                    };

                    if (seat.IsBooked)
                    {
                        btnSeat.BackColor = Color.FromArgb(244, 67, 54); // Đỏ - Đã đặt
                        btnSeat.Enabled = false;
                    }
                    else
                    {
                        switch (seat.Type)
                        {
                            case SeatType.Rescue:
                                btnSeat.BackColor = Color.FromArgb(76, 175, 80);
                                break;
                            case SeatType.Normal:
                                btnSeat.BackColor = Color.FromArgb(33, 150, 243);
                                break;
                            case SeatType.VIP:
                                btnSeat.BackColor = Color.FromArgb(255, 193, 7);
                                break;
                        }
                    }

                    btnSeat.ForeColor = Color.White;
                    btnSeat.FlatStyle = FlatStyle.Flat;

                    pnlSeatMap.Controls.Add(btnSeat);
                }
            }
        }

        private void BtnBookTicket_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboMovie.SelectedItem == null || cboRoom.SelectedItem == null || cboSeat.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Movie selectedMovie = (Movie)cboMovie.SelectedItem;
            int room = int.Parse(cboRoom.SelectedItem.ToString().Replace("Phòng ", ""));
            string seatCode = cboSeat.SelectedItem.ToString().Split(' ')[0];

            currentCustomer.FullName = txtCustomerName.Text;

            string result = ticketService.BookTicket(currentCustomer, selectedMovie, room, seatCode);

            if (result == "Đặt vé thành công")
            {
                MessageBox.Show(result, "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateTicketList();
                LoadAvailableSeats(room);
                DrawSeatMap(room);
            }
            else
            {
                MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTicketList()
        {
            lstSelectedTickets.Items.Clear();

            foreach (var ticket in currentCustomer.Tickets)
            {
                lstSelectedTickets.Items.Add(ticket.ToString());
            }

            lblTotal.Text = $"Tổng Tiền: {currentCustomer.GetTotalAmount():N0}đ";

            if (currentCustomer.Tickets.Count > 0)
            {
                txtResult.Text = "========== THÔNG TIN THANH TOÁN ==========\r\n\r\n";
                txtResult.Text += $"Khách hàng: {currentCustomer.FullName}\r\n";
                txtResult.Text += $"Phim: {currentCustomer.Tickets[0].Movie.Name}\r\n\r\n";
                txtResult.Text += "Chi tiết vé:\r\n";
                txtResult.Text += "─────────────────────────────────────────\r\n";

                foreach (var ticket in currentCustomer.Tickets)
                {
                    txtResult.Text += $"* Ghế {ticket.Seat.SeatCode} - Phòng {ticket.Room}\r\n";
                    txtResult.Text += $"  Loại: {ticket.Seat.GetTypeName()}\r\n";
                    txtResult.Text += $"  Giá: {ticket.Price:N0}đ\r\n\r\n";
                }

                txtResult.Text += "─────────────────────────────────────────\r\n";
                txtResult.Text += $"TỔNG CỘNG: {currentCustomer.GetTotalAmount():N0}đ\r\n";
                txtResult.Text += "=========================================";
            }
        }

        private void lblRoom_Click(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlRescue_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MovieTicketApp_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlVIP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa toàn bộ?",
                "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                ticketService.ResetAllSeats();
                currentCustomer = new Customer();

                txtCustomerName.Clear();
                cboMovie.SelectedIndex = -1;
                cboRoom.Items.Clear();
                cboSeat.Items.Clear();
                lstSelectedTickets.Items.Clear();
                txtResult.Clear();
                lblTotal.Text = "Tổng Tiền: 0đ";
                pnlSeatMap.Controls.Clear();

                MessageBox.Show("Đã xóa!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
