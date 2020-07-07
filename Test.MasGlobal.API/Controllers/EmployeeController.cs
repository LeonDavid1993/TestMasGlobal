using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Test.MasGlobal.BussinesLayer.Abstract;
using Test.MasGlobal.BussinesLayer.BLL;

namespace Test.MasGlobal.API.Controllers
{
    [RoutePrefix("api")]
    public class EmployeeController : ApiController
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();

        // GET: Customer
        [HttpPost]
        [Route("GetEmployees")]
        public IHttpActionResult GetEmployees(string identification)
        {
            List<EmployeeAbs> listEmployees = new List<EmployeeAbs>();
            try
            {
                listEmployees = EmployeeBLL.GetEmployees(identification);
            }
            catch (Exception ex)
            {
                logger.Error(ex, string.Format("Error durante la consulta del empleado, identificado con : {0}", identification));
            }

            return Ok(listEmployees);
        }
    }
}