using DependencyInjection.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DependencyInjection.Controllers
{


    //public class BaseController : Controller
    //{
    //    protected readonly ILogger _logProvider;

    //    public BaseController() { }
    //    public BaseController(ILogger log)
    //    {
    //        this._logProvider = log;
            
    //    }

    //}

    public class HomeController : Controller
    {
        // Step 1:
        protected readonly ILogger _logProvider;

        public HomeController() { }

        // Step 2 :
        public HomeController(ILogger log)
        {
            this._logProvider = log;
            
        }
       
        public ActionResult Index()
        {
            // step 3 :
            string loggingMessage = _logProvider.LogWithMessage("8888","Error message Logged");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}