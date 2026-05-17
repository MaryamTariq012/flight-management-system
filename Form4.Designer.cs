namespace FlightManagementSystem
    {
    partial class Form4
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
            this.label1_Destination = new System.Windows.Forms.Label();
            this.textBox1_Destination = new System.Windows.Forms.TextBox();
            this.button1_Search = new System.Windows.Forms.Button();
            this.label1_airline = new System.Windows.Forms.Label();
            this.comboBox1_airlines = new System.Windows.Forms.ComboBox();
            this.comboBox1_paymentMethod = new System.Windows.Forms.ComboBox();
            this.label1_paymentMethod = new System.Windows.Forms.Label();
            this.label2_ticketClass = new System.Windows.Forms.Label();
            this.comboBox2_ticketClass = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1_Destination
            // 
            this.label1_Destination.AutoSize = true;
            this.label1_Destination.Location = new System.Drawing.Point(12, 9);
            this.label1_Destination.Name = "label1_Destination";
            this.label1_Destination.Size = new System.Drawing.Size(74, 16);
            this.label1_Destination.TabIndex = 0;
            this.label1_Destination.Text = "Destination";
            // 
            // textBox1_Destination
            // 
            this.textBox1_Destination.Location = new System.Drawing.Point(97, 9);
            this.textBox1_Destination.Multiline = true;
            this.textBox1_Destination.Name = "textBox1_Destination";
            this.textBox1_Destination.Size = new System.Drawing.Size(121, 22);
            this.textBox1_Destination.TabIndex = 3;
            // 
            // button1_Search
            // 
            this.button1_Search.Location = new System.Drawing.Point(345, 52);
            this.button1_Search.Name = "button1_Search";
            this.button1_Search.Size = new System.Drawing.Size(159, 22);
            this.button1_Search.TabIndex = 4;
            this.button1_Search.Text = "Show Available Flights";
            this.button1_Search.UseVisualStyleBackColor = true;
            this.button1_Search.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1_airline
            // 
            this.label1_airline.AutoSize = true;
            this.label1_airline.Location = new System.Drawing.Point(224, 12);
            this.label1_airline.Name = "label1_airline";
            this.label1_airline.Size = new System.Drawing.Size(44, 16);
            this.label1_airline.TabIndex = 5;
            this.label1_airline.Text = "Airline";
            // 
            // comboBox1_airlines
            // 
            this.comboBox1_airlines.FormattingEnabled = true;
            this.comboBox1_airlines.Items.AddRange(new object[] {
            "Buhran ",
            "ayesha ",
            "maryam"});
            this.comboBox1_airlines.Location = new System.Drawing.Point(274, 9);
            this.comboBox1_airlines.Name = "comboBox1_airlines";
            this.comboBox1_airlines.Size = new System.Drawing.Size(121, 24);
            this.comboBox1_airlines.TabIndex = 6;
            // 
            // comboBox1_paymentMethod
            // 
            this.comboBox1_paymentMethod.FormattingEnabled = true;
            this.comboBox1_paymentMethod.Location = new System.Drawing.Point(726, 9);
            this.comboBox1_paymentMethod.Name = "comboBox1_paymentMethod";
            this.comboBox1_paymentMethod.Size = new System.Drawing.Size(121, 24);
            this.comboBox1_paymentMethod.TabIndex = 10;
            // 
            // label1_paymentMethod
            // 
            this.label1_paymentMethod.AutoSize = true;
            this.label1_paymentMethod.Location = new System.Drawing.Point(615, 12);
            this.label1_paymentMethod.Name = "label1_paymentMethod";
            this.label1_paymentMethod.Size = new System.Drawing.Size(105, 16);
            this.label1_paymentMethod.TabIndex = 9;
            this.label1_paymentMethod.Text = "PaymentMethod";
            // 
            // label2_ticketClass
            // 
            this.label2_ticketClass.AutoSize = true;
            this.label2_ticketClass.Location = new System.Drawing.Point(401, 12);
            this.label2_ticketClass.Name = "label2_ticketClass";
            this.label2_ticketClass.Size = new System.Drawing.Size(81, 16);
            this.label2_ticketClass.TabIndex = 7;
            this.label2_ticketClass.Text = "TIcket Class";
            // 
            // comboBox2_ticketClass
            // 
            this.comboBox2_ticketClass.FormattingEnabled = true;
            this.comboBox2_ticketClass.Location = new System.Drawing.Point(488, 9);
            this.comboBox2_ticketClass.Name = "comboBox2_ticketClass";
            this.comboBox2_ticketClass.Size = new System.Drawing.Size(121, 24);
            this.comboBox2_ticketClass.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(791, 252);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2_ticketClass);
            this.Controls.Add(this.comboBox1_paymentMethod);
            this.Controls.Add(this.label1_paymentMethod);
            this.Controls.Add(this.label2_ticketClass);
            this.Controls.Add(this.comboBox1_airlines);
            this.Controls.Add(this.label1_airline);
            this.Controls.Add(this.button1_Search);
            this.Controls.Add(this.textBox1_Destination);
            this.Controls.Add(this.label1_Destination);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label label1_Destination;
        private System.Windows.Forms.TextBox textBox1_Destination;
        private System.Windows.Forms.Button button1_Search;
        private System.Windows.Forms.Label label1_airline;
        private System.Windows.Forms.ComboBox comboBox1_airlines;
        private System.Windows.Forms.ComboBox comboBox1_paymentMethod;
        private System.Windows.Forms.Label label1_paymentMethod;
        private System.Windows.Forms.Label label2_ticketClass;
        private System.Windows.Forms.ComboBox comboBox2_ticketClass;
        private System.Windows.Forms.DataGridView dataGridView1;
        }
    }