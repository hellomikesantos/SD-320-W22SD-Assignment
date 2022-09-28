namespace SD_320_Assignment
{
    public partial class Form1 : Form
    {
        private string presentOperation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            presentOperation += (sender as Button).Text;

            textBoxOutput.Text = presentOperation;
        }

        private void textBoxOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}