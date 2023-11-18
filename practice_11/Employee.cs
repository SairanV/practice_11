using practice_11.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_11
{
    public struct Employee
    {
        public string Name;
        public Vacancies Vacancy;
        public int[] HireDate;
        public int Salary;

        public Employee(string name, Vacancies vacancy, int[] hireDate, int salary)
        {
            Name = name;
            Vacancy = vacancy;
            HireDate = hireDate;
            Salary = salary;
        }

        public Employee(string name, Vacancies vacancy, int salary)
        {
            Name = name;
            Vacancy = vacancy;
            HireDate = new int[] { 0, 0, 0 };
            Salary = salary;
        }
    }
}