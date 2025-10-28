using Exercise.Bai05.Models;
using System.Collections.Generic;
using System.Linq;

namespace Exercise.Bai05.Models
{
    public class Customer
    {
        public string FullName { get; set; }
        public List<Ticket> Tickets { get; set; }

        public Customer()
        {
            Tickets = new List<Ticket>();
            FullName = string.Empty;
        }

        public decimal GetTotalAmount()
        {
            return Tickets.Sum(t => t.Price);
        }

        public string GetTicketInfo()
        {
            return string.Join(", ", Tickets.Select(t => $"{t.Seat.SeatCode} (Phòng {t.Room})"));
        }
    }
}