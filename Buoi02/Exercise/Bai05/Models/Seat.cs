namespace Exercise.Bai05.Models;
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
        public string MovieName { get; set; }

        public Seat(string seatCode, SeatType type)
        {
            SeatCode = seatCode;
            Type = type;
            IsBooked = false;
            MovieName = string.Empty;
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
