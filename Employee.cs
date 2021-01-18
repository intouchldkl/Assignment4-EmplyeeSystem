using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4_EmplyeeSystem
{
    class Employee
    {
        private string name;
        private int age;
        private DateTime DOB;
        private string job;
        private double salary;

        private static int employeeCount;
        private static int retirementAge = 65;

        public Employee(string name, DateTime DOB, string job, double salary)
        {
            this.name = name;
            this.job = job;
            this.salary = salary;
            this.DOB = DOB;

            //employeeCount = employeeCount + 1;
            //employeeCount +=1;
            employeeCount++;
        }
        public static int GetNumberOfEmployee()
        {
            
            return employeeCount;
        }
        public double GetMonthlySalary()
        {
            double MonthlySalary = salary / 12;

            return MonthlySalary;
        }
        public bool isBirthday()
        {
            int month = DOB.Month;
            int day = DOB.Day;

            if (month == DateTime.Now.Month && day == DateTime.Now.Day)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void SetAge()
        {
            age = DateTime.Now.Year - DOB.Year;
        }
        public int GetYearsLeft()
        {
            SetAge();

            int YearsLeft = retirementAge - age;

            return YearsLeft;
        }
        public string GetAllInfo()
        {
            string information = name + " " + age + " " + job + " " + salary;
            return information;
        }
        public void setJob(string newJob)
        {
            job = newJob;
        }
        public void setSalary(double newSalary)
        {
            salary = newSalary;
        }


    }
}
