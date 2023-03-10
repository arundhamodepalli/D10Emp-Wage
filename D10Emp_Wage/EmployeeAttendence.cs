using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D10Emp_Wage
{
        public class EmployeeAttendence
        {
            public static void Employee_Attendence()
            {
                //Constants
                int IS_FULL_TIME = 1;
                Random random = new Random();
                //Computation
                int empCheck = random.Next(0, 2);
                if (empCheck == IS_FULL_TIME)
                {
                    Console.WriteLine("Employee is Present");
                }
                else
                {
                    Console.WriteLine("Employee is Abscent");
                }
            }
        }
}
