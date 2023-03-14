using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D10Emp_Wage
{
    public class EmpWageBuilder
    {
        public static void EmpWage_Builder()
        {

        }
        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalWage;

        public EmpWageBuilder(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public void calculateWage()
        {
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs < maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
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

            totalWage = totalEmpHrs * empRatePerHour;
        }

        public void displayWage()
        {
            Console.WriteLine("Total wage for " + company + " is " + totalWage);
        }
    }
}
        