using System.Data;
using System.Linq;

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
            if(presentOperation.Contains('x')
                || presentOperation.Contains('+')
                || presentOperation.Contains('-')
                || presentOperation.Contains('÷'))
            {
                textBoxOutput2.Text = presentOperation;
                if ((sender as Button).Text != '÷'.ToString()
                    || (sender as Button).Text != 'x'.ToString()
                    || (sender as Button).Text != '+'.ToString()
                    || (sender as Button).Text != '-'.ToString())
                {
                    textBoxOutput.Text = (sender as Button).Text;
                }
                //this.buttonEquals_Click(sender, e);
            }
            else if (int.Parse((sender as Button).Text).GetType() == typeof(int))
            {
                textBoxOutput.Text = (sender as Button).Text;
                if (textBoxOutput2.Text.Contains('x')
                    || textBoxOutput2.Text.Contains('+')
                    || textBoxOutput2.Text.Contains('-')
                    || textBoxOutput2.Text.Contains('÷'))
                {
                    textBoxOutput.Text = (sender as Button).Text;
                }
            }

            else
            {
                textBoxOutput.Text = (sender as Button).Text;
            }

        }

        private void textBoxOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = "0";
            presentOperation = "";
            textBoxOutput2.Text = "";
        }

        //private void buttonClearEntry_Click(object sender, EventArgs e)
        //{
        //    if (presentOperation.Length > 0)
        //    {
        //        presentOperation = presentOperation.Remove(presentOperation.Length - 1, 1);
        //    }
        //    textBoxOutput.Text = presentOperation;
        //}

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
                //textBoxOutput.Text = "0";
                //presentOperation = "";
            }
        }

        //this tutorial helped me construct my function https://dotnettutorials.net/lesson/decimal-to-binary-conversion-in-csharp/
        private void buttonBIN_Click(object sender, EventArgs e)
        {
            try
            {
                if (!textBoxOutput.Text.Contains("1") && !textBoxOutput.Text.Contains("0"))
                {
                    string decNumString = textBoxOutput.Text;
                    int decNum = int.Parse(decNumString);
                    string newString = string.Empty;
                    for (int i = 0; decNum > 0; i++)
                    {
                        newString = decNum % 2 + newString;
                        decNum = decNum / 2;
                    }

                    textBoxOutput.Text = newString;
                }
                else
                {
                    return;
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }


        private void buttonDEC_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxOutput.Text.Contains("1") && textBoxOutput.Text.Contains("0"))
                {

                    string binNumString = textBoxOutput.Text;
                    int binNum = int.Parse(binNumString);
                    int decimalNum = Convert.ToInt32(binNum.ToString(), 2);

                    textBoxOutput.Text = decimalNum.ToString();
                }
                else
                {
                    return;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void textBoxOutput2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}