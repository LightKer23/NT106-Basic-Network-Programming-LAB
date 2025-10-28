using Exercise.Bai05.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Exercise.Bai05.BLL;

public class FileService
{
    private const string INPUT_FILE = "input5.txt";
    private const string OUTPUT_FILE = "output5.txt";

    public Dictionary<string, Movie> ReadMoviesFromFile()
    {
        var movies = new Dictionary<string, Movie>();

        try
        {
            if (!File.Exists(INPUT_FILE))
            {
                CreateSampleInputFile();
            }
            else
            {
                string[] lines = File.ReadAllLines(INPUT_FILE, Encoding.UTF8);

                for (int i = 0; i < lines.Length; i += 6)
                {
                    if (i + 5 < lines.Length)
                    {
                        string movieName = lines[i].Trim();

                        decimal standardPrice = decimal.Parse(lines[i + 1].Trim());

                        string[] roomsStr = lines[i + 2].Trim().Split(',');
                        List<int> rooms = new List<int>();
                        foreach (string room in roomsStr)
                        {
                            if (int.TryParse(room.Trim(), out int roomNumber))
                            {
                                rooms.Add(roomNumber);
                            }
                        }

                        List<string> rescueSeats = ParseSeatList(lines[i + 3]);

                        List<string> normalSeats = ParseSeatList(lines[i + 4]);

                        List<string> vipSeats = ParseSeatList(lines[i + 5]);

                        movies[movieName] = new Movie(movieName, standardPrice, rooms,
                                                 rescueSeats, normalSeats, vipSeats);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Lỗi khi đọc file {INPUT_FILE}: {ex.Message}");
        }

        return movies;
    }

    private List<string> ParseSeatList(string seatListStr)
    {
        var seats = new List<string>();

        if (string.IsNullOrWhiteSpace(seatListStr))
            return seats;

        string[] seatArray = seatListStr.Trim().Split(',');
        foreach (string seat in seatArray)
        {
            string trimmedSeat = seat.Trim();
            if (!string.IsNullOrEmpty(trimmedSeat))
            {
                seats.Add(trimmedSeat);
            }
        }

        return seats;
    }

    private void CreateSampleInputFile()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Đào, phở và piano");
        sb.AppendLine("45000");
        sb.AppendLine("1,2,3");
        sb.AppendLine("A1, A5, C1, C5");        
        sb.AppendLine("A2, A3, A4, C2, C3, C4"); 
        sb.AppendLine("B2, B3, B4");            

        sb.AppendLine("Mai");
        sb.AppendLine("100000");
        sb.AppendLine("2,3");
        sb.AppendLine("A1, A5, C1, C5");
        sb.AppendLine("A2, A3, A4, C2, C3, C4");
        sb.AppendLine("B2, B3, B4");

        sb.AppendLine("Gặp lại chị bầu");
        sb.AppendLine("70000");
        sb.AppendLine("1");
        sb.AppendLine("A1, A5, C1, C5");
        sb.AppendLine("A2, A3, A4, C2, C3, C4");
        sb.AppendLine("B2, B3, B4");

        sb.AppendLine("Tarot");
        sb.AppendLine("90000");
        sb.AppendLine("3");
        sb.AppendLine("A1, A5, C1, C5");
        sb.AppendLine("A2, A3, A4, C2, C3, C4");
        sb.AppendLine("B2, B3, B4");

        File.WriteAllText(INPUT_FILE, sb.ToString(), Encoding.UTF8);
    }

    public void WriteStatisticsToFile(List<MovieStatistics> statistics, Action<int>? progressCallback = null)
    {
        try
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("=".PadRight(120, '='));
            sb.AppendLine("\t\t\tTHỐNG KÊ DOANH THU VÀ BÁN VÉ THEO PHIM");
            sb.AppendLine("=".PadRight(120, '='));
            sb.AppendLine();
            sb.AppendLine($"{"Tên Phim",-35} {"Vé Bán",-12} {"Vé Tồn",-12} {"Tỉ Lệ",-12} {"Doanh Thu",-20} {"Xếp Hạng",-10}");
            sb.AppendLine("-".PadRight(120, '-'));

            int totalItems = statistics.Count;

            for (int i = 0; i < totalItems; i++)
            {
                var stat = statistics[i];
                sb.AppendLine($"{stat.MovieName, -35}" + $"{stat.SoldTickets, 6}" + $"{stat.RemainingTickets, 14}" + $"{stat.SalesRate.ToString("F2") + "%", 12}" + $"{stat.Revenue.ToString("N0") + "đ", 17}" + $"{stat.RevenueRank, 20}");

                if (progressCallback != null)
                {
                    int progress = (int)((i + 1) * 100.0 / totalItems);
                    progressCallback(progress);
                    System.Threading.Thread.Sleep(200);
                }
            }

            sb.AppendLine("-".PadRight(120, '-'));
            sb.AppendLine();

            File.WriteAllText(OUTPUT_FILE, sb.ToString(), Encoding.UTF8);
        }
        catch (Exception ex)
        {
            throw new Exception($"Lỗi khi ghi file {OUTPUT_FILE}: {ex.Message}");
        }
    }

    public bool InputFileExists()
    {
        return File.Exists(INPUT_FILE);
    }

    public bool OutputFileExists()
    {
        return File.Exists(OUTPUT_FILE);
    }
}