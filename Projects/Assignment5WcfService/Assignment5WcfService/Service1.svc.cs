using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.Linq;
using System.Web.Hosting;
using System.IO;

namespace Assignment5WcfService
{
    public class Service1 : IService1
    {
        string dbFileLocation = Path.Combine(
            HostingEnvironment.ApplicationPhysicalPath,
            @"App_Data\XMLMessagesDb.xml"
        );         


        public void sendMessage(string senderId, string receiverId, string message) {
            XElement messages = XElement.Load(dbFileLocation);
            messages.Add(new Message { SenderId = senderId, ReceiverId = receiverId, Content = message }.toElement());
            messages.Save(dbFileLocation);
        }

        public List<Message> receiveMsg(string receiverId) {
            XElement allMessages = XElement.Load(dbFileLocation);

            IEnumerable<XElement> messagesForThatReciever =
            from c in allMessages.Elements("Message")
            where (string)c.Attribute("ReceiverId") == receiverId
            select c;

            return Message.converList(messagesForThatReciever);
        }
    }
}
