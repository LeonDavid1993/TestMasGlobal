using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.MasGlobal.BussinesLayer.Abstract;
using Test.MasGlobal.BussinesLayer.Interfaces;

namespace Test.MasGlobal.BussinesLayer.Concrets
{
    public class EmployeeConcMonthly : EmployeeAbs
    {
        public EmployeeConcMonthly(int id, string name, string contractTypeName, int roleId, string roleName,
                                    string roleDescription, double monthlySalary)
                                    : base(id, name, contractTypeName, roleId, roleName, roleDescription, monthlySalary) { }

        public override IContractType FactoryContractType()
        {
            return new EmployeeContractTypeMonthly();
        }
    }
}
