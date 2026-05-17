using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FlightManagementSystem
    {
    public partial class Form4 : Form
        {
        private readonly string UserID;
        private readonly SqlConnection _con;
        public Form4(SqlConnection con, string userID)
            {
            InitializeComponent();
            UserID = userID;

            _con = con;
            DataTable dt1 = this.getAirlines();
            comboBox1_airlines.Items.Clear();
            comboBox1_airlines.DataSource = dt1;
            comboBox1_airlines.DisplayMember = "airline_name";
            comboBox1_airlines.ValueMember = "airline_id";
            DataTable dt2 = this.getClasses();
            comboBox2_ticketClass.Items.Clear();
            comboBox2_ticketClass.DataSource = dt2;
            comboBox2_ticketClass.DisplayMember = "class_name";
            comboBox2_ticketClass.ValueMember = "class_id";
            DataTable dt3 = this.getPaymentMethods();
            comboBox1_paymentMethod.Items.Clear();
            comboBox1_paymentMethod.DataSource = dt3;
            comboBox1_paymentMethod.DisplayMember = "payment_Methods_name";
            comboBox1_paymentMethod.ValueMember = "payment_Methods_id";
            UserID = userID;
            }
        private DataTable getAirlines()
            {
            DataTable dt = new DataTable();
            dt.Columns.Add("airline_id");
            dt.Columns.Add("airline_name");
            try
                {
                _con.Close();
                _con.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT airline_id, airline_name FROM Airlines;", _con);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                    {
                    DataRow newRow = dt.NewRow();
                    newRow[0] = reader1["airline_id"];
                    newRow[1] = reader1["airline_name"];
                    dt.Rows.Add(newRow);
                    }
                }
            catch
                {
                Console.WriteLine("Error in getting airlines.");
                }
            finally
                {
                _con.Close();
                }
            return dt;
            }
        private DataTable getClasses()
            {
            DataTable dt = new DataTable();
            dt.Columns.Add("class_id");
            dt.Columns.Add("class_name");
            try
                {
                _con.Close();
                _con.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT* FROM Classes;", _con);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                    {
                    DataRow newRow = dt.NewRow();
                    newRow[0] = reader1["class_id"];
                    newRow[1] = reader1["class_name"];
                    dt.Rows.Add(newRow);
                    }
                }
            catch
                {
                Console.WriteLine("Error in getting classes.");
                }
            finally
                {
                _con.Close();
                }
            return dt;
            }
        private DataTable getPaymentMethods()
            {
            DataTable dt = new DataTable();
            dt.Columns.Add("payment_Methods_id");
            dt.Columns.Add("payment_Methods_name");
            try
                {
                _con.Close();
                _con.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT * FROM PaymentMethods;", _con);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                    {
                    DataRow newRow = dt.NewRow();
                    newRow[0] = reader1["payment_Methods_id"];
                    newRow[1] = reader1["payment_Methods_name"];
                    dt.Rows.Add(newRow);
                    }
                }
            catch
                {
                Console.WriteLine("Error in getting paymentMethods.");
                }
            finally
                {
                _con.Close();
                }
            return dt;
            }

        private void button1_Click(object sender, EventArgs e)
            {
            string airlineId = comboBox1_airlines.SelectedValue.ToString();
            string ticketClassId = comboBox2_ticketClass.SelectedValue.ToString();
            string paymentMethodId = comboBox1_paymentMethod.SelectedValue.ToString();
            dataGridView1.DataSource = GetDestinationDetails(textBox1_Destination.Text, int.Parse(airlineId));
            }

        private DataTable GetDestinationDetails(string destination, int airlineId)
            {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("flight_id"));
            dt.Columns.Add(new DataColumn("flight_name"));
            dt.Columns.Add(new DataColumn("destination"));
            dt.Columns.Add(new DataColumn("distance"));
            dt.Columns.Add(new DataColumn("flight_airline_id"));
            dt.Columns.Add(new DataColumn("departure_time"));
            dt.Columns.Add(new DataColumn("arrival_time"));

            try
                {
                _con.Close();
                _con.Open();
                SqlCommand cmd = new SqlCommand("Select *FROM Flights WHERE airline_id = @airlineId AND destination = @destination;", _con);
                cmd.Parameters.AddWithValue("@airlineId", airlineId);
                cmd.Parameters.AddWithValue("@destination", destination);
                SqlDataReader output = cmd.ExecuteReader();
                while (output.Read())
                    {
                    DataRow newrow = dt.NewRow();
                    newrow["flight_id"] = output["flight_id"];
                    newrow["flight_name"] = output["flight_name"];
                    newrow["destination"] = output["destination"];
                    newrow["distance"] = output["distance"];
                    newrow["flight_airline_id"] = output["airline_id"];
                    newrow["departure_time"] = output["departure_time"];
                    newrow["arrival_time"] = output["arrival_time"];
                    dt.Rows.Add(newrow);
                    }
                }
            catch
                {
                MessageBox.Show("Some error occur.", "Error", MessageBoxButtons.OK);

                }
            finally
                {
                _con.Close();
                }
            return dt;
            }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
            {


            }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
            {
            DialogResult dialogResultValue = MessageBox.Show("Are you sure you want to book?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResultValue == DialogResult.Yes)
                {
                string flightid = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                double ticketprice = 500;

                try
                    {
                    _con.Open();
                    int ticketid = (int)new SqlCommand("select max(ticket_id) from tickets;", _con).ExecuteScalar();
                    ticketid++;
                    SqlCommand cmd = new SqlCommand("insert into tickets (ticket_id,user_id, flight_id, ticket_class_id, ticket_price, booking_date) values (@ticket_id,@userid, @flightid, @ticketclassid, @ticketprice, @bookingdate);", _con);
                    cmd.Parameters.AddWithValue("@ticket_id", ticketid);
                    cmd.Parameters.AddWithValue("@userid", UserID);
                    cmd.Parameters.AddWithValue("@flightid", flightid);
                    cmd.Parameters.AddWithValue("@ticketclassid", comboBox2_ticketClass.SelectedValue);
                    cmd.Parameters.AddWithValue("@ticketprice", ticketprice);
                    cmd.Parameters.AddWithValue("@bookingdate", DateTime.Now);

                    int rowsaffected = cmd.ExecuteNonQuery();

                    if (rowsaffected > 0)
                        {
                        int paymentId = (int)new SqlCommand("select max(payment_id) from Payments;", _con).ExecuteScalar();
                        paymentId++;
                        string PaymentMethodID = comboBox1_paymentMethod.SelectedValue.ToString();
                        SqlCommand paymentcmd = new SqlCommand("insert into payments (payment_id,ticket_id, payment_method_id, amount_paid, payment_date) values (@payment_id,@ticketid, @paymentmethodid, @amountpaid, @paymentdate);", _con);
                        paymentcmd.Parameters.AddWithValue("@payment_id", paymentId);
                        paymentcmd.Parameters.AddWithValue("@ticketid", ticketid);
                        paymentcmd.Parameters.AddWithValue("@paymentmethodid", PaymentMethodID);
                        paymentcmd.Parameters.AddWithValue("@amountpaid", ticketprice);
                        paymentcmd.Parameters.AddWithValue("@paymentdate", DateTime.Now);
                        paymentcmd.ExecuteNonQuery();

                        MessageBox.Show("Ticket booked successfully!");
                        }
                    else
                        {
                        MessageBox.Show("Booking failed. Please try again.");
                        }
                    }
                catch (Exception ex)
                    {
                    MessageBox.Show("Error booking ticket: " + ex.Message);
                    }
                finally
                    {
                    _con.Close();
                    }
                }
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

        private void Form4_Load(object sender, EventArgs e)
            {

            }
        }
    }
