using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SmartParkingSystem
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();

            lblEntryTime.Text = "Entry Time: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            txtNumber.Text = "Enter vehicle number";
            txtNumber.ForeColor = Color.Gray;

            UpdateAdminPanel();
        }

        private void txtNumber_Enter(object sender, EventArgs e)
        {
            if (txtNumber.Text == "Enter vehicle number")
            {
                txtNumber.Text = "";
                txtNumber.ForeColor = Color.Black;
            }
        }

        private bool IsValidVehicleNumber(string number)
        {
            string pattern = @"^([A-Z]{2,3}-\d{4}|\d{3}-\d{4})$";
            return Regex.IsMatch(number, pattern);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string type = cbType.SelectedItem?.ToString();
            string number = txtNumber.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(type) || string.IsNullOrEmpty(number) || type == "Select Vehicle")
            {
                MessageBox.Show("Please select vehicle type and enter number.");
                return;
            }

            if (!IsValidVehicleNumber(number))
            {
                MessageBox.Show(
                    "Invalid Sri Lankan vehicle number format.\n\n" +
                    "Valid Examples:\n" +
                    "CAL-9426\n" +
                    "NE-6532\n" +
                    "253-5645",
                    "Invalid Vehicle Number",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (ParkingData.IsVehicleParked(number))
            {
                MessageBox.Show("Vehicle is already parked.");
                return;
            }

            int available = ParkingData.GetAvailableSlots(type);
            if (available <= 0)
            {
                MessageBox.Show($"No available slots for {type}.");
                return;
            }

            Vehicle vehicle = new Vehicle
            {
                Type = type,
                Number = number,
                EntryTime = DateTime.Now
            };

            ParkingData.AddVehicle(vehicle);

            MessageBox.Show("Vehicle recorded successfully.");
            UpdateAdminPanel();
            this.Close();
        }

        private void UpdateAdminPanel()
        {
            lblCurrentCount.Text = $"Current Parked: {ParkingData.GetCurrentVehicleCount()}";
            lblCars.Text = $"Cars: {ParkingData.GetAvailableSlots("Car")}";
            lblVans.Text = $"Vans: {ParkingData.GetAvailableSlots("Van")}";
            lblBikes.Text = $"Bikes: {ParkingData.GetAvailableSlots("Bike")}";
            lblThreewheels.Text = $"Threewheels: {ParkingData.GetAvailableSlots("Threewheel")}";

            gbAdmin.BackColor =
                ParkingData.GetCurrentVehicleCount() < ParkingData.TotalSlots.Values.Sum()
                ? Color.LightGreen
                : Color.Red;

            LoadVehicleTable();
        }

        private void LoadVehicleTable()
        {
            var vehicles = ParkingData.GetAllVehiclesHistory();

            dgvVehicles.DataSource = null;
            dgvVehicles.DataSource = vehicles;

            if (dgvVehicles.Columns.Count > 0)
            {
                dgvVehicles.Columns["Number"].HeaderText = "Vehicle No.";
                dgvVehicles.Columns["Type"].HeaderText = "Type";
                dgvVehicles.Columns["EntryTime"].HeaderText = "Entry Time";
                dgvVehicles.Columns["ExitTime"].HeaderText = "Exit Time";
                dgvVehicles.Columns["Charge"].HeaderText = "Charge (Rs.)";
            }
        }

        private void dgvVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
