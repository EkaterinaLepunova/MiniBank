using System.Collections.Generic;
using System.ServiceModel;
using Dal;
using ServiceInterface;

namespace TestWCFService
{
    public class Client : ClientBase<IUser>, IUser
    {
        public Client() { }

        public Client(string endpointConfigurationName) :
            base(endpointConfigurationName) { }

        public Client(string endpointConfigurationName,
                              string remoteAddress) :
            base(endpointConfigurationName, remoteAddress) { }

        public Client(string endpointConfigurationName,
                              EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress) { }
        public Client(System.ServiceModel.Channels.Binding binding, EndpointAddress remoteAddress) :
            base(binding, remoteAddress) { }

        public List<string> GetUserNames()
        {
            return base.Channel.GetUserNames();
        }

        public List<PaymentModel> GetUserPayments(int userId)
        {
            return base.Channel.GetUserPayments(userId);
        }
    }
}
