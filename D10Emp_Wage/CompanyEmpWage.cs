using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D10Emp_Wage
{
    public class CompanyEmpWage
    {
        public static void Company_EmpWage()
        {

        }
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalWage;

        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
    }

    public class EmpWage
    {
        private int numOfCompanies;
        private CompanyEmpWage[] companyEmpWages;

        public EmpWage()
        {
            numOfCompanies = 0;
            companyEmpWages = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            companyEmpWages[numOfCompanies] = companyEmpWage;
            numOfCompanies++;
        }

        public void calculateWage()
        {
            for (int i = 0; i < numOfCompanies; i++)
            {
                int totalEmpHrs = 0;
                int totalWorkingDays = 0;

                while (totalEmpHrs < companyEmpWages[i].maxHoursPerMonth && totalWorkingDays < companyEmpWages[i].numOfWorkingDays)
                {
                    totalWorkingDays++;
                    Random random = new Random();
                    int empCheck = random.Next(0, 3);

                    switch (empCheck)
                    {
                        case 1:
                            int empHrs = 8;
                            totalEmpHrs += empHrs;
                            break;
                        case 2:
                            empHrs = 4;
                            totalEmpHrs += empHrs;
                            break;
                        default:
                            empHrs = 0;
                            totalEmpHrs += empHrs;
                            break;
                    }
                }

                companyEmpWages[i].totalWage = totalEmpHrs * companyEmpWages[i].empRatePerHour;
            }
        }

        public void displayWage()
        {
            for (int i = 0; i < numOfCompanies; i++)
            {
                Console.WriteLine("Total wage for " + companyEmpWages[i].company + " is " + companyEmpWages[i].totalWage);
            }
        }
    }
}
