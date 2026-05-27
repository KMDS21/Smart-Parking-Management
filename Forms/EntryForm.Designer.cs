using System;

namespace SmartParkingSystem
{
    partial class EntryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryForm));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblEntryTime = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblVehicleNumberInput = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblThreewheels = new System.Windows.Forms.Label();
            this.lblBikes = new System.Windows.Forms.Label();
            this.lblVans = new System.Windows.Forms.Label();
            this.lblCars = new System.Windows.Forms.Label();
            this.lblCurrentCount = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.pnlMain.SuspendLayout();
            this.gbAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.SuspendLayout();
         
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.btnSubmit);
            this.pnlMain.Controls.Add(this.lblEntryTime);
            this.pnlMain.Controls.Add(this.txtNumber);
            this.pnlMain.Controls.Add(this.lblVehicleNumberInput);
            this.pnlMain.Controls.Add(this.cbType);
            this.pnlMain.Controls.Add(this.lblVehicleType);
            this.pnlMain.Location = new System.Drawing.Point(40, 37);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(593, 349);
            this.pnlMain.TabIndex = 0;
           
            this.btnSubmit.BackColor = System.Drawing.Color.Blue;
            this.btnSubmit.Font = new System.Drawing.Font("Multicolore ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.Location = new System.Drawing.Point(175, 277);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(167, 43);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit Entry";
            this.toolTip1.SetToolTip(this.btnSubmit, "Click to record vehicle entry");
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            
            this.lblEntryTime.AutoSize = true;
            this.lblEntryTime.Font = new System.Drawing.Font("Multicolore ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryTime.Location = new System.Drawing.Point(20, 216);
            this.lblEntryTime.Name = "lblEntryTime";
            this.lblEntryTime.Size = new System.Drawing.Size(134, 22);
            this.lblEntryTime.TabIndex = 4;
            this.lblEntryTime.Text = "Entry Time: ";
           
            this.txtNumber.Font = new System.Drawing.Font("Multicolore ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(208, 138);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(271, 29);
            this.txtNumber.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtNumber, "Enter the vehicle number");
            this.txtNumber.Enter += new System.EventHandler(this.txtNumber_Enter);
            
            this.lblVehicleNumberInput.AutoSize = true;
            this.lblVehicleNumberInput.Font = new System.Drawing.Font("Multicolore ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleNumberInput.Location = new System.Drawing.Point(20, 141);
            this.lblVehicleNumberInput.Name = "lblVehicleNumberInput";
            this.lblVehicleNumberInput.Size = new System.Drawing.Size(184, 22);
            this.lblVehicleNumberInput.TabIndex = 2;
            this.lblVehicleNumberInput.Text = "Vehicle Number:";
          
            this.cbType.Font = new System.Drawing.Font("Multicolore ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Select Vehicle",
            "Car",
            "Bike",
            "Van",
            "Threewheel"});
            this.cbType.Location = new System.Drawing.Point(175, 64);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(304, 30);
            this.cbType.TabIndex = 1;
            this.cbType.Text = "Select Vehicle";
            this.toolTip1.SetToolTip(this.cbType, "Choose the vehicle type");
            
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.Font = new System.Drawing.Font("Multicolore ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleType.Location = new System.Drawing.Point(20, 64);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(149, 22);
            this.lblVehicleType.TabIndex = 0;
            this.lblVehicleType.Text = "Vehicle Type:";
            
            this.gbAdmin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbAdmin.Controls.Add(this.label1);
            this.gbAdmin.Controls.Add(this.lblThreewheels);
            this.gbAdmin.Controls.Add(this.lblBikes);
            this.gbAdmin.Controls.Add(this.lblVans);
            this.gbAdmin.Controls.Add(this.lblCars);
            this.gbAdmin.Controls.Add(this.lblCurrentCount);
            this.gbAdmin.Font = new System.Drawing.Font("Multicolore ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdmin.Location = new System.Drawing.Point(670, 37);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(320, 349);
            this.gbAdmin.TabIndex = 1;
            this.gbAdmin.TabStop = false;
            this.gbAdmin.Text = "Parking Status";
            this.toolTip1.SetToolTip(this.gbAdmin, "Real-time parking slot availability");
           
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Availabel Slots Count";
           
            this.lblThreewheels.AutoSize = true;
            this.lblThreewheels.Font = new System.Drawing.Font("Multicolore ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreewheels.Location = new System.Drawing.Point(14, 277);
            this.lblThreewheels.Name = "lblThreewheels";
            this.lblThreewheels.Size = new System.Drawing.Size(188, 22);
            this.lblThreewheels.TabIndex = 4;
            this.lblThreewheels.Text = "Threewheels: 20";
            
            this.lblBikes.AutoSize = true;
            this.lblBikes.Font = new System.Drawing.Font("Multicolore ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBikes.Location = new System.Drawing.Point(15, 233);
            this.lblBikes.Name = "lblBikes";
            this.lblBikes.Size = new System.Drawing.Size(100, 22);
            this.lblBikes.TabIndex = 3;
            this.lblBikes.Text = "Bikes: 50";
            
            this.lblVans.AutoSize = true;
            this.lblVans.Font = new System.Drawing.Font("Multicolore ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVans.Location = new System.Drawing.Point(15, 191);
            this.lblVans.Name = "lblVans";
            this.lblVans.Size = new System.Drawing.Size(98, 22);
            this.lblVans.TabIndex = 2;
            this.lblVans.Text = "Vans: 20";
            
            this.lblCars.AutoSize = true;
            this.lblCars.Font = new System.Drawing.Font("Multicolore ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCars.Location = new System.Drawing.Point(14, 151);
            this.lblCars.Name = "lblCars";
            this.lblCars.Size = new System.Drawing.Size(97, 22);
            this.lblCars.TabIndex = 1;
            this.lblCars.Text = "Cars: 40";
            
            this.lblCurrentCount.AutoSize = true;
            this.lblCurrentCount.Font = new System.Drawing.Font("Multicolore ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentCount.ForeColor = System.Drawing.Color.Red;
            this.lblCurrentCount.Location = new System.Drawing.Point(15, 60);
            this.lblCurrentCount.Name = "lblCurrentCount";
            this.lblCurrentCount.Size = new System.Drawing.Size(208, 22);
            this.lblCurrentCount.TabIndex = 0;
            this.lblCurrentCount.Text = "Current Parked: 0";
            
            this.toolTip1.ToolTipTitle = "Instructions";
            
            this.dgvVehicles.AllowUserToAddRows = false;
            this.dgvVehicles.AllowUserToDeleteRows = false;
            this.dgvVehicles.AllowUserToResizeColumns = false;
            this.dgvVehicles.AllowUserToResizeRows = false;
            this.dgvVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehicles.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvVehicles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVehicles.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Multicolore ", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Font = new System.Drawing.Font("Multicolore ", 10F);
            this.dgvVehicles.GridColor = System.Drawing.SystemColors.InfoText;
            this.dgvVehicles.Location = new System.Drawing.Point(40, 405);
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.ReadOnly = true;
            this.dgvVehicles.RowHeadersVisible = false;
            this.dgvVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicles.Size = new System.Drawing.Size(950, 312);
            this.dgvVehicles.TabIndex = 2;
            this.dgvVehicles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicles_CellContentClick);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 729);
            this.Controls.Add(this.dgvVehicles);
            this.Controls.Add(this.gbAdmin);
            this.Controls.Add(this.pnlMain);
            this.Name = "EntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Entry";
            this.Load += new System.EventHandler(this.EntryForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.gbAdmin.ResumeLayout(false);
            this.gbAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.ResumeLayout(false);

        }

        private void EntryForm_Load(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblEntryTime;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblVehicleNumberInput;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.GroupBox gbAdmin;
        private System.Windows.Forms.Label lblThreewheels;
        private System.Windows.Forms.Label lblBikes;
        private System.Windows.Forms.Label lblVans;
        private System.Windows.Forms.Label lblCars;
        private System.Windows.Forms.Label lblCurrentCount;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVehicles;
    }
}