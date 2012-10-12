using WCFServices.Interfaces;

namespace WCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HelloService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HelloService.svc or HelloService.svc.cs at the Solution Explorer and start debugging.
    public class HelloService : IHelloService
    {
        public string DoWork(string name)
        {
            return string.Format("You're welcome, {0}!", name);
        }
    }
}
