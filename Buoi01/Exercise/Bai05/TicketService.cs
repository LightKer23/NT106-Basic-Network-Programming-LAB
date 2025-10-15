using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Bai05
{
    public class TicketService
    {
        public Dictionary<string, Movie> Movies { get; private set; }

        public Dictionary<string, Seat> Seats { get; private set; }

        public TicketService()
        {
            InitializeMovies();
            InitializeSeats();
        }

        private void InitializeMovies()
        {
            Movies = new Dictionary<string, Movie>
            {
                { "Đào, phở và piano", new Movie("Đào, phở và piano", 45000, new List<int> { 1, 2, 3 }) },
                { "Mai", new Movie("Mai", 100000, new List<int> { 2, 3 }) },
                { "Gặp lại chị bầu", new Movie("Gặp lại chị bầu", 70000, new List<int> { 1 }) },
                { "Tarot", new Movie("Tarot", 90000, new List<int> { 3 }) }
            };
        }

        private void InitializeSeats()
        {
            Seats = new Dictionary<string, Seat>();

            string[] allSeats = {
                "A1", "A2", "A3", "A4", "A5",
                "B1", "B2", "B3", "B4", "B5",
                "C1", "C2", "C3", "C4", "C5"
            };

            string[] rescueSeats = { "A1", "A5", "C1", "C5" };

            string[] vipSeats = { "B2", "B3", "B4" };

            for (int room = 1; room <= 3; room++)
            {
                foreach (string seatCode in allSeats)
                {
                    SeatType type;

                    if (rescueSeats.Contains(seatCode))
                        type = SeatType.Rescue;
                    else if (vipSeats.Contains(seatCode))
                        type = SeatType.VIP;
                    else
                        type = SeatType.Normal;

                    string key = $"Room_{room}_{seatCode}";
                    Seats[key] = new Seat(seatCode, type);
                }
            }
        }

        public Seat GetSeat(int room, string seatCode)
        {
            string key = $"Room_{room}_{seatCode}";
            return Seats.ContainsKey(key) ? Seats[key] : null;
        }

        public bool CanBookTicket(List<Ticket> currentTickets, int newRoom)
        {
            if (currentTickets.Count == 0)
                return true;

            var bookedRooms = currentTickets.Select(t => t.Room).Distinct().ToList();

            if (bookedRooms.Count == 0)
                return true;

            if (bookedRooms.Count == 1)
            {
                return true;
            }

            if (bookedRooms.Count == 2)
            {
                return bookedRooms.Contains(newRoom);
            }

            return false;
        }

        public string BookTicket(Customer customer, Movie movie, int room, string seatCode)
        {
            if (!movie.Rooms.Contains(room))
            {
                return $"Phim '{movie.Name}' không chiếu ở phòng {room}";
            }

            Seat seat = GetSeat(room, seatCode);
            if (seat == null)
            {
                return "Ghế không tồn tại";
            }

            if (seat.IsBooked)
            {
                return $"Ghế {seatCode} phòng {room} đã được đặt";
            }

            if (!CanBookTicket(customer.Tickets, room))
            {
                return "Không thể chọn vé ở quá 2 phòng chiếu khác nhau";
            }

            Ticket ticket = new Ticket(movie, room, seat);
            customer.Tickets.Add(ticket);
            seat.IsBooked = true;

            return "Đặt vé thành công";
        }

        public void ResetAllSeats()
        {
            foreach (var seat in Seats.Values)
            {
                seat.IsBooked = false;
            }
        }

        public List<string> GetAvailableSeats(int room)
        {
            var availableSeats = new List<string>();
            string[] allSeats = {
                "A1", "A2", "A3", "A4", "A5",
                "B1", "B2", "B3", "B4", "B5",
                "C1", "C2", "C3", "C4", "C5"
            };

            foreach (string seatCode in allSeats)
            {
                Seat seat = GetSeat(room, seatCode);
                if (seat != null && !seat.IsBooked)
                {
                    availableSeats.Add(seatCode);
                }
            }

            return availableSeats;
        }
    }
}
