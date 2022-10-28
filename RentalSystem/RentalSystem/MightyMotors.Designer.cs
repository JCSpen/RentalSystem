namespace RentalSystem
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
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).BeginInit();
            this.SuspendLayout();
            // 
            // TableView
            // 
            this.TableView.AllowUserToAddRows = false;
            this.TableView.AllowUserToDeleteRows = false;
            this.TableView.AllowUserToOrderColumns = true;
            this.TableView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.TableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableView.Location = new System.Drawing.Point(255, 0);
            this.TableView.MaximumSize = new System.Drawing.Size(308, 449);
            this.TableView.MinimumSize = new System.Drawing.Size(308, 449);
            this.TableView.Name = "TableView";
            this.TableView.ReadOnly = true;
            this.TableView.RowTemplate.Height = 25;
            this.TableView.RowTemplate.ReadOnly = true;
            this.TableView.Size = new System.Drawing.Size(308, 449);
            this.TableView.TabIndex = 0;
            // 
            // MakeBox
            // 
            this.MakeBox.Location = new System.Drawing.Point(12, 12);
            this.MakeBox.Name = "MakeBox";
            this.MakeBox.Size = new System.Drawing.Size(237, 23);
            this.MakeBox.TabIndex = 1;
            // 
            // ModelBox
            // 
            this.ModelBox.Location = new System.Drawing.Point(12, 41);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(237, 23);
            this.ModelBox.TabIndex = 2;
            // 
            // RegBox
            // 
            this.RegBox.Location = new System.Drawing.Point(12, 70);
            this.RegBox.Name = "RegBox";
            this.RegBox.Size = new System.Drawing.Size(237, 23);
            this.RegBox.TabIndex = 3;
            // 
            // MileageBox
            // 
            this.MileageBox.Location = new System.Drawing.Point(12, 99);
            this.MileageBox.Name = "MileageBox";
            this.MileageBox.Size = new System.Drawing.Size(237, 23);
            this.MileageBox.TabIndex = 4;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(12, 128);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(237, 23);
            this.PriceBox.TabIndex = 5;
            // 
            // AdminSubmitBtn
            // 
            this.AdminSubmitBtn.Location = new System.Drawing.Point(96, 157);
            this.AdminSubmitBtn.Name = "AdminSubmitBtn";
            this.AdminSubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.AdminSubmitBtn.TabIndex = 6;
            this.AdminSubmitBtn.Text = "Submit";
            this.AdminSubmitBtn.UseVisualStyleBackColor = true;
            this.AdminSubmitBtn.Click += new System.EventHandler(this.AdminSubmitBtn_Click);
            // 
            // MightyMotors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdminSubmitBtn);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.MileageBox);
            this.Controls.Add(this.RegBox);
            this.Controls.Add(this.ModelBox);
            this.Controls.Add(this.MakeBox);
            this.Controls.Add(this.TableView);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
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
    }
}