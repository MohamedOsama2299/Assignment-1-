using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__1__
{
    enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA,
        SecurityOfficer
    }

    enum Permissions
    {
        None,
        Read,
        Write,
        Delete,
        Execute
    }
    enum gender
    {
        m,
        f,
        M,
        F,
        Male,
        Female,
        male,
        female
    }
    internal class Employee2
    {
        private int ID { get; set; }
        private string Name { get; set; }
        private SecurityLevel SecurityLevel { get; set; }
        private decimal Salary { get; set; }
        private HiringDate HireDate { get; set; }
        private gender Gender { get; set; }
        private Permissions permission { get; set; }

        private Employee2() { }

        public Employee2(int id, string name, SecurityLevel secLevel, decimal salary, HiringDate hireDate, char gender, Permissions permission)
        {
            ID = id;
            Name = name;
            SecurityLevel = secLevel;
            Salary = salary;
            HireDate = hireDate;
            this.Gender = Gender;
            this.permission = permission;
        }
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Salary: {Salary}, HireDate: {HireDate}, Level: {SecurityLevel}, Permissions: {permission}";
        }
    }
}
