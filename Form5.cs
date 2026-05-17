using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FlightManagementSystem
    {
    public partial class Form5 : Form

        {
        private readonly string UserID;
        private readonly SqlConnection _con;
        public Form5(string userID, SqlConnection con)
            {
            InitializeComponent();
            _con = con;
            UserID = userID;


            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ticket_id"));
            dt.Columns.Add(new DataColumn("flight_name"));
            dt.Columns.Add(new DataColumn("class_name"));
            dt.Columns.Add(new DataColumn("ticket_price"));
            dt.Columns.Add(new DataColumn("booking_date"));
            try
                {
                _con.Close();
                _con.Open();
                SqlCommand cmd = new SqlCommand("Select Tickets.ticket_id,Flights.flight_name,Classes.class_name,Tickets.ticket_price,Tickets.booking_date From Tickets Join Flights ON Tickets.flight_id =Flights.flight_id Join Classes ON Tickets.ticket_class_id =Classes.class_id WHERE user_id=@user_id;", _con);
                cmd.Parameters.AddWithValue("@user_id", UserID);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    {
                    DataRow newrow = dt.NewRow();
                    newrow["ticket_id"] = reader["ticket_id"];
                    newrow["flight_name"] = reader["flight_name"];
                    newrow["class_name"] = reader["class_name"];
                    newrow["ticket_price"] = reader["ticket_price"];
                    newrow["booking_date"] = reader["booking_date"];
                    dt.Rows.Add(newrow);
                    }
                dataGridView1_MyFlightHistory.DataSource = dt;


                }

            catch
                {
                MessageBox.Show("Some error occured", "Error", MessageBoxButtons.OK);
                }
            finally
                {
                _con.Close();
                }
            }

        private void Form5_Load(object sender, System.EventArgs e)
            {

            }
        }
    }
