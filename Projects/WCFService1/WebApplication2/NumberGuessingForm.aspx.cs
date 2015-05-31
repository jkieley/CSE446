using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

            Uri baseUri = new Uri("http://localhost:1000/Service.svc");
            UriTemplate template = new UriTemplate("SecretNumber/{lower}/{upper}");
            Uri completeUri = template.BindByPosition(baseUri, new string[] { lower.ToString(), upper.ToString() });


        }

        protected void play_Click(object sender, EventArgs e)
        {

        }
    }
}