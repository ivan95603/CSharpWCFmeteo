using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace cSharpVezba9V2
{
    class Program
    {
        [ServiceContract]
        public interface ISistemServis
        {
            [OperationContract]
            string Temperatura(string stanica, int vrednost, DateTime vreme);
        }


        [ServiceContract]
        public interface IJavniServis
        {
            [OperationContract]
            double ProsecneTemperature(string stanica, DateTime pocetak, DateTime kraj);
        }


        public class SistemServis : ISistemServis
        {
            public string Temperatura(string stanica, int vrednost, DateTime vreme)
            {
                return "TEMP";
            }
        }

        public class JavniServis : IJavniServis
        {
            public double ProsecneTemperature(string stanica, DateTime pocetak, DateTime kraj)
            {
                return 3.14;
            }
        }

        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8732/MeteoServis/SistemServis");
            Uri baseAddress2 = new Uri("http://localhost:8732/MeteoServis/JavniServis");

            // Create the ServiceHost.
            ServiceHost host = new ServiceHost(typeof(SistemServis), baseAddress);
            
            // Enable metadata publishing.
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                host.Description.Behaviors.Add(smb);

                // Open the ServiceHost to start listening for messages. Since
                // no endpoints are explicitly configured, the runtime will create
                // one endpoint per base address for each service contract implemented
                // by the service.
                host.Open();
                

            // Create the ServiceHost.
            ServiceHost host2 = new ServiceHost(typeof(JavniServis), baseAddress2);

            // Enable metadata publishing.
            ServiceMetadataBehavior smb2 = new ServiceMetadataBehavior();
            smb2.HttpGetEnabled = true;
            smb2.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
            host2.Description.Behaviors.Add(smb2);

            // Open the ServiceHost to start listening for messages. Since
            // no endpoints are explicitly configured, the runtime will create
            // one endpoint per base address for each service contract implemented
            // by the service.
            host2.Open();


            Console.WriteLine("The service is ready at {0}", baseAddress);
            Console.WriteLine("The service is ready at {0}", baseAddress2);
            Console.WriteLine("Press <Enter> to stop the service.");
            Console.ReadLine();

            // Close the ServiceHost.
            host.Close();
            host2.Close();

        }
    }
}
