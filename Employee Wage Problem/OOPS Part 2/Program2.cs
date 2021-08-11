using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_Part_2
{
    class Program2
    {
        static void Main(String[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("Total Wage for Dmart Company : "+empWageBuilder.getTotalWage("Dmart"));
        }
    }
}
