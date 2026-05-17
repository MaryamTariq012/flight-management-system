using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FlightManagementSystem
    {
    public partial class Form1 : Form
        {
        private readonly string _connectionString;
        private readonly SqlConnection _con;
        public Form1()
            {
            InitializeComponent();
            _connectionString = @"Data Source=DESKTOP-2IONJ7I;Initial Catalog=FlightManagementSystem;Integrated Security=True";

            _con = new SqlConnection(_connectionString);
            }

        private void btnSave_Click(object sender, EventArgs e)
            {
            try
                {
                _con.Close();
                _con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Password FROM Users WHERE user_id = @user_id;", _con);
                cmd.Parameters.AddWithValue("@user_id", int.Parse(textUserID.Text));
                using (SqlDataReader output = cmd.ExecuteReader())
                    {
                    if (output.HasRows)
                        {
                        output.Read();
                        string storedPassword = output["Password"].ToString();
                        if (storedPassword == textPassword.Text)
                            {
                            Form2 form2 = new Form2(textUserID.Text, _con);
                            form2.Show();
                            }
                        else
                            {
                            MessageBox.Show("Invalid user credentials.", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    else
                        {
                        MessageBox.Show("User not found.", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            catch
                {
                MessageBox.Show("Fail to verify user credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            finally
                {
                _con.Close();
                }
            }

        private void Form1_Load(object sender, EventArgs e)
            {

            }
        }
    }
