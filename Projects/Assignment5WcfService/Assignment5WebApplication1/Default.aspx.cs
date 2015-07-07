using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment5WebApplication1
{
    public partial class Index : System.Web.UI.Page
    {

        public string test = uuid();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            String receiverId = Request.Form["receiverId"];
            String senderId = Request.Form["senderId"];
        }

        protected static string uuid()
        {
            return System.Guid.NewGuid().ToString();
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            LastUpdated.Text = "Last updated at: " + DateTime.Now.ToLongTimeString();
        }

    }
}