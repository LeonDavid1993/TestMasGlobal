using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.MasGlobal.API;
using Test.MasGlobal.API.Controllers;
using Test.MasGlobal.BussinesLayer.Abstract;

namespace Test.MasGlobal.API.Tests.Controllers
{
    [TestClass]
    public class EmployeeControllerTest
    {
        [TestMethod]
        public void Post()
        {
            // Arrange
            string identification = "1";
            EmployeeController controller = new EmployeeController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            // Act
            IHttpActionResult actionResult = controller.GetEmployees(identification);
            var contentResult = actionResult as OkNegotiatedContentResult<List<EmployeeAbs>>;

            // Assert
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual(1, contentResult.Content.FirstOrDefault().Id);
        }

    }
}
