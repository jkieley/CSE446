using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.Linq;

namespace Assignment5WcfService
{
    public class Service1 : IService1
    {
        string dbFileName = "~/App_Data/XMLMessagesDb.xml";
        void sendMessage(string senderId, string receiverId, string message) {
            XElement messages = XElement.Load(dbFileName);
            messages.Add(new Message { SenderId = senderId, ReceiverId = receiverId, Message = message }.toElement());
            messages.Save(dbFileName);
        }

        List<Message> receiveMsg(string receiverId) {
            return null;
        }
    }
}
