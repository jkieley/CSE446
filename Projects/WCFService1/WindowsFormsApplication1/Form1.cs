using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.WCFNumberGuessingService;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private static int secretNumber;
        private static int attemptCount = 0;
        private static NumberGuessClient client = new NumberGuessClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void lowerLimitLabel_Click(object sender, EventArgs e)
        {

        }

        private void lowerLimit_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void generateANumber_Click(object sender, EventArgs e)
        {
            try {
                int lowerLimit = int.Parse(lowerLimitInput.Text);
                int upperLimit = int.Parse(upperLimitInput.Text);
                secretNumber = client.SecretNumber(lowerLimit, upperLimit);
                attemptsLabel.Text = addAttemptsString("A Number has been Generated, Now make a Guess!");          
            }catch(System.FormatException){
                attemptsLabel.Text = addAttemptsString("Invalid Input");
                // do nothing
            }
        }

        private String addAttemptsString(String msg) {
            return msg + "  Attempts - " + attemptCount.ToString(); 
        }

    }
}
