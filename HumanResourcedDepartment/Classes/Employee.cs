namespace HumanResourcedDepartment
{
    public class Employee
    {
        public string Name { get; set; }
        public string Passport { get; set; }
        public string Job { get; set; }

        public Employee(string name, string passport, string job)
        {
            Name = name;
            Passport = passport;
            Job = job;
        }

        public void ChangeData(string name, string passport, string job)
        {
            if(!string.IsNullOrEmpty(name))
            {
                Name = name;
            }
            if(!string.IsNullOrEmpty(passport))
            {
                Passport = passport;
            }
            if (!string.IsNullOrEmpty(job))
            {
                Job = job;
            }
        }
    }
}
