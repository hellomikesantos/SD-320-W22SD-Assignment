using System.Data;

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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = "0";
            presentOperation = "";
        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            if (presentOperation.Length > 0)
            {
                presentOperation = presentOperation.Remove(presentOperation.Length - 1, 1);
            }
            textBoxOutput.Text = presentOperation;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            string calculationNewFormat = presentOperation.ToString().Replace("x", "*").ToString().Replace("÷", "/");
            try
            {
                textBoxOutput.Text = new DataTable().Compute(calculationNewFormat, null).ToString();
                presentOperation = textBoxOutput.Text;
            }
            catch (Exception ex)
            {
                textBoxOutput.Text = "0";
                presentOperation = "";
            }
        }
    }
}