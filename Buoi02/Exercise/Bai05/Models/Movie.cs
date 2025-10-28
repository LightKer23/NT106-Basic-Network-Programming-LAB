using System.Collections.Generic;
using System.Linq;

namespace Exercise.Bai05.Models
{
    public class Movie
    {
        public string Name { get; set; }
        public decimal StandardPrice { get; set; }
        public List<int> Rooms { get; set; }

        public List<string> RescueSeats { get; set; }    // Danh sách ghế vớt: A1, A5, C1, C5
        public List<string> NormalSeats { get; set; }    // Danh sách ghế thường: A2, A3, A4, C2, C3, C4
        public List<string> VIPSeats { get; set; }       // Danh sách ghế VIP: B2, B3, B4

        public Movie(string name, decimal standardPrice, List<int> rooms,
                     List<string> rescueSeats, List<string> normalSeats, List<string> vipSeats)
        {
            Name = name;
            StandardPrice = standardPrice;
            Rooms = rooms;
            RescueSeats = rescueSeats ?? new List<string>();
            NormalSeats = normalSeats ?? new List<string>();
            VIPSeats = vipSeats ?? new List<string>();
        }

        public int GetTotalTickets()
        {
            return Rooms.Count * 15;
        }

        public SeatType GetSeatType(string seatCode)
        {
            if (RescueSeats.Contains(seatCode))
                return SeatType.Rescue;
            else if (VIPSeats.Contains(seatCode))
                return SeatType.VIP;
            else if (NormalSeats.Contains(seatCode))
                return SeatType.Normal;
            else
                return SeatType.Normal;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}