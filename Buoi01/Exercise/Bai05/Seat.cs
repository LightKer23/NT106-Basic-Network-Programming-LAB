using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Bai05
{
    public enum SeatType
    {
        Rescue,    // Vé vớt - 1/4 giá
        Normal,    // Vé thường - 1x giá
        VIP        // Vé VIP - 2x giá
    }

    public class Seat
    {
        public string SeatCode { get; set; }
        public SeatType Type { get; set; }
        public bool IsBooked { get; set; }

        public Seat(string seatCode, SeatType type)
        {
            SeatCode = seatCode;
            Type = type;
            IsBooked = false;
        }

        public decimal GetPriceMultiplier()
        {
            return Type switch
            {
                SeatType.Rescue => 0.25m,
                SeatType.Normal => 1.0m,
                SeatType.VIP => 2.0m,
                _ => 1.0m
            };
        }

        public string GetTypeName()
        {
            return Type switch
            {
                SeatType.Rescue => "Vé vớt",
                SeatType.Normal => "Vé thường",
                SeatType.VIP => "Vé VIP",
                _ => "Không xác định"
            };
        }
    }
}
