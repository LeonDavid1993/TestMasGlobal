using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.MasGlobal.BussinesLayer.Interfaces;

namespace Test.MasGlobal.BussinesLayer.Abstract
{
    public abstract class EmployeeAbs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public double Salary { get; set; }
        public double AnnualSalary { get; set; }

        public EmployeeAbs(int id, string name, string contractTypeName, int roleId, string roleName,
                                string roleDescription, double salary)
        {
            Id = id;
            Name = name;
            ContractTypeName = contractTypeName;
            RoleId = roleId;
            RoleName = roleName;
            RoleDescription = roleDescription;
            Salary = salary;
            AnnualSalary = AnnualSalaryMethod(salary);
        }

        public abstract IContractType FactoryContractType();

        public double AnnualSalaryMethod(double salary)
        {
            var contractType = FactoryContractType();
            return contractType.CalcuteAnnualSalary(salary);
        }
    }
}
