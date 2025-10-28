using Exercise.Bai05.Models;
using Exercise.Bai05.BLL;
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
    public partial class TicketManagementForm : Form
    {
        private TicketService ticketService;
        private Customer currentCustomer;
        private FileService fileService;
        public TicketManagementForm()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            ticketService = new TicketService();
            fileService = new FileService();
            currentCustomer = new Customer();

            LoadDefaultMovies();
        }

        private void LoadDefaultMovies()
        {
                var defaultSeats = new List<string> { "A1", "A5", "C1", "C5" };
                var normalSeats = new List<string> { "A2", "A3", "A4", "C2", "C3", "C4" };
                var vipSeats = new List<string> { "B2", "B3", "B4" };

                var defaultMovies = new Dictionary<string, Movie>
                {
                    { "Đào, phở và piano", new Movie("Đào, phở và piano", 45000, new List<int> { 1, 2, 3 },
                        new List<string>(defaultSeats), new List<string>(normalSeats), new List<string>(vipSeats)) },
                    { "Mai", new Movie("Mai", 100000, new List<int> { 2, 3 },
                        new List<string>(defaultSeats), new List<string>(normalSeats), new List<string>(vipSeats)) },
                    { "Gặp lại chị bầu", new Movie("Gặp lại chị bầu", 70000, new List<int> { 1 },
                        new List<string>(defaultSeats), new List<string>(normalSeats), new List<string>(vipSeats)) },
                    { "Tarot", new Movie("Tarot", 90000, new List<int> { 3 },
                        new List<string>(defaultSeats), new List<string>(normalSeats), new List<string>(vipSeats)) }
                };
                ticketService.LoadMovies(defaultMovies);
                LoadMoviesToComboBox();
        }

        private void LoadMoviesToComboBox()
        {
            cboMovie.Items.Clear();
            foreach (var movie in ticketService.Movies.Values)
            {
                cboMovie.Items.Add(movie);
            }
        }

        private void cboMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMovie.SelectedItem is Movie selectedMovie)
            {
                cboRoom.Items.Clear();

                var validRooms = selectedMovie.Rooms.Where(r => r >= 1 && r <= 3).ToList();

                foreach (int room in validRooms)
                {
                    cboRoom.Items.Add($"Phòng {room}");
                }

                if (validRooms.Count > 0)
                    cboRoom.SelectedIndex = 0;
                else
                {
                    MessageBox.Show($"Phim '{selectedMovie.Name}' không có phòng chiếu hợp lệ (1–3).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboRoom.Items.Clear();
                    cboSeat.Items.Clear();
                }
            }
        }

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRoom.SelectedItem != null && cboMovie.SelectedItem != null)
            {
                Movie selectedMovie = (Movie)cboMovie.SelectedItem;
                int room = int.Parse(cboRoom.SelectedItem.ToString().Replace("Phòng ", ""));

                ticketService.UpdateSeatTypesForMovie(selectedMovie, room);

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
                        btnSeat.BackColor = Color.Red;
                        btnSeat.Enabled = false;
                    }
                    else
                    {
                        switch (seat.Type)
                        {
                            case SeatType.Rescue:
                                btnSeat.BackColor = Color.Green;
                                break;
                            case SeatType.Normal:
                                btnSeat.BackColor = Color.Blue;
                                break;
                            case SeatType.VIP:
                                btnSeat.BackColor = Color.Gold;
                                break;
                        }
                    }

                    btnSeat.ForeColor = Color.White;
                    btnSeat.FlatStyle = FlatStyle.Flat;

                    pnlSeatMap.Controls.Add(btnSeat);
                }
            }
        }


        private void btnBookTicket_Click(object sender, EventArgs e)
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

            string currentName = txtCustomerName.Text.Trim();
            if (currentCustomer.FullName != null && currentCustomer.FullName != currentName)
            {
                var confirmResult = MessageBox.Show(
                    $"Bạn đang đổi khách hàng từ '{currentCustomer.FullName}' sang '{currentName}'.\n" +
                    $"Đơn hàng cũ (Tổng: {currentCustomer.GetTotalAmount():N0}đ) sẽ được hoàn tất.\n" +
                    $"Bắt đầu đơn mới cho khách '{currentName}'?\n\n" +
                    $"Lưu ý: Ghế đã đặt sẽ KHÔNG được trả lại.",
                    "Xác Nhận Đổi Khách Hàng",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    CompleteCurrentOrder();
                    currentCustomer.FullName = currentName;
                }
                else
                {
                    txtCustomerName.Text = currentCustomer.FullName;
                    return;
                }
            }
            else if (currentCustomer.FullName == null)
            {
                currentCustomer.FullName = currentName;
            }

            Movie selectedMovie = (Movie)cboMovie.SelectedItem;
            int room = int.Parse(cboRoom.SelectedItem.ToString().Replace("Phòng ", ""));
            string seatCode = cboSeat.SelectedItem.ToString().Split(' ')[0];

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

        private void CompleteCurrentOrder()
        {
            currentCustomer = new Customer();

            lstSelectedTickets.Items.Clear();
            txtResult.Clear();
            lblTotal.Text = "Tổng Tiền: 0đ";
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (currentCustomer.Tickets.Count == 0)
            {
                CompleteCurrentOrder();
                txtCustomerName.Clear();
                MessageBox.Show("Đã làm mới!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmResult = MessageBox.Show(
                $"Đơn hàng hiện tại của '{currentCustomer.FullName}':\n" +
                $"• Số vé: {currentCustomer.Tickets.Count}\n" +
                $"• Tổng tiền: {currentCustomer.GetTotalAmount():N0}đ\n\n" +
                $"Bạn muốn:\n\n" +
                $"[YES] - Hoàn tất đơn và phục vụ khách mới\n" +
                $"        (Giữ ghế đã đặt, ghế vẫn màu đỏ)\n\n" +
                $"[NO] - Hủy đơn và trả lại ghế\n" +
                $"        (Ghế chuyển lại màu xanh, xóa khỏi thống kê)\n\n" +
                $"[CANCEL] - Không làm gì",
                "Xác Nhận Làm Mới",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                CompleteCurrentOrder();
                txtCustomerName.Clear();
                cboMovie.SelectedIndex = -1;
                cboRoom.Items.Clear();
                cboSeat.Items.Clear();
                pnlSeatMap.Controls.Clear();

                MessageBox.Show("Đã hoàn tất đơn hàng!\nSẵn sàng phục vụ khách tiếp theo.",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (confirmResult == DialogResult.No)
            {
                CancelCurrentOrder();
                txtCustomerName.Clear();
                cboMovie.SelectedIndex = -1;
                cboRoom.Items.Clear();
                cboSeat.Items.Clear();
                pnlSeatMap.Controls.Clear();

                MessageBox.Show("Đã hủy đơn hàng và trả lại ghế!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void CancelCurrentOrder()
        {
            foreach (var ticket in currentCustomer.Tickets)
            {
                var seat = ticketService.GetSeat(ticket.Room, ticket.Seat.SeatCode);
                if (seat != null)
                {
                    seat.IsBooked = false;

                    if (ticketService.SoldTicketsByMovie.ContainsKey(ticket.Movie.Name))
                    {
                        ticketService.SoldTicketsByMovie[ticket.Movie.Name].Remove(ticket);
                    }
                }
            }

            currentCustomer = new Customer();

            lstSelectedTickets.Items.Clear();
            txtResult.Clear();
            lblTotal.Text = "Tổng Tiền: 0đ";

            if (cboRoom.SelectedItem != null)
            {
                int room = int.Parse(cboRoom.SelectedItem.ToString().Replace("Phòng ", ""));
                LoadAvailableSeats(room);
                DrawSeatMap(room);
            }
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Bạn có muốn tải lại dữ liệu phim từ file input5.txt?\nDữ liệu hiện tại sẽ bị thay thế!",
                "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var movies = fileService.ReadMoviesFromFile();

                    if (movies.Count == 0)
                    {
                        MessageBox.Show("File không có dữ liệu phim hợp lệ!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    ticketService.ResetAllSeats();
                    currentCustomer = new Customer();

                    ticketService.LoadMovies(movies);
                    LoadMoviesToComboBox();

                    cboMovie.SelectedIndex = -1;
                    cboRoom.Items.Clear();
                    cboSeat.Items.Clear();
                    lstSelectedTickets.Items.Clear();
                    txtResult.Clear();
                    lblTotal.Text = "Tổng Tiền: 0đ";
                    pnlSeatMap.Controls.Clear();

                    MessageBox.Show($"Đã lấy thông tin {movies.Count} phim từ file!", "Thành Công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void menuResetAll_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Hành động này sẽ:\n" +
                "• Xóa TẤT CẢ đơn hàng\n" +
                "• Trả lại TẤT CẢ ghế đã đặt\n" +
                "• Reset toàn bộ hệ thống về trạng thái ban đầu\n\n" +
                "Bạn có CHẮC CHẮN muốn tiếp tục?",
                "Xác Nhận Reset Toàn Bộ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

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

                MessageBox.Show("Đã reset toàn bộ hệ thống!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var statistics = ticketService.CalculateStatistics();
                fileService.WriteStatisticsToFile(statistics, (progress) =>
                {
                    backgroundWorker1.ReportProgress(progress);
                });
                e.Result = true;
            }
            catch (Exception ex)
            {
                e.Result = ex;
            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Visible = false;
            lblProgress.Visible = false;

            btnStatistics.Enabled = true;
            btnBookTicket.Enabled = true;
            btnReset.Enabled = true;
            btnLoadFromFile.Enabled = true;

            if (e.Result is Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất file: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var result = MessageBox.Show(
                    "Xuất file thành công!\n\n", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            lblProgress.Text = $"{e.ProgressPercentage}%";

        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Xuất thống kê doanh thu ra file output5.txt?\n\n", "Xác Nhận Xuất File", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                btnStatistics.Enabled = false;
                btnBookTicket.Enabled = false;
                btnReset.Enabled = false;
                btnLoadFromFile.Enabled = false;

                progressBar.Value = 0;
                progressBar.Visible = true;
                lblProgress.Text = "0%";
                lblProgress.Visible = true;

                backgroundWorker1.RunWorkerAsync();
            }
        }

    }
}