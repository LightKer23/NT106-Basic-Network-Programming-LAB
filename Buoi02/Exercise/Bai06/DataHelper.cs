using Microsoft.Data.Sqlite;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Exercise.Bai06
{
    public class DishInfo
    {
        public string? TenMonAn { get; set; }
        public string? TenNguoiDongGop { get; set; }
        public byte[]? HinhAnh { get; set; }
    }

    public class DataHelper
    {
        private string connectionString = "Data Source=WhatEatToday.db";

        public DataHelper()
        {
            SQLitePCL.Batteries_V2.Init();

            if (System.IO.File.Exists("WhatEatToday.db"))
                System.IO.File.Delete("WhatEatToday.db");

            if (!System.IO.File.Exists("WhatEatToday.db"))
            {
                System.IO.File.Create("WhatEatToday.db").Dispose();
            }
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string createNguoiDung = @"CREATE TABLE IF NOT EXISTS NguoiDung (
                    IDNCC INTEGER PRIMARY KEY AUTOINCREMENT,
                    HoVaTen TEXT NOT NULL,
                    QuyenHan TEXT NOT NULL);";

                string createMonAn = @"CREATE TABLE IF NOT EXISTS MonAn (
                    IDMA INTEGER PRIMARY KEY AUTOINCREMENT,
                    TenMonAn TEXT NOT NULL,
                    HinhAnh BLOB,
                    IDNCC INTERGER,
                    FOREIGN KEY (IDNCC) REFERENCES NguoiDung(IDNCC));";

                SqliteCommand command = new SqliteCommand(createNguoiDung, connection);
                command.ExecuteNonQuery();

                SqliteCommand command1 = new SqliteCommand(createMonAn, connection);
                command1.ExecuteNonQuery();
            }
        }

        public int CreateUser(string hoVaTen, string quyenHan)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string checkUser = "SELECT IDNCC FROM NguoiDung WHERE HoVaTen = @ten AND QuyenHan = @quyen";

                using (SqliteCommand cmd = new SqliteCommand(checkUser, connection))
                {
                    cmd.Parameters.AddWithValue("@ten", hoVaTen);
                    cmd.Parameters.AddWithValue("@quyen", quyenHan);
                    object? result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }

                string insertUser = "INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES (@ten, @quyen)";
                using (SqliteCommand cmd = new SqliteCommand(insertUser, connection))
                {
                    cmd.Parameters.AddWithValue("@ten", hoVaTen);
                    cmd.Parameters.AddWithValue("@quyen", quyenHan);
                    cmd.ExecuteNonQuery();
                }

                string getLastId = "SELECT last_insert_rowid()";
                using (var cmd = new SqliteCommand(getLastId, connection))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public bool AddDish(string tenMonAn, byte[] hinhAnh, int idNCC)
        {
            try
            {
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string insertDish = "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES (@tenMonAn, @hinhAnh, @idNCC)";
                    using (SqliteCommand cmd = new SqliteCommand(insertDish, connection))
                    {
                        cmd.Parameters.AddWithValue("@tenMonAn", tenMonAn);
                        cmd.Parameters.AddWithValue("@hinhAnh", hinhAnh != null ? (object)hinhAnh : DBNull.Value);
                        cmd.Parameters.AddWithValue("@idNCC", idNCC);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable GetAllDishes()
        {
            DataTable dt = new DataTable();

            using (SqliteConnection conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT m.IDMA, m.TenMonAn, n.HoVaTen 
                               FROM MonAn m 
                               INNER JOIN NguoiDung n ON m.IDNCC = n.IDNCC";

                using (var cmd = new SqliteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }

            return dt;
        }

        public DishInfo? GetDishById(int idma)
        {
            using (SqliteConnection conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT m.TenMonAn, m.HinhAnh, n.HoVaTen 
                               FROM MonAn m 
                               INNER JOIN NguoiDung n ON m.IDNCC = n.IDNCC 
                               WHERE m.IDMA = @id";

                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idma);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new DishInfo
                            {
                                TenMonAn = reader["TenMonAn"].ToString(),
                                TenNguoiDongGop = reader["HoVaTen"].ToString(),
                                HinhAnh = reader["HinhAnh"] != DBNull.Value ? (byte[])reader["HinhAnh"] : null
                            };
                        }
                    }
                }
            }
            return null;
        }

        public DishInfo? GetRandomDish()
        {
            using (SqliteConnection conn = new SqliteConnection(connectionString))
            {
                conn.Open();

                string countQuery = "SELECT COUNT(*) FROM MonAn";
                using (SqliteCommand cmd = new SqliteCommand(countQuery, conn))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 0)
                    {
                        return null;
                    }

                    Random rand = new Random();
                    int randomOffset = rand.Next(0, count);

                    string query = @"SELECT m.TenMonAn, m.HinhAnh, n.HoVaTen 
                                   FROM MonAn m 
                                   INNER JOIN NguoiDung n ON m.IDNCC = n.IDNCC 
                                   LIMIT 1 OFFSET @offset";

                    using (SqliteCommand selectCmd = new SqliteCommand(query, conn))
                    {
                        selectCmd.Parameters.AddWithValue("@offset", randomOffset);
                        using (var reader = selectCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new DishInfo
                                {
                                    TenMonAn = reader["TenMonAn"].ToString(),
                                    TenNguoiDongGop = reader["HoVaTen"].ToString(),
                                    HinhAnh = reader["HinhAnh"] != DBNull.Value ? (byte[])reader["HinhAnh"] : null
                                };
                            }
                        }
                    }
                }
            }
            return null;
        }

        public bool DeleteDish(int idma)
        {
            try
            {
                using (SqliteConnection conn = new SqliteConnection(connectionString))
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM MonAn WHERE IDMA = @id";
                    using (SqliteCommand cmd = new SqliteCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idma);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
