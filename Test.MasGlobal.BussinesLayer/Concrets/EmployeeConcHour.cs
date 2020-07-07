using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.MasGlobal.BussinesLayer.Abstract;
using Test.MasGlobal.BussinesLayer.Interfaces;

namespace Test.MasGlobal.BussinesLayer.Concrets
{
    public class EmployeeConcHour : EmployeeAbs
    {
        public EmployeeConcHour(int id, string name, string contractTypeName, int roleId, string roleName, 
                                string roleDescription,double hourlySalary)
                               : base(id, name, contractTypeName, roleId, roleName, roleDescription, hourlySalary) { }

        public override IContractType FactoryContractType()
        {
            return new EmployeeContractTypeHours();
        }
    }
}
