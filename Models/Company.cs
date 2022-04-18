using System;
using System.Collections.Generic;
using System.Text;

namespace _18_04_22_homework.Models
{
    class Company
    {
        public string _Company;
        public string comPany
        {

            get => _Company;
            set
            {
                if (char.IsUpper(value[0]))
                {
                    foreach (char item in value)
                    {
                        while (!char.IsDigit(item) && !char.IsLetter(item) && !char.IsWhiteSpace(item))
                        {
                            Console.WriteLine("sehv yazmisan duzlet");
                        }
                    }
                    _Company = value;
                }
                else
                {
                    Console.WriteLine("duzgun deil");
                    return;
                }
            }

        }
        public int limit { get; set; }
        public Employee[] employees;
        public Company()
        {
            employees = new Employee[0];
        }
        public Company(string companyes)
        {
            comPany = companyes;
        }
        public void Adempolyers(Employee sademployee)
        {
            if (employees.Length < limit)
            {
                Array.Resize(ref employees, employees.Length + 1);
                employees[employees.Length - 1] = sademployee;
                return;
            }

        }
        public Employee[] Employees() 
        {
            return employees;
        
        }

    }
}
