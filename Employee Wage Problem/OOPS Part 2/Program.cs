using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Text;

namespace OOPS_Part_2
{
    public interface IComputeEmpWage
    {
       public void addCompanyEmpWage(string company, int empRatePerHour, int numOfworkingDays, int maxHoursPerMonth);
       public void computeEmpWage();
       public int getTotalWage(string company);
            
    }
    
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;

        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
            this.totalEmpWage = 0;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string toString()
        {
            return "Total Emp Wage for company: " + this.company + "is: " + this.totalEmpWage;
        }
    }

    public class EmpWageBuilder: IComputeEmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private LinkedList<CompanyEmpWage> CompanyEmpWageList;
        private Dictionary<string, CompanyEmpWage> CompanyToEmpWageMap;

        public EmpWageBuilder()
        {
            this.CompanyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.CompanyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }

        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            this.CompanyEmpWageList.AddLast(companyEmpWage);
            this.CompanyToEmpWageMap.Add(company, companyEmpWage);
        }
        
        public void computeEmpWage()
        {
            foreach(CompanyEmpWage companyEmpWage in this.CompanyEmpWageList)
            {
                companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
        }

        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHours = 0, totalEmpHours = 0, totalWorkingDays = 0;
            while(totalEmpHours <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random rand = new Random();
                int empCheck = rand.Next(0, 3);
                switch(empCheck)
                {
                    case IS_PART_TIME:
                        empHours = 4;
                        break;
                    case IS_FULL_TIME:
                        empHours = 8;
                        break;
                    default:
                        empHours = 0;
                        break;
                }
                totalEmpHours += empHours;
                Console.WriteLine("Day "+totalWorkingDays+" Emp Hours: "+empHours);
            }
            return totalEmpHours = companyEmpWage.empRatePerHour;
        }

        public int getTotalWage(String company)
        {
            return this.CompanyToEmpWageMap[company].totalEmpWage;
        }
    }
}
