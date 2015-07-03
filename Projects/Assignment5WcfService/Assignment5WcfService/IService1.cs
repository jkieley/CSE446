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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        void sendMessage(string senderId, string receiverId, string message);

        [OperationContract]
        List<Message> receiveMsg(string receiverId);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Message
    {
        public string SenderId { get; set; }
        public string ReceiverId { get; set; }
        public string Message { get; set; }
        public XElement toElement() {
            return new XElement("Message",
                new XAttribute("SenderId", this.SenderId),
                new XAttribute("ReceiverId", this.ReceiverId),
                this.Message);
        }
    }
}

