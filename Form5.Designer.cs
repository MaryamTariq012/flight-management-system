namespace FlightManagementSystem
    {
    partial class Form5
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
            this.dataGridView1_MyFlightHistory = new System.Windows.Forms.DataGridView();
            this.label1_My_Flight_History = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_MyFlightHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1_MyFlightHistory
            // 
            this.dataGridView1_MyFlightHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_MyFlightHistory.Location = new System.Drawing.Point(53, 64);
            this.dataGridView1_MyFlightHistory.Name = "dataGridView1_MyFlightHistory";
            this.dataGridView1_MyFlightHistory.RowHeadersWidth = 51;
            this.dataGridView1_MyFlightHistory.RowTemplate.Height = 24;
            this.dataGridView1_MyFlightHistory.Size = new System.Drawing.Size(703, 326);
            this.dataGridView1_MyFlightHistory.TabIndex = 0;
            // 
            // label1_My_Flight_History
            // 
            this.label1_My_Flight_History.AutoSize = true;
            this.label1_My_Flight_History.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_My_Flight_History.Location = new System.Drawing.Point(255, 19);
            this.label1_My_Flight_History.Name = "label1_My_Flight_History";
            this.label1_My_Flight_History.Size = new System.Drawing.Size(312, 42);
            this.label1_My_Flight_History.TabIndex = 1;
            this.label1_My_Flight_History.Text = "My Flight History";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.label1_My_Flight_History);
            this.Controls.Add(this.dataGridView1_MyFlightHistory);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_MyFlightHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1_MyFlightHistory;
        private System.Windows.Forms.Label label1_My_Flight_History;
        }
    }