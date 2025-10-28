namespace Exercise.Bai05.Models;

public class MovieStatistics
{
    public string MovieName { get; set; }
    public int TotalSeats { get; set; }
    public int SoldTickets { get; set; }
    public int RemainingTickets { get; set; }
    public decimal SalesRate { get; set; }
    public decimal Revenue { get; set; }
    public int RevenueRank { get; set; }

    public MovieStatistics()
    {
        MovieName = string.Empty;
        TotalSeats = 0;
        SoldTickets = 0;
        RemainingTickets = 0;
        SalesRate = 0;
        Revenue = 0;
        RevenueRank = 0;
    }

    public void Calculate()
    {
        RemainingTickets = TotalSeats - SoldTickets;
        if (TotalSeats > 0)
        {
            SalesRate = (decimal)SoldTickets / TotalSeats * 100;
        }
    }

    public override string ToString()
    {
        return $"{MovieName}|{SoldTickets}|{RemainingTickets}|{SalesRate:F2}%|{Revenue:N0}đ|#{RevenueRank}";
    }
}