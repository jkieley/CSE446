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
        [DataMember]
        public string SenderId { get; set; }
        [DataMember]
        public string ReceiverId { get; set; }
        [DataMember]
        public string Content { get; set; }

        public Message(){}

        public Message(XElement element) {
            this.SenderId = (string) element.Attribute("SenderId");
            this.ReceiverId = (string) element.Attribute("ReceiverId");
            this.Content = element.Value;
        }
        
        public XElement toElement() {
            return new XElement("Message",
                new XAttribute("SenderId", this.SenderId),
                new XAttribute("ReceiverId", this.ReceiverId),
                this.Content);
        }

        public static List<Message> converList(IEnumerable<XElement> list)
        {
            List<Message> messageList = new List<Message>();
            var enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())
            {
                XElement element = enumerator.Current;
                messageList.Add(new Message(element));
            }

            return messageList;
        }
    }
}

