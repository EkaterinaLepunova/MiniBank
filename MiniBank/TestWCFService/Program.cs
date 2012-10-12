using System;
using System.Collections.Generic;
using System.ServiceModel;
using TestWCFService.HelloService;

namespace TestWCFService
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestForUsualWebService();
            TestForWCFService();

            Console.ReadLine();
        }

        #region Test "HelloService" WCF
        private static void TestForWCFService()
        {
            using(var client = new HelloServiceClient())
            {
                Console.WriteLine(client.DoWork("Kate"));
            }
        }
        #endregion

        #region Test "MyFirstWebService"

        private static void TestForUsualWebService()
        {
            //UsualClient client = CreateProxyClassByProgrammingSettings()
            Client client = CreateProxyClassByConfigurationSettings();
            WorkWithService(client);
            client.Close();
        }

        private static Client CreateProxyClassByConfigurationSettings()
        {
            return new Client("User");
        }

        private static Client CreateProxyClassByProgrammingSettings()
        {
            // Создаем объект, описывающий адрес концевой точки
            var address = new EndpointAddress("net.tcp://localhost:8228/User");
            // Создаем объект, описывающий привязку
            var binding = new NetTcpBinding();
            // Создаем прокси-класс
            return new Client(binding, address);
        }

        private static void WorkWithService(Client client)
        {
            // Работаем с сервисом через прокси
            Console.WriteLine("All users:");
            List<string> names = client.GetUserNames();
            foreach (string s in names)
            {
                Console.WriteLine("\t{0}", s);
            }
            Console.WriteLine("\n");
            Console.Write("Input user id to find out his payments: ");
            string str = Console.ReadLine();
            int id;
            Int32.TryParse(str, out id);
            var payments = client.GetUserPayments(id);
            Console.WriteLine("\tUser: {0} {1}", payments[0].FirstName, payments[0].LastName);
            foreach (var p in payments)
            {
                Console.WriteLine("\t\tNumber:{0}   Sum: {1}", p.PaymentId, p.Sum);
            }
        }

        #endregion
    }
}
