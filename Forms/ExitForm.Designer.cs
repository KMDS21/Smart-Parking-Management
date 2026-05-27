namespace SmartParkingSystem
{
    partial class ExitForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitForm));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblThreewheels = new System.Windows.Forms.Label();
            this.lblBikes = new System.Windows.Forms.Label();
            this.lblVans = new System.Windows.Forms.Label();
            this.lblCars = new System.Windows.Forms.Label();
            this.lblCurrentCount = new System.Windows.Forms.Label();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.lblCharge = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblVehicleNumber = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblExitTime = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblVehicleNumberInput = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.gbAdmin.SuspendLayout();
            this.gbResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.SuspendLayout();
          
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.gbAdmin);
            this.pnlMain.Controls.Add(this.gbResults);
            this.pnlMain.Controls.Add(this.btnSubmit);
            this.pnlMain.Controls.Add(this.lblExitTime);
            this.pnlMain.Controls.Add(this.txtNumber);
            this.pnlMain.Controls.Add(this.lblVehicleNumberInput);
            this.pnlMain.Location = new System.Drawing.Point(29, 109);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(738, 500);
            this.pnlMain.TabIndex = 0;
            
            this.gbAdmin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbAdmin.Controls.Add(this.label1);
            this.gbAdmin.Controls.Add(this.lblThreewheels);
            this.gbAdmin.Controls.Add(this.lblBikes);
            this.gbAdmin.Controls.Add(this.lblVans);
            this.gbAdmin.Controls.Add(this.lblCars);
            this.gbAdmin.Controls.Add(this.lblCurrentCount);
            this.gbAdmin.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdmin.Location = new System.Drawing.Point(452, 125);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(270, 331);
            this.gbAdmin.TabIndex = 1;
            this.gbAdmin.TabStop = false;
            this.gbAdmin.Text = "Parking Status";
            this.toolTip1.SetToolTip(this.gbAdmin, "Real-time parking slot availability");
           
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14F);
            this.label1.Location = new System.Drawing.Point(29, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Availabel Slots Count";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
           
            this.lblThreewheels.AutoSize = true;
            this.lblThreewheels.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblThreewheels.Location = new System.Drawing.Point(7, 296);
            this.lblThreewheels.Name = "lblThreewheels";
            this.lblThreewheels.Size = new System.Drawing.Size(159, 22);
            this.lblThreewheels.TabIndex = 4;
            this.lblThreewheels.Text = "Threewheels: 20";
            
            this.lblBikes.AutoSize = true;
            this.lblBikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblBikes.Location = new System.Drawing.Point(9, 252);
            this.lblBikes.Name = "lblBikes";
            this.lblBikes.Size = new System.Drawing.Size(93, 22);
            this.lblBikes.TabIndex = 3;
            this.lblBikes.Text = "Bikes: 50";
            this.lblBikes.Click += new System.EventHandler(this.lblBikes_Click);
           
            this.lblVans.AutoSize = true;
            this.lblVans.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblVans.Location = new System.Drawing.Point(9, 207);
            this.lblVans.Name = "lblVans";
            this.lblVans.Size = new System.Drawing.Size(89, 22);
            this.lblVans.TabIndex = 2;
            this.lblVans.Text = "Vans: 20";
            this.lblVans.Click += new System.EventHandler(this.lblVans_Click);
        
            this.lblCars.AutoSize = true;
            this.lblCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblCars.Location = new System.Drawing.Point(9, 159);
            this.lblCars.Name = "lblCars";
            this.lblCars.Size = new System.Drawing.Size(86, 22);
            this.lblCars.TabIndex = 1;
            this.lblCars.Text = "Cars: 40";
            
            this.lblCurrentCount.AutoSize = true;
            this.lblCurrentCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblCurrentCount.ForeColor = System.Drawing.Color.Red;
            this.lblCurrentCount.Location = new System.Drawing.Point(9, 50);
            this.lblCurrentCount.Name = "lblCurrentCount";
            this.lblCurrentCount.Size = new System.Drawing.Size(173, 24);
            this.lblCurrentCount.TabIndex = 0;
            this.lblCurrentCount.Text = "Current Parked: 0";
           
            this.gbResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbResults.Controls.Add(this.lblCharge);
            this.gbResults.Controls.Add(this.lblDuration);
            this.gbResults.Controls.Add(this.lblVehicleNumber);
            this.gbResults.Font = new System.Drawing.Font("Multicolore ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResults.Location = new System.Drawing.Point(24, 227);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(404, 229);
            this.gbResults.TabIndex = 4;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Exit Details";
            
            this.lblCharge.AutoSize = true;
            this.lblCharge.BackColor = System.Drawing.SystemColors.Info;
            this.lblCharge.Font = new System.Drawing.Font("Aptos Narrow", 25F, System.Drawing.FontStyle.Bold);
            this.lblCharge.ForeColor = System.Drawing.Color.Red;
            this.lblCharge.Location = new System.Drawing.Point(81, 170);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(245, 43);
            this.lblCharge.TabIndex = 2;
            this.lblCharge.Text = "Charge: Rs. 0.00";
            
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Aptos Narrow", 17F, System.Drawing.FontStyle.Bold);
            this.lblDuration.ForeColor = System.Drawing.Color.Red;
            this.lblDuration.Location = new System.Drawing.Point(15, 114);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(109, 29);
            this.lblDuration.TabIndex = 1;
            this.lblDuration.Text = "Duration : ";
            
            this.lblVehicleNumber.AutoSize = true;
            this.lblVehicleNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleNumber.Font = new System.Drawing.Font("Aptos Narrow", 17F, System.Drawing.FontStyle.Bold);
            this.lblVehicleNumber.ForeColor = System.Drawing.Color.Red;
            this.lblVehicleNumber.Location = new System.Drawing.Point(15, 59);
            this.lblVehicleNumber.Name = "lblVehicleNumber";
            this.lblVehicleNumber.Size = new System.Drawing.Size(180, 29);
            this.lblVehicleNumber.TabIndex = 0;
            this.lblVehicleNumber.Text = "Vehicle Number : ";
            this.lblVehicleNumber.Click += new System.EventHandler(this.lblVehicleNumber_Click);
            
            this.btnSubmit.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Multicolore ", 16F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(141, 157);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(175, 44);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit Exit";
            this.toolTip1.SetToolTip(this.btnSubmit, "Click to process vehicle exit and calculate charge");
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
           
            this.lblExitTime.AutoSize = true;
            this.lblExitTime.Font = new System.Drawing.Font("Multicolore ", 14F, System.Drawing.FontStyle.Bold);
            this.lblExitTime.Location = new System.Drawing.Point(21, 109);
            this.lblExitTime.Name = "lblExitTime";
            this.lblExitTime.Size = new System.Drawing.Size(112, 22);
            this.lblExitTime.TabIndex = 2;
            this.lblExitTime.Text = "Exit Time: ";
            this.lblExitTime.Click += new System.EventHandler(this.lblExitTime_Click);
             
            this.txtNumber.Font = new System.Drawing.Font("Multicolore ", 14F, System.Drawing.FontStyle.Bold);
            this.txtNumber.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtNumber.Location = new System.Drawing.Point(211, 63);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(211, 29);
            this.txtNumber.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtNumber, "Enter the vehicle number to exit");
            this.txtNumber.Enter += new System.EventHandler(this.txtNumber_Enter);
           
            this.lblVehicleNumberInput.AutoSize = true;
            this.lblVehicleNumberInput.Font = new System.Drawing.Font("Multicolore ", 14F, System.Drawing.FontStyle.Bold);
            this.lblVehicleNumberInput.Location = new System.Drawing.Point(21, 66);
            this.lblVehicleNumberInput.Name = "lblVehicleNumberInput";
            this.lblVehicleNumberInput.Size = new System.Drawing.Size(184, 22);
            this.lblVehicleNumberInput.TabIndex = 0;
            this.lblVehicleNumberInput.Text = "Vehicle Number:";
           
            this.toolTip1.ToolTipTitle = "Instructions";
            
            this.dgvVehicles.AllowUserToAddRows = false;
            this.dgvVehicles.AllowUserToDeleteRows = false;
            this.dgvVehicles.AllowUserToResizeColumns = false;
            this.dgvVehicles.AllowUserToResizeRows = false;
            this.dgvVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehicles.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvVehicles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Font = new System.Drawing.Font("Multicolore ", 10F);
            this.dgvVehicles.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvVehicles.Location = new System.Drawing.Point(825, 109);
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.Size = new System.Drawing.Size(594, 500);
            this.dgvVehicles.TabIndex = 1;
            
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.Font = new System.Drawing.Font("Multicolore ", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(29, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1390, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Smart Parking System - Vehicle Exit";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1448, 687);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvVehicles);
            this.Controls.Add(this.pnlMain);
            this.Name = "ExitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Exit";
            this.Load += new System.EventHandler(this.ExitForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.gbAdmin.ResumeLayout(false);
            this.gbAdmin.PerformLayout();
            this.gbResults.ResumeLayout(false);
            this.gbResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox gbResults;
        private System.Windows.Forms.Label lblCharge;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblVehicleNumber;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblExitTime;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblVehicleNumberInput;
        private System.Windows.Forms.GroupBox gbAdmin;
        private System.Windows.Forms.Label lblThreewheels;
        private System.Windows.Forms.Label lblBikes;
        private System.Windows.Forms.Label lblVans;
        private System.Windows.Forms.Label lblCars;
        private System.Windows.Forms.Label lblCurrentCount;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.Label label2;
    }
}