using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student;


namespace _18.GroupedByGroupNumber
{
    class Program : Student.Student
    {
        static void Main()
        {

            var students = new List<Student.Student>
            {
                new Student.Student("Test", "Testov", "0553253", new List<int> { 5, 3, 2 }, 01),
                new Student.Student("Ivanko","Ivankov","3333333",new List<int>(),03),
                new Student.Student("Evlogi","Petkov","2222222",new List<int>(),01),
                new Student.Student("Panayot","Rumenov","2222222",new List<int>(),02)
            };


            var extractStudentsFromGroup = from student in students
                                           group student by student.GroupNumber
                                               into groups
                                               select new
                                                   {
                                                       Group = groups.Key,
                                                       Students = groups.ToList()
                                                   };


            foreach (var grouped in extractStudentsFromGroup)
            {
                Console.WriteLine("\nGroup: {0} Students:\n---------------------\n{1}", grouped.Group,
                    string.Join("\r\n\r\n", grouped.Students));
            }
        }
    }
}
