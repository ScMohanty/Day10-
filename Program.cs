using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
       
        public static void Main(string[]args)
        {
            int no_Of_Vacency;
            
            Console.WriteLine("ENTER NUMBER OF VACENCY");
            no_Of_Vacency = Convert.ToInt32(Console.ReadLine());
            Job[] job_Details =new Job[no_Of_Vacency];
           


            for (int i=0;i<no_Of_Vacency;i++)
            {
                long salary;
                Console.WriteLine("ENTER SALARY");
                salary = Convert.ToInt64(Console.ReadLine());
                string role;
                Console.WriteLine("ENTER JOB ROLE");
                role = Console.ReadLine();
                Console.WriteLine("ENTER SKILL SET");

                string skillSet = Console.ReadLine();
                Console.WriteLine("ENTER EMPLOYEMENT TYPE");
                string employmentType = Console.ReadLine();
                Console.WriteLine("ENTER THE LOCATION");
                string location = Console.ReadLine();
                Console.WriteLine("ENTER THE EXPERIENCE");
                int minExperience = Convert.ToInt32(Console.ReadLine());
                job_Details[i] =Job. CreateJob(salary, role, skillSet, employmentType, location, minExperience);

            }
            SalaryComparator sort_By_Sal = new SalaryComparator();
            Array.Sort(job_Details,sort_By_Sal);
            Console.WriteLine("%-20s %-15s %-10s %-15s %s\n", "Role", "Employment Type", "Location", "Min. Experience", "Salary");
            foreach (var k in job_Details)
            {
                Console.WriteLine(k);
            }
        }

       
    }
}
