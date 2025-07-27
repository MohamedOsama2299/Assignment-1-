using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__1__
{
    enum Gender
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
    enum Security_Level
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }
    internal class Employee
    {
        private int id;
        private string name;
        private Gender gender;
        private double Salary;
        private DateTime hireDate;
        private Security_Level SecurityLevel;
        public Employee(int id, string name, Gender gender, double salary, DateTime hireDate, Security_Level securityLevel)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.Salary = salary;
            this.hireDate = hireDate;
            this.SecurityLevel = securityLevel;
        }
        public override string ToString()
        {
            return $"Employee Info:\n ID: {id}\n  Name: {name}\n Gender :{gender} \n  Security Level:{SecurityLevel} \n Salary: {Salary} \n Hire Date:{hireDate}";
        }
    }
}