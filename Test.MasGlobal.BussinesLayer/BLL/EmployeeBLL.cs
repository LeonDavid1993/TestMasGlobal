using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.MasGlobal.BussinesLayer.Abstract;
using Test.MasGlobal.BussinesLayer.Concrets;
using Test.MasGlobal.Common.DTO;
using Test.MasGlobal.Common.Enums;
using Test.MasGlobal.Common.Helpers;
using Test.MasGlobal.DataAccessLayer.DAO;

namespace Test.MasGlobal.BussinesLayer.BLL
{
    public class EmployeeBLL
    {
        private static List<EmployeeAPIMasGlobalDTO> GetEmployeesApiMasGlobal()
        {
            List<EmployeeAPIMasGlobalDTO> employees = EmployeeDAO.GetEmployeesApiMasGlobal();

            return employees;
        }

        public static List<EmployeeAbs> GetEmployees(string id)
        {
            List<EmployeeAPIMasGlobalDTO> employees = GetEmployeesApiMasGlobal();

            if (!string.IsNullOrEmpty(id))
                employees = employees.Where(k => k.id == Convert.ToInt32(id)).ToList();

            List<EmployeeAbs> listReturn = new List<EmployeeAbs>();

            foreach (EmployeeAPIMasGlobalDTO emp in employees)
            {
                switch (EnumHelper.Parse<ContractTypes>(emp.contractTypeName))
                {
                    case ContractTypes.HourlySalaryEmployee:
                        listReturn.Add(new EmployeeConcHour(emp.id,emp.name,emp.contractTypeName,emp.roleId,emp.roleName,emp.roleDescription,emp.hourlySalary));
                        break;
                    case ContractTypes.MonthlySalaryEmployee:
                        listReturn.Add(new EmployeeConcMonthly(emp.id, emp.name, emp.contractTypeName, emp.roleId, emp.roleName, emp.roleDescription, emp.monthlySalary));
                        break;
                    default:
                        break;
                }
            }

            return listReturn;
        }
    }
}
