using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.MasGlobal.Common.DTO;
using Test.MasGlobal.Common.Helpers;

namespace Test.MasGlobal.UI.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(EmployeeAPI param)
        {
            List<EmployeeAPIResponse> response = ApiService
            .Post<List<EmployeeAPIResponse>>(ConfigurationHelper.Get("ApiBase"), ConfigurationHelper.Get("Proxy.Base"),
                string.Format(ConfigurationHelper.Get("Proxy.GetEmployees"), param.Id), null);

            return PartialView("~/Views/Customer/Partials/_ListEmployees.cshtml", response);
        }
    }
}