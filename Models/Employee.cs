using System;
using System.Collections.Generic;
using System.Text;

namespace _18_04_22_homework.Models
{
    class Employee
    {
        public int no { get; set; }
        public string Fullname { get; set; }
        public string Position { get; set; }
        public int  salary  { get; set; }
        public static int id;
        public Employee() 
        {
            no = id;
            id++;
        
        }


    }
}
