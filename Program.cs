using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSortiranje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] studentArray = {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
            new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
            new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
        };



            var result = from s in studentArray
                         select s.Age;
            var orderDesc =  from s in studentArray
                             orderby s.Age descending
                             select result;

            foreach (Student result2 in result)
            {
                Console.WriteLine(result);
            }
        }
        class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }
        }
    }
}
