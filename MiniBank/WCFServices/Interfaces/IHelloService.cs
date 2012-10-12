﻿using System.ServiceModel;

namespace WCFServices.Interfaces
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHelloService" in both code and config file together.
    [ServiceContract]
    public interface IHelloService
    {
        [OperationContract]
        string DoWork(string name);
    }
}
