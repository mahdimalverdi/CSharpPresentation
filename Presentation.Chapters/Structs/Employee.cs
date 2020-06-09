using System;

namespace Presentation.Chapters.Structs
{
    internal struct Employee
    {
        public int EmpId;
        public string FirstName;
        public string LastName;

        static Employee()
        {
            Console.Write("First object created");
        }

        public Employee(int empid, string fname, string lname)
        {
            EmpId = empid;
            FirstName = fname;
            LastName = lname;
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}