using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FlightManagementSystem
    {
    public partial class Form2 : Form
        {
        private readonly string UserID;
        private readonly SqlConnection _con;
        public Form2(string userID, SqlConnection con)
            {
            InitializeComponent();
            UserID = userID;
            _con = con;
            dataGridView1_flightData.DataSource = GetFlightsDetails();
            }
        private DataTable GetFlightsDetails()
            {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("flight_id"));
            dataTable.Columns.Add(new DataColumn("flight_name"));
            dataTable.Columns.Add(new DataColumn("destination"));
            dataTable.Columns.Add(new DataColumn("distance"));
            dataTable.Columns.Add(new DataColumn("departure_time"));
            dataTable.Columns.Add(new DataColumn("arrival_time"));
            dataTable.Columns.Add(new DataColumn("airline_name"));
            dataTable.Columns.Add(new DataColumn("contact_phone"));
            try
                {
                _con.Close();
                _con.Open();
                SqlCommand cmd = new SqlCommand("Select Flights.flight_id, Flights.flight_name, Flights.destination, Flights.distance, Flights.departure_time, Flights.arrival_time,Airlines.airline_name, Airlines.contact_phone FROM Flights join Airlines on Flights.airline_id = Airlines.airline_id;", _con);
                SqlDataReader output = cmd.ExecuteReader();
                while (output.Read())
                    {
                    DataRow newRow = dataTable.NewRow();
                    newRow["flight_id"] = output["flight_id"].ToString();
                    newRow["flight_name"] = output["flight_name"].ToString();
                    newRow["destination"] = output["destination"].ToString();
                    newRow["distance"] = output["distance"].ToString();
                    newRow["departure_time"] = output["departure_time"].ToString();
                    newRow["arrival_time"] = output["arrival_time"].ToString();
                    newRow["airline_name"] = output["airline_name"].ToString();
                    newRow["contact_phone"] = output["contact_phone"].ToString();
                    dataTable.Rows.Add(newRow);
                    }
                }
            catch
                {
                MessageBox.Show("Some error occured while getting flights data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            finally
                {
                _con.Close();
                }
            return dataTable;
            }

        private void myInfoToolStripMenuItem_Click(object sender, System.EventArgs e)
            {
            try
                {
                _con.Close();
                _con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE user_id = @user_id;", _con);

                cmd.Parameters.AddWithValue("@user_id", UserID);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                Form3 form3 = new Form3(reader["user_id"].ToString(), reader["first_name"].ToString(), reader["last_name"].ToString(), reader["gender"].ToString(), reader["phone"].ToString(), reader["address"].ToString(), reader["DOB"].ToString());
                form3.Show();
                }
            catch
                {
                MessageBox.Show("User id not found");
                }
            finally
                {
                _con.Close();
                }
            }

        private void bookaFlightToolStripMenuItem_Click(object sender, System.EventArgs e)
            {
            Form4 form4 = new Form4(_con, UserID);
            form4.Show();
            }

        private void dataGridView1_flightData_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

        private void searchFlightToolStripMenuItem_Click(object sender, System.EventArgs e)
            {
            Form5 form5 = new Form5(UserID, _con);
            form5.Show();
            }

        private void Form2_Load(object sender, System.EventArgs e)
            {

            }
        }
    }
