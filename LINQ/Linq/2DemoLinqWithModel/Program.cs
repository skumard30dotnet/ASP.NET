using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DemoLinqWithModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentArray = {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
            new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
            new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
            };


            foreach (Student stud in studentArray)
            {
                if (stud.StudentName.Equals("Chris") && stud.Age.Equals(17))
                {

                }
            }

            var linqobj = from stud in studentArray
                          where stud.StudentName.Equals("Chris") && stud.Age.Equals(17)
                          select stud;

            // Use LINQ to find teenager students
            Student[] teenAgerStudents = studentArray.Where(s => s.StudentName.Contains("o") && s.Age < 20).ToArray();

            // Use LINQ to find first student whose name is Bill 
            Student bill = studentArray.Where(s => s.StudentName == "Bill").FirstOrDefault();

            // Use LINQ to find student whose StudentID is 5
            List<Student> student5 = studentArray.Where(s => s.StudentID == 5).ToList();


            var thenByResult = studentArray.OrderBy(s => s.StudentName).ThenBy(s => s.Age);

            var thenByDescResult = studentArray.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);

            var groupedResult = studentArray.GroupBy(s => s.Age);
        }
    }
}
