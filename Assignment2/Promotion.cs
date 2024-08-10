using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public static class Promotion
    {
        public static List<Employee> Promote(List<Employee> employees, Func<Employee, bool> PromotionCriteria)
        {
            List<Employee> promotedEmployees = new List<Employee>();

            foreach (var emp in employees)
            {
                if (PromotionCriteria(emp))
                {
                    promotedEmployees.Add(emp);
                }
            }
            return promotedEmployees;


        }
        public static bool SalaryCriteria(Employee emp)
        {
            return emp.Salary < 10000;
        }

        public static bool ExperienceCriteria(Employee emp)
        {
            return emp.Experience > 5;
        }
    }
}
