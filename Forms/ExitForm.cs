using System;
using System.Linq; // Add this using directive
using System.Windows.Forms;

namespace SmartParkingSystem
{
    public partial class ExitForm : Form
    {
        public ExitForm()
        {
            InitializeComponent();
            lblExitTime.Text = "Exit Time: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            txtNumber.Text = "Enter vehicle number";
            txtNumber.ForeColor = System.Drawing.Color.Gray;
            UpdateAdminPanel();
        }

        private void ExitForm_Load(object sender, EventArgs e)
        {
        }

        private void txtNumber_Enter(object sender, EventArgs e)
        {
            if (txtNumber.Text == "Enter vehicle number")
            {
                txtNumber.Text = "";
                txtNumber.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string number = txtNumber.Text.Trim();
            if (string.IsNullOrEmpty(number))
            {
                MessageBox.Show("Please enter vehicle number.");
                return;
            }

            var vehicle = ParkingData.GetVehicleByNumber(number);
            if (vehicle == null)
            {
                MessageBox.Show("Vehicle not found or already exited.");
                return;
            }

            DateTime exitTime = DateTime.Now;
            vehicle.ExitTime = exitTime;
            ParkingData.UpdateVehicleExit(vehicle);

            TimeSpan duration = exitTime - vehicle.EntryTime;
            double totalHours = duration.TotalHours;

            // Round up every hour + 30min rule
            double rate = ParkingData.HourlyRates[vehicle.Type];
            double charge = 0;

            int fullHours = (int)Math.Floor(totalHours);
            double remainingMinutes = (totalHours - fullHours) * 60;

            charge = fullHours * rate;  // Charge for full hours

            if (remainingMinutes > 0) // There's a partial hour
            {
                if (remainingMinutes > 30)
                    charge += rate * 0.5;   // More than 30 min
                else
                    charge += rate;         
            }

            vehicle.Charge = charge;
            ParkingData.UpdateVehicleExit(vehicle); // Save final charge

            lblVehicleNumber.Text = $"Vehicle Number: {number}";
            lblDuration.Text = $"Duration: {duration.Days}d {duration.Hours}h {duration.Minutes}m";
            lblCharge.Text = $"Charge: Rs. {charge:F0}";

            UpdateAdminPanel();
            MessageBox.Show("Vehicle exited successfully.");
        }

        private void UpdateAdminPanel()
        {
            lblCurrentCount.Text = $"Current Parked: {ParkingData.GetCurrentVehicleCount()}";
            lblCars.Text = $"Cars: {ParkingData.GetAvailableSlots("Car")}";
            lblVans.Text = $"Vans: {ParkingData.GetAvailableSlots("Van")}";
            lblBikes.Text = $"Bikes: {ParkingData.GetAvailableSlots("Bike")}";
            lblThreewheels.Text = $"Threewheels: {ParkingData.GetAvailableSlots("Threewheel")}";

            gbAdmin.BackColor = ParkingData.GetCurrentVehicleCount() < ParkingData.TotalSlots.Values.Sum()
                ? System.Drawing.Color.LightGreen : System.Drawing.Color.Red;

            LoadVehicleTable();
        }

        private void LoadVehicleTable()
        {
            var vehicles = ParkingData.GetAllVehiclesHistory();
            dgvVehicles.DataSource = null;
            dgvVehicles.DataSource = vehicles;

            if (dgvVehicles.Columns.Count > 0)
            {
                dgvVehicles.Columns["Number"].HeaderText = "No.";
                dgvVehicles.Columns["Type"].HeaderText = "Type";
                dgvVehicles.Columns["EntryTime"].HeaderText = "Entry";
                dgvVehicles.Columns["ExitTime"].HeaderText = "Exit";
                dgvVehicles.Columns["Charge"].HeaderText = "Rs.";

                dgvVehicles.Columns["EntryTime"].DefaultCellStyle.Format = "HH:mm";
                dgvVehicles.Columns["ExitTime"].DefaultCellStyle.Format = "HH:mm";
                dgvVehicles.Columns["Charge"].DefaultCellStyle.Format = "F0";
            }
        }

        private void lblVehicleNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblExitTime_Click(object sender, EventArgs e)
        {

        }

        private void lblBikes_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblVans_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}