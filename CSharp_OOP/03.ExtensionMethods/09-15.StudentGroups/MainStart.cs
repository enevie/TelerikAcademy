namespace StudentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Student;
    using ExtensionMethods;

    public class MainStart
    {
        public static void Main()
        {
            var students = new List<Student>
            {
                new Student("Jony", "Kalpakof", "2156606", new List<int>{3,6}, 1),
                new Student("Ivancho","Ivanov","3322111",new List<int>{6,6,6},2),
                new Student("Apostol","Petkov","3220206", new List<int>{2,4},2),
                new Student("Dragancho","Apostolov","1150305", new List<int>{5,2,6},3),
            };

            students[0].Email = "jonybravo@abv.bg";
            students[1].Email = "ivancho@gmail.com";
            students[2].Email = "petkov@abv.bg";
            students[3].Email = "nz@gbg.bg";

            students[0].Telephone = "02/533-253";
            students[1].Telephone = "056/27-31-15";
            students[2].Telephone = "02/222-333";
            students[3].Telephone = "062/888-123";



            var secondGroupStudents = from student in students
                                      where student.GroupNumber == 2
                                      select student;

            var orderedByName = from student in secondGroupStudents
                                orderby student.FirstName ascending
                                select student;


            //foreach (var stu in orderedByName)
            //{
            //    Console.WriteLine(stu);
            //}

            var test = students.GetGroup(2);

            //foreach (var stu in test)
            //{
            //    Console.WriteLine(stu);
            //}

            var abvMail = from student in students
                          where student.Email.Contains("abv.bg")
                          select student;

            //foreach (var student in abvMail)
            //{
            //    Console.WriteLine(student);
            //}

            var stringMail = Student.EmailABV(students);

            //foreach (var item in stringMail)
            //{
            //    Console.WriteLine(item);
            //}

            var byPhoneSofia = from student in students
                               where student.Telephone.Contains("02/")
                               select student;


            //foreach (var student in byPhoneSofia)
            //{
            //    Console.WriteLine(student);
            //}

            var studentWithSix = from student in students
                                 where student.Marks.Contains(6)
                                 select new
                                 {
                                     fullName = student.FirstName + " " + student.LastName,
                                     marks = string.Join(" ,", student.Marks)

                                 };


            //foreach (var student in studentWithSix)
            //{
            //    Console.WriteLine(student);
            //}

            var studentsWithTwoMarks = students.StudentsWithTwoMarks();

            //foreach (var student in studentsWithTwoMarks)
            //{
            //    Console.WriteLine(student);
            //}


            var marksList = from student in students
                            where student.FacultyNumber.Substring(5) == "06"
                            select student.Marks;


            foreach (var mark in marksList)
            {
                Console.WriteLine(string.Join(", ", mark));
            }
        }
    }
}
