﻿namespace RentalSystem
{
    partial class MightyMotors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TableView = new System.Windows.Forms.DataGridView();
            this.MakeBox = new System.Windows.Forms.TextBox();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.RegBox = new System.Windows.Forms.TextBox();
            this.MileageBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.AdminSubmitBtn = new System.Windows.Forms.Button();
            this.ClearanceKeyBox = new System.Windows.Forms.TextBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.VehicleIDBox = new System.Windows.Forms.TextBox();
            this.IDBtn = new System.Windows.Forms.Button();
            this.InfoCheckBox = new System.Windows.Forms.CheckBox();
            this.RentCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).BeginInit();
            this.SuspendLayout();
            // 
            // TableView
            // 
            this.TableView.AllowUserToAddRows = false;
            this.TableView.AllowUserToDeleteRows = false;
            this.TableView.AllowUserToOrderColumns = true;
            this.TableView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.TableView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.TableView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.TableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableView.Location = new System.Drawing.Point(697, 0);
            this.TableView.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.TableView.Name = "TableView";
            this.TableView.ReadOnly = true;
            this.TableView.RowHeadersWidth = 123;
            this.TableView.RowTemplate.Height = 25;
            this.TableView.RowTemplate.ReadOnly = true;
            this.TableView.Size = new System.Drawing.Size(880, 1230);
            this.TableView.TabIndex = 0;
            // 
            // MakeBox
            // 
            this.MakeBox.Location = new System.Drawing.Point(34, 38);
            this.MakeBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.MakeBox.Name = "MakeBox";
            this.MakeBox.PlaceholderText = "Vehicle Make";
            this.MakeBox.Size = new System.Drawing.Size(638, 55);
            this.MakeBox.TabIndex = 1;
            // 
            // ModelBox
            // 
            this.ModelBox.Location = new System.Drawing.Point(34, 131);
            this.ModelBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.PlaceholderText = "Vehicle Model";
            this.ModelBox.Size = new System.Drawing.Size(638, 55);
            this.ModelBox.TabIndex = 2;
            // 
            // RegBox
            // 
            this.RegBox.Location = new System.Drawing.Point(34, 224);
            this.RegBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.RegBox.Name = "RegBox";
            this.RegBox.PlaceholderText = "Vehicle Registration Plate";
            this.RegBox.Size = new System.Drawing.Size(638, 55);
            this.RegBox.TabIndex = 3;
            // 
            // MileageBox
            // 
            this.MileageBox.Location = new System.Drawing.Point(34, 317);
            this.MileageBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.MileageBox.Name = "MileageBox";
            this.MileageBox.PlaceholderText = "Vehicle Mileage";
            this.MileageBox.Size = new System.Drawing.Size(638, 55);
            this.MileageBox.TabIndex = 4;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(34, 410);
            this.PriceBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.PlaceholderText = "Cost to rent";
            this.PriceBox.Size = new System.Drawing.Size(638, 55);
            this.PriceBox.TabIndex = 5;
            // 
            // AdminSubmitBtn
            // 
            this.AdminSubmitBtn.Location = new System.Drawing.Point(34, 595);
            this.AdminSubmitBtn.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.AdminSubmitBtn.Name = "AdminSubmitBtn";
            this.AdminSubmitBtn.Size = new System.Drawing.Size(214, 74);
            this.AdminSubmitBtn.TabIndex = 6;
            this.AdminSubmitBtn.Text = "Submit";
            this.AdminSubmitBtn.UseVisualStyleBackColor = true;
            this.AdminSubmitBtn.Click += new System.EventHandler(this.AdminSubmitBtn_Click);
            // 
            // ClearanceKeyBox
            // 
            this.ClearanceKeyBox.Location = new System.Drawing.Point(34, 502);
            this.ClearanceKeyBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.ClearanceKeyBox.Name = "ClearanceKeyBox";
            this.ClearanceKeyBox.PlaceholderText = "Clearance Key";
            this.ClearanceKeyBox.Size = new System.Drawing.Size(638, 55);
            this.ClearanceKeyBox.TabIndex = 7;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(466, 595);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(214, 74);
            this.RefreshBtn.TabIndex = 8;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // VehicleIDBox
            // 
            this.VehicleIDBox.Location = new System.Drawing.Point(1594, 38);
            this.VehicleIDBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.VehicleIDBox.Name = "VehicleIDBox";
            this.VehicleIDBox.PlaceholderText = "ID of Vehicle";
            this.VehicleIDBox.Size = new System.Drawing.Size(622, 55);
            this.VehicleIDBox.TabIndex = 9;
            // 
            // IDBtn
            // 
            this.IDBtn.Location = new System.Drawing.Point(1912, 131);
            this.IDBtn.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.IDBtn.Name = "IDBtn";
            this.IDBtn.Size = new System.Drawing.Size(304, 132);
            this.IDBtn.TabIndex = 10;
            this.IDBtn.Text = "Submit";
            this.IDBtn.UseVisualStyleBackColor = true;
            this.IDBtn.Click += new System.EventHandler(this.IDBtn_Click);
            // 
            // InfoCheckBox
            // 
            this.InfoCheckBox.AutoSize = true;
            this.InfoCheckBox.Location = new System.Drawing.Point(1594, 131);
            this.InfoCheckBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.InfoCheckBox.Name = "InfoCheckBox";
            this.InfoCheckBox.Size = new System.Drawing.Size(223, 52);
            this.InfoCheckBox.TabIndex = 11;
            this.InfoCheckBox.Text = "More Info";
            this.InfoCheckBox.UseVisualStyleBackColor = true;
            // 
            // RentCheckBox
            // 
            this.RentCheckBox.AutoSize = true;
            this.RentCheckBox.Location = new System.Drawing.Point(1594, 211);
            this.RentCheckBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.RentCheckBox.Name = "RentCheckBox";
            this.RentCheckBox.Size = new System.Drawing.Size(324, 52);
            this.RentCheckBox.TabIndex = 12;
            this.RentCheckBox.Text = "Rent this vehicle";
            this.RentCheckBox.UseVisualStyleBackColor = true;
            // 
            // MightyMotors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(2229, 1235);
            this.Controls.Add(this.RentCheckBox);
            this.Controls.Add(this.InfoCheckBox);
            this.Controls.Add(this.IDBtn);
            this.Controls.Add(this.VehicleIDBox);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.ClearanceKeyBox);
            this.Controls.Add(this.AdminSubmitBtn);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.MileageBox);
            this.Controls.Add(this.RegBox);
            this.Controls.Add(this.ModelBox);
            this.Controls.Add(this.MakeBox);
            this.Controls.Add(this.TableView);
            this.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2265, 1338);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(2265, 1338);
            this.Name = "MightyMotors";
            this.Text = "MightyMotors";
            this.Load += new System.EventHandler(this.MightyMotors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView TableView;
        private TextBox MakeBox;
        private TextBox ModelBox;
        private TextBox RegBox;
        private TextBox MileageBox;
        private TextBox PriceBox;
        private Button AdminSubmitBtn;
        private TextBox ClearanceKeyBox;
        private Button RefreshBtn;
        private TextBox VehicleIDBox;
        private Button IDBtn;
        private CheckBox InfoCheckBox;
        private CheckBox RentCheckBox;
    }
}