using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SoapServiceBootStrapper
{
    /// <summary>
    /// Bootstrapper
    /// </summary>
    class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Program));

        private static string addressService = @"http://localhost:8733/SoapServiceLibrary/AddressService/";

        private static string contactInfoService = @"http://localhost:8733/SoapServiceLibrary/ContactInfoService/";

        private static readonly Dictionary<string, Type> serviceDictionary = new Dictionary<string, Type>()
        {
            { addressService,typeof(SoapServiceLibrary.ServiceImpl.AddressService) },
            {contactInfoService,typeof(SoapServiceLibrary.ServiceImpl.ContactInfoService) }
        };
        

       
        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            Log.Info("Starting the Soap Services");
            List<ServiceHost> serviceHosts = new List<ServiceHost>();
            foreach (var servicePair in serviceDictionary)
            {
                ServiceHost host = StartServiceHost(servicePair.Key,servicePair.Value);
                serviceHosts.Add(host);

            }
            Console.WriteLine("Press Enter key to exit service");
            Console.ReadLine();
            foreach(var host in serviceHosts)
            {
                if (host != null)
                {

                    host.Close();
                }
            }
            

        }

        private static ServiceHost StartServiceHost(string serviceAddress,Type serviceType  )
        {
            ServiceHost host = null;
            try
            {
                host = new ServiceHost(serviceType);
                host.Open();
                Log.Info("Service is started & running at " + serviceAddress);
            }
            catch (Exception ex)
            {
                host = null;
                Log.Error("Cannot Start Server due to " + ex.Message, ex);
            }

            return host;
        }
    }
}
