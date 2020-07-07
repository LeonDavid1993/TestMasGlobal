using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.MasGlobal.BussinesLayer.Interfaces;

namespace Test.MasGlobal.BussinesLayer.Concrets
{
    public class EmployeeContractTypeHours : IContractType
    {
        const int hours = 120;
        const int months = 12;

        public double CalcuteAnnualSalary(double salary)
        {
            return hours * salary * months;
        }
    }
}
