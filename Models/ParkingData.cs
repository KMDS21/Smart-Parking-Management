using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace SmartParkingSystem
{
    public static class ParkingData
    {
        private static string connectionString = "Server=localhost;Port=3306;Database=SmartParkingDB;Uid=root;Pwd=;";

        public static readonly Dictionary<string, int> TotalSlots = new Dictionary<string, int>
        {
            { "Car",        80 },  
            { "Van",        50 },   
            { "Bike",       100 },  
            { "Threewheel", 70 }    
        };

        public static readonly Dictionary<string, double> HourlyRates = new Dictionary<string, double>
        {
            { "Car",        100.0 },
            { "Van",        150.0 },
            { "Bike",        50.0 },
            { "Threewheel", 75.0 }
        };

        public static void AddVehicle(Vehicle vehicle)
        {
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Vehicles (Type, Number, EntryTime, ExitTime, Charge) VALUES (@Type, @Number, @EntryTime, @ExitTime, @Charge)";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Type", vehicle.Type);
                    cmd.Parameters.AddWithValue("@Number", vehicle.Number);
                    cmd.Parameters.AddWithValue("@EntryTime", vehicle.EntryTime);
                    cmd.Parameters.AddWithValue("@ExitTime", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Charge", 0.0);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateVehicleExit(Vehicle vehicle)
        {
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Vehicles SET ExitTime = @ExitTime, Charge = @Charge WHERE Number = @Number";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ExitTime", vehicle.ExitTime.HasValue ? (object)vehicle.ExitTime.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@Charge", vehicle.Charge);
                    cmd.Parameters.AddWithValue("@Number", vehicle.Number);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static Vehicle GetVehicleByNumber(string number)
        {
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Type, Number, EntryTime, ExitTime, Charge FROM Vehicles WHERE Number = @Number AND ExitTime IS NULL";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Number", number);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Vehicle
                            {
                                Type = reader.GetString("Type"),
                                Number = reader.GetString("Number"),
                                EntryTime = reader.GetDateTime("EntryTime"),
                                ExitTime = reader.IsDBNull(reader.GetOrdinal("ExitTime")) ? (DateTime?)null : reader.GetDateTime("ExitTime"),
                                Charge = reader.GetDouble("Charge")
                            };
                        }
                        return null;
                    }
                }
            }
        }

        public static bool IsVehicleParked(string number)
        {
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Vehicles WHERE Number = @Number AND ExitTime IS NULL";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Number", number);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        public static int GetCurrentVehicleCount()
        {
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Vehicles WHERE ExitTime IS NULL";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public static int GetAvailableSlots(string type)
        {
            int total = TotalSlots[type];
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Vehicles WHERE Type = @Type AND ExitTime IS NULL";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Type", type);
                    int occupied = Convert.ToInt32(cmd.ExecuteScalar());
                    return total - occupied;
                }
            }
        }
        public static bool ValidateAdmin(string username, string password)
        {
            using (var con = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM Admins WHERE Username = @u AND Password = @p";
                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        public static List<Vehicle> GetAllVehiclesHistory()
        {
            var list = new List<Vehicle>();
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
            SELECT Type, Number, EntryTime, ExitTime, Charge 
            FROM Vehicles 
            ORDER BY EntryTime DESC";
                using (var cmd = new MySqlCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Vehicle
                        {
                            Type = reader.GetString("Type"),
                            Number = reader.GetString("Number"),
                            EntryTime = reader.GetDateTime("EntryTime"),
                            ExitTime = reader.IsDBNull(reader.GetOrdinal("ExitTime")) ? (DateTime?)null : reader.GetDateTime("ExitTime"),
                            Charge = reader.GetDouble("Charge")
                        });
                    }
                }
            }
            return list;
        }
    }
}