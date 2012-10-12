using System.Collections.Generic;
using System.ServiceModel;
using Dal;

namespace ServiceInterface
{
    [ServiceContract]
    public interface IUser
    {
        [OperationContract]
        List<string> GetUserNames();

        [OperationContract]
        List<PaymentModel> GetUserPayments(int userId);
    }
}