using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Bai05
{
    public class Customer
    {
        public string FullName { get; set; }
        public List<Ticket> Tickets { get; set; }

        public Customer()
        {
            Tickets = new List<Ticket>();
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
