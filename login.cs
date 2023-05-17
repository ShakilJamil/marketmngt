namespace market_management
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("missing data!");
            }
            else if (username.Text == "Admin" && password.Text == "Password")
            {
                menuview obj = new menuview();
                obj.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("wrong password or username");
                username.Text = "";
                password.Text = "";
            }
        }

        private void MarketMM_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            username.Text = "";
            password.Text = "";
        }
    }
}