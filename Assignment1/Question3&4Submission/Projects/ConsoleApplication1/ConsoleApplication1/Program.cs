using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace SelfHostingService
{
    [ServiceContract]
    public interface INumberGuessService
    { // Use interface to define contracts
        [OperationContract]
        int SecretNumber(int lower, int upper);

        [OperationContract]
        string checkNumber(int userNum, int SecretNum);
    }
    public class NumberGuessService : INumberGuessService
    {
        public int SecretNumber(int lower, int upper)
        {
            DateTime currentDate = DateTime.Now;
            int seed = (int)currentDate.Ticks;
            Random random = new Random(seed);
            int sNumber = random.Next(lower, upper);
            return sNumber;
        }

        public string checkNumber(int userNum, int SecretNum)
        {
            if (userNum == SecretNum)
                return "correct";
            else
                if (userNum > SecretNum)
                    return "too big";
                else return "too small";
        }
    }
    class Program {
        static void Main(string[] args)
        {
            // (1) Create a URI instance to myService as the base address.
            Uri baseAddress = new Uri("http://localhost:8000/Service");
            // (2) a new ServiceHost instance to host the service
            ServiceHost selfHost = new ServiceHost(typeof(NumberGuessService), baseAddress); // with address
            try { // (3) Add a service endpoint with contract and binding
                selfHost.AddServiceEndpoint(typeof(INumberGuessService), new WSHttpBinding(), "myService"); // (4) Add metadata for platform-independent access.
                System.ServiceModel.Description.ServiceMetadataBehavior smb = new System.ServiceModel.Description.ServiceMetadataBehavior();
                smb.HttpGetEnabled = true; // enable the metadata
                selfHost.Description.Behaviors.Add(smb); // Add here
                // (5) Start the service and waiting for request.
                selfHost.Open();
                Console.WriteLine("NumberGuessService is ready to take requests. Please create a client to call SecretNumber(int lower, int upper) service or int checkNumber(int userNum, int SecretNum) service.");
                Console.WriteLine("If you want to quit this service, simply press <ENTER>.\n");
                Console.ReadLine(); // (6) Close the ServiceHostBase to shutdown the service.
                selfHost.Close();
            } catch (CommunicationException ce) {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                selfHost.Abort();
            }
        }
    }
}
