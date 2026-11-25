using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp2
{
    internal class Student
    {
        public string name_surname { get; set; }
        public List<decimal> grades { get; set; }

        public Student(string name_surname, List<decimal> grades)
        {
            this.name_surname = name_surname;
            this.grades = grades;
        }
    }
}
