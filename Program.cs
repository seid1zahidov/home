using System;
using _18_04_22_homework.Models;

namespace _18_04_22_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Fullname = "Ilkin Zahidov";

            e1.salary = 999999999;
            e1.Position = "Ful stack develeopmet";

            Employee e2 = new Employee();
            e2.Fullname = "Said Zahidov";

            e2.salary = 987654321;
            e2.Position = "Fulun fulu develeoper";

            Employee e3 = new Employee();
            e3.Fullname = "Nicat Muxtarov";

            e3.salary = 250;
            e3.Position = "sweeper";

            string comp98 = Console.ReadLine();
            Company company = new Company(comp98);
        }
    }
}
