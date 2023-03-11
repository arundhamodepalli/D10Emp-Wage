using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D10Emp_Wage
{
    public class ComputeMultiple
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int Emp_Rate_Per_Hour = 20;
        public const int Num_Of_Working_Days = 2;
        public const int Max_Hrs_In_Month = 10;
        public static int Compute_Multiple(string company)
        {
            //variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //Computation
            while (totalEmpHrs <= Max_Hrs_In_Month && totalWorkingDays <Num_Of_Working_Days)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * Emp_Rate_Per_Hour; ;
            Console.WriteLine("Total Emp Wage for company :" + company +" is: " + totalEmpWage);
            return totalEmpWage;
        }
        static void main(string[] args)
        {
            Compute_Multiple("DMart", 20, 2, 10);
            Compute_Multiple("Reliance", 10, 4, 20);
      
        }

        private static void Compute_Multiple(string v1, int v2, int v3, int v4)
        {
            throw new NotImplementedException();
        }

        internal static void Compute_Multiple()
        {
            throw new NotImplementedException();
        }
    }
}
