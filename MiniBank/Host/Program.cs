using System;
using System.ServiceModel;
using ServiceInterface;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            RunServiceHost();   
            
        }

        private static void RunServiceHost()
        {

            //ServiceHost host = CreateServiceHostByProgram();
            ServiceHost host = CreateServiceHostByConfigurationFile();
            try
            {
                host.Open();
                Console.ReadLine();
                host.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                host.Abort();
                throw;
            }
        }
        private static ServiceHost CreateServiceHostByConfigurationFile()
        {
            return new ServiceHost(typeof(User));
        }
        private static ServiceHost CreateServiceHostByProgram()
        {
            //
            // Set settings programly
            //
            //// 1. Создаем объект, описывающий адрес службы
            var uri = new Uri("net.tcp://localhost:8228/User");

            //// 2. Создаем объект, описывающий привязку
            var binding = new NetTcpBinding();

            //// 3. Создаём хостинг для службы
            var host = new ServiceHost(typeof(User));
            host.AddServiceEndpoint(typeof(IUser), binding, uri);
            
            return host;
        }
    }
}
