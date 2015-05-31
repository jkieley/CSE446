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

        }
    }
}
