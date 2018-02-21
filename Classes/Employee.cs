using System.Collections.Generic;

namespace Classes
{
    public class Department
    {
        public string Name { get; set; }

        public List<Employee> Employees { get; set; }
    }

    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Position { get; set; }

        private string email = "n/a";
        private int age = -1;

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public int Age { get { return this.age; } set { this.age = value; } }

        public override string ToString()
        {
            return $"{Name} {Salary:F2} {email} {age}";
        }
    }
    //public class Department
    //{
    //    //private string name;
    //    private decimal salary;
    //    private int brSlujiteli;

    //    //public string Name { get { return this.name; } set { this.name = value; } }
    //    public decimal Salary { get { return this.salary; } set { this.salary = value; } }
    //    public int BrSlujiteli { get { return this.brSlujiteli; } set { this.brSlujiteli = value; } }
    //}
}
