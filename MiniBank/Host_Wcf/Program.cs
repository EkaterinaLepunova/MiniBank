using System;
using System.ServiceModel;

namespace Host_Wcf
{
    class Program
    {
        static void Main(string[] args)
        {
            RunWcfServicehost();
        }

        private static void RunWcfServicehost()
        {
            var serviceHttpAddress = new Uri("http://localhost:10001/HelloService/");
            var serviceNetTcpAddress = new Uri("net.tcp://localhost:10002/HelloService/");
            var serviceHost = new ServiceHost(typeof(WCFServices.HelloService), serviceHttpAddress, serviceNetTcpAddress);
            try
            {
                serviceHost.AddDefaultEndpoints();
                serviceHost.Open();
                Console.ReadLine();
                serviceHost.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                serviceHost.Abort();
                throw;
            }
        }
    }
}
