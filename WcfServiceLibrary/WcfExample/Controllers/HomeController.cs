using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WcfExample.InternalService;
using WcfServiceLibrary;

namespace WcfExample.Controllers
{
    public class HomeController : Controller
    {
        IService client = new Service(); // Burada polimorfizm nimettinden yararlanılmıştır. Wcf Libraryden gelen Service Örneği
        IServiceInternal _clientInternal = new ServiceInternal();
        public ActionResult Index()
        {
            var TotalResult = client.Add(5, 8);
            ViewBag.Result1 = TotalResult;

            var TotalSubstract = client.Substract(5, 8);
            ViewBag.Result2 = TotalSubstract;

            var TotalMultiple = _clientInternal.Multiple(12, 12);
            ViewBag.Result3 = TotalMultiple;

            return View();
        }
    }
}