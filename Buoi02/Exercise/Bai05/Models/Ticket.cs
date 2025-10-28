namespace Exercise.Bai05.Models
{
    public class Ticket
    {
        public Movie Movie { get; set; }
        public int Room { get; set; }
        public Seat Seat { get; set; }
        public decimal Price { get; set; }

        public Ticket(Movie movie, int room, Seat seat)
        {
            Movie = movie;
            Room = room;
            Seat = seat;
            Price = movie.StandardPrice * seat.GetPriceMultiplier();
        }

        public override string ToString()
        {
            return $"{Seat.SeatCode} - Phòng {Room} - {Seat.GetTypeName()} - {Price:N0}đ";
        }
    }
}