using Exercise.Bai05.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise.Bai05
{
    public class TicketService
    {
        public Dictionary<string, Movie> Movies { get; private set; }

        public Dictionary<string, Seat> Seats { get; private set; }

        public Dictionary<string, List<Ticket>> SoldTicketsByMovie { get; private set; }

        public TicketService()
        {
            Movies = new Dictionary<string, Movie>();
            SoldTicketsByMovie = new Dictionary<string, List<Ticket>>();
            InitializeSeats();
        }

        public void LoadMovies(Dictionary<string, Movie> movies)
        {
            Movies = movies;

            foreach (var movieName in Movies.Keys)
            {
                if (!SoldTicketsByMovie.ContainsKey(movieName))
                {
                    SoldTicketsByMovie[movieName] = new List<Ticket>();
                }
            }
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

        public Seat? GetSeat(int room, string seatCode)
        {
            if (room < 1 || room > 3)
                return null;

            string[] validSeats = {
                "A1","A2","A3","A4","A5",
                "B1","B2","B3","B4","B5",
                "C1","C2","C3","C4","C5"
            };
            if (!validSeats.Contains(seatCode))
                return null;

            string key = $"Room_{room}_{seatCode}";
            return Seats.ContainsKey(key) ? Seats[key] : null;
        }

        public void UpdateSeatTypesForMovie(Movie movie, int room)
        {
            string[] allSeats = {
                "A1", "A2", "A3", "A4", "A5",
                "B1", "B2", "B3", "B4", "B5",
                "C1", "C2", "C3", "C4", "C5"
            };

            foreach (string seatCode in allSeats)
            {
                var seat = GetSeat(room, seatCode);
                if (seat != null && !seat.IsBooked)
                {
                    seat.Type = movie.GetSeatType(seatCode);
                }
            }
        }

        public bool CanBookTicket(List<Ticket> currentTickets, int newRoom)
        {
            if (currentTickets.Count == 0)
                return true;

            var bookedRooms = currentTickets.Select(t => t.Room).Distinct().ToList();

            if (bookedRooms.Count < 2)
                return true;

            return bookedRooms.Contains(newRoom);
        }

        public string BookTicket(Customer customer, Movie movie, int room, string seatCode)
        {
            if (room < 1 || room > 3)
                return $"Phòng {room} không hợp lệ (chỉ từ 1 đến 3)";

            string[] validSeats = {
                "A1","A2","A3","A4","A5",
                "B1","B2","B3","B4","B5",   
                "C1","C2","C3","C4","C5"
            };
            if (!validSeats.Contains(seatCode))
                return $"Ghế {seatCode} không hợp lệ (chỉ A1–A5, B1–B5, C1–C5)";

            if (!movie.Rooms.Contains(room))
                return $"Phim '{movie.Name}' không chiếu ở phòng {room}";

            Seat seat = GetSeat(room, seatCode);
            if (seat == null)
                return "Ghế không tồn tại";

            if (seat.IsBooked)
                return $"Ghế {seatCode} phòng {room} đã được đặt";

            if (!CanBookTicket(customer.Tickets, room))
                return "Không thể chọn vé ở quá 2 phòng chiếu khác nhau";

            seat.Type = movie.GetSeatType(seatCode);

            Ticket ticket = new Ticket(movie, room, seat);
            customer.Tickets.Add(ticket);
            seat.IsBooked = true;
            seat.MovieName = movie.Name;

            if (!SoldTicketsByMovie.ContainsKey(movie.Name))
                SoldTicketsByMovie[movie.Name] = new List<Ticket>();

            SoldTicketsByMovie[movie.Name].Add(ticket);

            return "Đặt vé thành công";
        }

        public void ResetAllSeats()
        {
            foreach (var seat in Seats.Values)
            {
                seat.IsBooked = false;
                seat.MovieName = string.Empty;
            }

            foreach (var key in SoldTicketsByMovie.Keys.ToList())
            {
                SoldTicketsByMovie[key] = new List<Ticket>();
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
                Seat? seat = GetSeat(room, seatCode);
                if (seat != null && !seat.IsBooked)
                    availableSeats.Add(seatCode);
            }

            return availableSeats;
        }

        public List<MovieStatistics> CalculateStatistics()
        {
            var statistics = new List<MovieStatistics>();

            foreach (var movie in Movies.Values)
            {
                var stat = new MovieStatistics
                {
                    MovieName = movie.Name
                };

                stat.TotalSeats = movie.GetTotalTickets();

                if (SoldTicketsByMovie.ContainsKey(movie.Name))
                {
                    var soldTickets = SoldTicketsByMovie[movie.Name];
                    stat.SoldTickets = soldTickets.Count;
                    stat.Revenue = soldTickets.Sum(t => t.Price);
                }

                stat.Calculate();
                statistics.Add(stat);
            }

            var rankedStats = statistics.OrderByDescending(s => s.Revenue).ToList();
            for (int i = 0; i < rankedStats.Count; i++)
            {
                rankedStats[i].RevenueRank = i + 1;
            }

            return rankedStats;
        }
    }
}
