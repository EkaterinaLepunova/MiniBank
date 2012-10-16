using System.Web.Mvc;

namespace MiniBankProject.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //using (var client = new UsualClient("ServiceInterface.User"))
            //{
            //    ViewBag.Users = client.GetUserNames();
            //    ViewBag.UserPayments = client.GetUserPayments(1);
            //}
            //using (var client = new HelloServiceClient())
            //{
            //    ViewBag.Hello = client.DoWork("Dmitry");
            //}

            return View();
        }
        
        //private UsualClient CreateProxyClassByProgrammingSettings()
        //{
        //    // Создаем объект, описывающий адрес концевой точки
        //    var address = new EndpointAddress("net.tcp://localhost:8228/User");
        //    // Создаем объект, описывающий привязку
        //    var binding = new NetTcpBinding();
        //    // Создаем прокси-класс
        //    return new UsualClient(binding, address);
        //}
    }
}
