using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.MasGlobal.Common.DTO;
using Test.MasGlobal.Common.Helpers;

namespace Test.MasGlobal.DataAccessLayer.DAO
{
    public class EmployeeDAO
    {
        public static List<EmployeeAPIMasGlobalDTO> GetEmployeesApiMasGlobal()
        {
            List<EmployeeAPIMasGlobalDTO> response = ApiService
            .Get<List<EmployeeAPIMasGlobalDTO>>(ConfigurationHelper.Get("ApiBase"), ConfigurationHelper.Get("Proxy.Base"),
                                    ConfigurationHelper.Get("Proxy.GetEmployees"));

            return response;
        }
    }
}
