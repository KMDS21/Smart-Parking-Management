using System;

namespace SmartParkingSystem
{
    public class Vehicle
    {
        public string Type { get; set; } // e.g., "Car", "Bike", "Van", "Threewheel"
        public string Number { get; set; } // e.g., "ABC123"
        public DateTime EntryTime { get; set; }
        public DateTime? ExitTime { get; set; } // Nullable for vehicles that haven't exited
        public double Charge { get; set; } // Calculated on exit
    }
}