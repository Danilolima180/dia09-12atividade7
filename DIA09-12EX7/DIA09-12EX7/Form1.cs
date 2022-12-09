namespace DIA09_12EX7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "ola mundo";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}