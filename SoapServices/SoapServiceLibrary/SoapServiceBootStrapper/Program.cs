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

        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            Log.Info("Starting the Soap Services");
            ServiceHost host = null;
            try
            {
                host = new ServiceHost(typeof(SoapServiceLibrary.ServiceImpl.AddressService));
                host.Open();
                Log.Info("Service is started & running at " + addressService);
            }
            catch(Exception ex)
            {
                host = null;
                Log.Error("Cannot Start Server due to " + ex.Message,ex);
            }
            if (host != null)
            {
                Console.WriteLine("Press Enter key to exit service");
                Console.ReadLine();
                host.Close();
                host = null;
            }
            
        }
    }
}
