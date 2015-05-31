using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void generateNumber_Click(object sender, EventArgs e)
        {
            // Get input from the front end

            int lower = 0;
            int upper = 0;
            try
            {
                lower = int.Parse(lowerLimit.Text);
                upper = int.Parse(upperLimit.Text);
            }catch(System.FormatException){
                outputLabel.Text = "Invalid Format, Try Again!";
                return;
            }

            // Prepare to make service call
            Uri uri = new Uri("http://localhost:1000/Service.svc/SecretNumber?lower="+lower.ToString()+"&upper="+upper.ToString());
            WebClient proxy = new WebClient();
            string response = proxy.DownloadString(uri);

            // Parse the service reponse
            Regex numRegex = new Regex(">(.+?)<", RegexOptions.IgnoreCase);
            MatchCollection matches = numRegex.Matches(response);
            int generatedNum = int.Parse(matches[0].Groups[1].Value);

            // Store the parse response in the session
            Session["secretNum"] = generatedNum;
            outputLabel.Text = "A Number has been generated, Start guessing!";


        }

        protected void play_Click(object sender, EventArgs e)
        {
            // check to see if they have generated a number first 
            if (Session["secretNum"] == null){
                outputLabel.Text = "You must generate a number first!";
            }

            // Get input from the front end

            int guessNum = 0;
            try
            {
                guessNum = int.Parse(guess.Text);
            }
            catch (System.FormatException)
            {
                outputLabel.Text = "Invalid Format, Try Again!";
                return;
            }

            // Prepare to make service call
            Uri uri = new Uri("http://localhost:1000/Service.svc/checkNumber?userNum=" + guessNum.ToString() + "&SecretNum=" + Session["secretNum"].ToString());
            WebClient proxy = new WebClient();
            string response = proxy.DownloadString(uri);

            // Parse the service reponse
            Regex numRegex = new Regex(">(.+?)<", RegexOptions.IgnoreCase);
            MatchCollection matches = numRegex.Matches(response);
            string outputString = matches[0].Groups[1].Value;

            //Display result 
            int incrementedValue = Convert.ToInt32(Session["attemptCount"] == null ? 0 : Session["attemptCount"]) + 1;
            Session["attemptCount"] = incrementedValue;
            outputLabel.Text = buildAttemptOutput(outputString, incrementedValue, !outputString.ToLower().Contains("correct"));


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