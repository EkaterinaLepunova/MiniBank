using System.Collections.Generic;
using System.ServiceModel;
using Dal;
using ServiceInterface;

namespace MiniBankProject.Models
{
    public class UsualClient : ClientBase<IUser>, IUser
    {
        public UsualClient() { }

        public UsualClient(string endpointConfigurationName) :
            base(endpointConfigurationName) { }

        public UsualClient(string endpointConfigurationName,
                              string remoteAddress) :
            base(endpointConfigurationName, remoteAddress) { }

        public UsualClient(string endpointConfigurationName,
                              EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress) { }
        public UsualClient(System.ServiceModel.Channels.Binding binding, EndpointAddress remoteAddress) :
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
