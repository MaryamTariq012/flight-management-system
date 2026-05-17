namespace FlightManagementSystem
    {
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookaFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1_flightData = new System.Windows.Forms.DataGridView();
            this.label1_all_flights = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_flightData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchFlightToolStripMenuItem,
            this.myInfoToolStripMenuItem,
            this.bookaFlightToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1482, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchFlightToolStripMenuItem
            // 
            this.searchFlightToolStripMenuItem.Name = "searchFlightToolStripMenuItem";
            this.searchFlightToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.searchFlightToolStripMenuItem.Text = "My Flight History";
            this.searchFlightToolStripMenuItem.Click += new System.EventHandler(this.searchFlightToolStripMenuItem_Click);
            // 
            // myInfoToolStripMenuItem
            // 
            this.myInfoToolStripMenuItem.Name = "myInfoToolStripMenuItem";
            this.myInfoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.myInfoToolStripMenuItem.Text = "My Info";
            this.myInfoToolStripMenuItem.Click += new System.EventHandler(this.myInfoToolStripMenuItem_Click);
            // 
            // bookaFlightToolStripMenuItem
            // 
            this.bookaFlightToolStripMenuItem.Name = "bookaFlightToolStripMenuItem";
            this.bookaFlightToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.bookaFlightToolStripMenuItem.Text = "Book a Flight";
            this.bookaFlightToolStripMenuItem.Click += new System.EventHandler(this.bookaFlightToolStripMenuItem_Click);
            // 
            // dataGridView1_flightData
            // 
            this.dataGridView1_flightData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_flightData.Location = new System.Drawing.Point(12, 95);
            this.dataGridView1_flightData.Name = "dataGridView1_flightData";
            this.dataGridView1_flightData.RowHeadersWidth = 51;
            this.dataGridView1_flightData.RowTemplate.Height = 24;
            this.dataGridView1_flightData.Size = new System.Drawing.Size(776, 343);
            this.dataGridView1_flightData.TabIndex = 6;
            this.dataGridView1_flightData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_flightData_CellContentClick);
            // 
            // label1_all_flights
            // 
            this.label1_all_flights.AutoSize = true;
            this.label1_all_flights.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_all_flights.Location = new System.Drawing.Point(246, 47);
            this.label1_all_flights.Name = "label1_all_flights";
            this.label1_all_flights.Size = new System.Drawing.Size(190, 42);
            this.label1_all_flights.TabIndex = 7;
            this.label1_all_flights.Text = "All Flights";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "All Flights";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label1_all_flights);
            this.Controls.Add(this.dataGridView1_flightData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_flightData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchFlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myInfoToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1_flightData;
        private System.Windows.Forms.ToolStripMenuItem bookaFlightToolStripMenuItem;
        private System.Windows.Forms.Label label1_all_flights;
        private System.Windows.Forms.Label label1;
        }
    }