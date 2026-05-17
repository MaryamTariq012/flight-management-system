using System.Windows.Forms;

namespace FlightManagementSystem
    {
    public partial class Form3 : Form
        {
        public Form3(string user_id, string first_name, string last_name, string gender, string phone, string address, string DOB)
            {
            InitializeComponent();
            UserIDValue.Text = user_id;
            FirstNameValue.Text = first_name;
            LastNameValue.Text = last_name;
            GenderValue.Text = gender;
            PhoneValue.Text = phone;
            AddressValue.Text = address;
            DOBValue.Text = DOB;

            }

        private void Form3_Load(object sender, System.EventArgs e)
            {

            }
        }
    }
