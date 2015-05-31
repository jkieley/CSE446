using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void generateNumber_Click(object sender, EventArgs e)
        {
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

            Uri uri = new Uri("http://localhost:1000/Service.svc/SecretNumber?lower="+lower.ToString()+"&upper="+upper.ToString());
            WebClient proxy = new WebClient();
            string response = proxy.DownloadString(uri);
            Console.WriteLine(response);


        }

        protected void play_Click(object sender, EventArgs e)
        {

        }
    }
}