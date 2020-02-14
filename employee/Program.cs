using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    class Employee 
    {
        private string fullName;
        private int age;
        private double salary, pension, taxes;

        public string FullName { get { return fullName; } set { fullName = value; } }
        public int Age { get { return age; } set { age = value; } }
        public double Salary { get { return salary; } set { salary = value; } }
        public double Pension { get { return pension; } set { pension = value; } }
        public double Taxes { get { return taxes; } set { taxes = value; } }

        public Employee() { }

        public Employee(string fullName, int age, int salary)
        {
            this.fullName = fullName;
            this.age = age;
            this.salary = salary;
        }

        public void totalSalary()
        {
            pension = salary * 0.05;
            taxes = salary * 0.05;
            Console.WriteLine($"Full Name: {fullName}\nAge: {age}\nClean salary: {salary}\nPension deduction: {pension}\nTaxes: {taxes}\nTotal salary: {salary - (taxes + pension)}");
        }
    }

    class Manager : Employee 
    {
        int tickets;
        public int Tickets { get { return tickets; } set { tickets = value } }
        public Manager() { }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Employee niba = new Employee("aaaaaa", 26, 100000);
            niba.totalSalary();
            Console.ReadKey();
        }
    }
}
