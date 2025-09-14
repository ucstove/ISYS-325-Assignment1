namespace Assignment1
{
    public partial class MainForm : Form
    {

        private const double HOURLY_RATE = 10.50;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSummarize_Click(object sender, EventArgs e)
        {
            String firstName = txtFirstName.Text;
            String lastName = txtLastName.Text;
            int hours = 0;
            try
            {
                hours = int.Parse(txtHours.Text);
                lblSummary.ForeColor = Color.Black;
                lblSummary.Text = $"{firstName} {lastName} worked {hours} hours at {HOURLY_RATE:C} an hour for a total of {(hours * HOURLY_RATE):C}";
            }
            catch (FormatException)
            {
                lblSummary.ForeColor = Color.Red;
                lblSummary.Text = "Please enter a valid number for hours worked.";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtHours.Clear();
            lblSummary.Text = "";
            txtFirstName.Focus();
        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


    }
}
