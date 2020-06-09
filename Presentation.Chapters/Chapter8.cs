using System;
using Presentation.Chapters.Abstraction;
using Presentation.Chapters.Structs;

namespace Presentation.Chapters
{
    internal class Chapter8 : IChapter
    {
        public void Execute()
        {
            Employee emp1 = new Employee(10, "Bill", "Gates");

            Console.WriteLine(emp1.GetFullName());

            Employee emp2 = new Employee(10, "Steve", "Jobs");
            Console.WriteLine(emp2.GetFullName());

            Employee emp3;
            emp3.EmpId = 1;

            Console.WriteLine(emp3.EmpId);

            //Compile Error occurrs
            //Console.WriteLine(emp3.GetFullName());

            emp3.FirstName = "Mahdi";
            emp3.LastName = "Malverdi";
            Console.WriteLine(emp3.GetFullName());
        }
    }
}