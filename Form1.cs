namespace Lab2Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTxt.Text) ||
    string.IsNullOrWhiteSpace(passwordTxt.Text))
            {
                MessageBox.Show("Please enter both username and password.");

                // Clear the boxes!
                usernameTxt.Clear();
                passwordTxt.Clear();

                // Put the cursor back in the username box so the user can type
                usernameTxt.Focus();

                return;
            }

            ChooseForm choose = new ChooseForm();
            choose.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
