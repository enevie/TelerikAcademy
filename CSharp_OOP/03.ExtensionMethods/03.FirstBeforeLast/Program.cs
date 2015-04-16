namespace _03.FirstBeforeLast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using StudentCreation;

    public class Program
    {
        static void Main()
        {

            Student[] studentsList =
            {
                new Student("Panayot", "Enev",15),
                new Student("Bvan", "Penkov",23),
                new Student("Alatan", "Zmeiov",32),
                new Student("Ilian", "Borisov",19)
            };

            var sortedStudent = FirstBeforeLast(studentsList);

            foreach (var student in sortedStudent)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            Console.WriteLine("in Age range: ");
            var ageStudent = AgeRange(studentsList);

            foreach (var student in ageStudent)
            {
                Console.WriteLine(student);
            }

            var sortedByAsc =
                from student in studentsList
                orderby student.FirstName descending, student.LastName descending
                select student;
            Console.WriteLine();

            Console.WriteLine("Students order by descending names");
            foreach (var student in sortedByAsc)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
     
        }

        private static IEnumerable<Student> FirstBeforeLast(Student[] students)
        {
            IEnumerable<Student> result =
            from student in students
            where student.FirstName.CompareTo(student.LastName) < 0
            select student;

            return result;
        }

        private static IEnumerable<Student> AgeRange(Student[] students)
        {
                IEnumerable<Student> ageStudent =
                from student in students
                where student.Age > 18 && student.Age < 24
                select student;

            return ageStudent;
        }
    }
}


