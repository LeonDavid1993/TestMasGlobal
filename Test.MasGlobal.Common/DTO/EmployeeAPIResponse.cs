using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.MasGlobal.Common.DTO
{
    public class EmployeeAPIResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public double Salary { get; set; }
        public double AnnualSalary { get; set; }
    }

    public class EmployeeAPI
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
