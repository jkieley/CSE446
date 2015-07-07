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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uuid"] == null) {
                Session["uuid"] = uuid();
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string receiverId = Request.Form["receiverId"];
            string senderId = (string) Session["uuid"];
            string messageContent = Request.Form["messageContent"];
            WCFMessageService.Service1Client client = new WCFMessageService.Service1Client();
            client.sendMessage(senderId, receiverId, messageContent);
        }

        protected static string uuid()
        {
            return System.Guid.NewGuid().ToString();
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            LastUpdated.Text = "Last updated at: " + DateTime.Now.ToLongTimeString();
            recieveMsg_Click(sender, e);
        }

        protected void recieveMsg_Click(object sender, EventArgs e)
        {
            string receiverId = (string) Session["uuid"];
            TextBox1.Text = "";
            WCFMessageService.Service1Client client = new WCFMessageService.Service1Client();
            WCFMessageService.Message[] messages =  client.receiveMsg(receiverId);
            foreach(WCFMessageService.Message message in messages){
                TextBox1.Text += message.Content + "\n";
            }
        }

    }
}