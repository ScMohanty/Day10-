using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Job:IComparable
    {
        private string role;
        private string skillSet;
        private string employmentType;
        private string location;
        private int minExperience;
        private long salary;

        public Job()
        {
        }

        public Job(long salary, string role, string skillSet, string employmentType, string location, int minExperience)
        {
            Salary = salary;
            Role = role;
            SkillSet = skillSet;
            EmploymentType = employmentType;
            Location = location;
            MinExperience = minExperience;
        
        }

        public string Role { get => role; set => role = value; }
        public string SkillSet { get => skillSet; set => skillSet = value; }
        public string EmploymentType { get => employmentType; set => employmentType = value; }
        public string Location { get => location; set => location = value; }
        public int MinExperience { get => minExperience; set => minExperience = value; }
        public long Salary { get => salary; set => salary = value; }

      
        public static Job CreateJob( long salary,string role,string  skillSet,string employmentType,string location,int  minExperience)
        {
            Job j = new Job();
            
            j.Salary = salary;
            j.Role = role;
            j.SkillSet = skillSet;
            j.EmploymentType = employmentType;
            j.Location = location;
            j.MinExperience = minExperience;

            return j;
        }

        public int CompareTo(object obj)
        {
            Job j = (Job)obj;

            return this.MinExperience.CompareTo(j.MinExperience);
        }

        public override bool Equals(object obj)
        {
            Job j2 = (Job)obj;

            return this.MinExperience.Equals(j2.MinExperience);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0}     {1}      {2}   {3}",Role,EmploymentType,Location ,MinExperience, Salary);
        }

    }
    
   
}
