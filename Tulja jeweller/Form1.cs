namespace Tulja_jeweller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bill b = new bill();
            b.FormClosed += (s, args) => this.Show(); // Show the current form when bill form is closed
            this.Hide();
            b.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            showbills showbills = new showbills();
            showbills.FormClosed += (s, args) => this.Show(); // Show the current form when showbills form is closed
            this.Hide();
            showbills.ShowDialog();

        }
    }
}