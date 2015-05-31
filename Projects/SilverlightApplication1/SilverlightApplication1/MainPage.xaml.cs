using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SilverlightApplication1
{
    public partial class MainPage : UserControl
    {
        int secretNumber = 0;
        int attemptCount = 0;

        bool secretNumberSet = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, RoutedEventArgs e)
        {
            int lower = 0;
            int upper = 0;
            try
            {
                lower = int.Parse(lowerLimitInput.Text);
                upper = int.Parse(upperLimitInput.Text);
            }
            catch (System.FormatException)
            {
                attemptLabel.Content = "Invalid Format, Try Again!";
                return;
            }
            Uri uri = new Uri("http://venus.eas.asu.edu/WSRepository/Services/NumberGuessRest/Service.svc/GetSecretNumber?lower=" + lower.ToString() + "&upper=" + upper.ToString());
            WebClient proxy = new WebClient();
            proxy.DownloadStringCompleted += new DownloadStringCompletedEventHandler(updateSecretNumber);
            proxy.DownloadStringAsync(uri);

        }

        private void updateSecretNumber(object sender, DownloadStringCompletedEventArgs e){
            string response = e.Result;

            secretNumber = int.Parse(response);
            secretNumberSet = true;
            attemptLabel.Content = "Number has been Genereated, Take a Guess!";
        }

        private void playButton_Click(object sender, RoutedEventArgs e)
        {

            if (!secretNumberSet) {
                attemptLabel.Content = "You need to generate a number first";
            }

            int guess = 0;
            try
            {
                guess = int.Parse(guessInput.Text);
            }
            catch (System.FormatException)
            {
                attemptLabel.Content = "Invalid Format, Try Again!";
                return;
            }
            Uri uri = new Uri("http://venus.eas.asu.edu/WSRepository/Services/NumberGuessRest/Service.svc/checkNumber?userNum=" + guess.ToString() + "&secretNum=" + secretNumber.ToString());
            WebClient proxy = new WebClient();
            proxy.DownloadStringCompleted += new DownloadStringCompletedEventHandler(updateOutput);
            proxy.DownloadStringAsync(uri);
        }

        private void updateOutput(object sender, DownloadStringCompletedEventArgs e)
        {
            string response = e.Result;
            attemptCount++;
            attemptLabel.Content = buildAttemptOutput(response, attemptCount, !response.ToLower().Contains("correct"));
        }

        private string buildAttemptOutput(string msg, int count, bool tryAgain)
        {
            string output = "";
            if (tryAgain)
            {
                output += msg + " - Try Again! - " + " Attempts - " + count.ToString();
            }
            else
            {
                output += msg + " Attempts - " + count.ToString();
            }

            return output;
        }
    }
}
