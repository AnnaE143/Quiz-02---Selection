namespace Quiz_02___Selection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void q04InstructionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The user will enter the temperature in the first text box and answer if they brought a jacket in the second text box.  The output will be:\r\n\r\n“You should be comfortable” if If they brought a jacket and the temperature is below 15 , or they did not bring a jacket and the temperature is above 15\r\n\r\nIf they brought a jacket and the temperature is above 15 “You will be too hot”\r\n\r\nIf they did not bring a jacket and the temperature is below 15 “You are going to be cold”\r\n\r\nMake sure you add a try catch so there are no runtime errors.\r\n  For full marks use exactly three if statements ");
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void bonusButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change the text in this message box to answer the question:  Provide an example to explain why you would choose 'if..else if' instead of repeated 'if' statements");
        }

        private void q1Button_Click(object sender, EventArgs e)
        {
            try
            {
                string password = q1TextBox.Text;

                if (password == "banana")
                {
                    q1OutputLabel.Text = "SECRET UNLOCKED";
                }
                else
                {
                    q1OutputLabel.Text = "Please try again.";
                }
            }
            catch
            {
                q1OutputLabel.Text = "?";
            }
        }

        private void q2Button_Click(object sender, EventArgs e)
        {
            try
            {
                string favoriteMusic = q2TextBox.Text;

                if (favoriteMusic == "r")
                {
                    q2OutputLabel.Text = "ROCK ON";
                }
                else if (favoriteMusic == "c")
                {
                    q2OutputLabel.Text = "GIDDY-UP";
                }
                else
                {
                    q2OutputLabel.Text = "?";
                }
            }
            catch
            {
                q2OutputLabel.Text = "?";
            }
        }

        private void q3Button_Click(object sender, EventArgs e)
        {
            try
            {
                int grade = Convert.ToInt16(q3TextBox.Text);

                if (grade < 50)
                    q3OutputLabel.Text = "Fail";
                else if (grade < 80)
                    q3OutputLabel.Text = "You passed";
                else if (grade < 101)
                    q3OutputLabel.Text = "Excellent Effort!";
            }
            catch
            {
                q3OutputLabel.Text = "Please enter an integer.";
            }
        }

        private void q4Button_Click(object sender, EventArgs e)
        {
            try
            {
                int temperature = Convert.ToInt16(q4TempTextBox.Text);
                string yesNo = q4CoatTextBox.Text;

                if ((yesNo == "y") && (temperature < 15) || (yesNo == "n") && (temperature > 15))
                    q4OutputLabel.Text = "You should be warm.";
                else if ((yesNo == "y") && (temperature > 15))
                    q4OutputLabel.Text = "You will be too hot.";
                else if ((yesNo == "n") && (temperature < 15))
                    q4OutputLabel.Text = "You are going to be cold.";
            }
            catch
            {
                q4OutputLabel.Text = "?";
            }
        }
    }
}
