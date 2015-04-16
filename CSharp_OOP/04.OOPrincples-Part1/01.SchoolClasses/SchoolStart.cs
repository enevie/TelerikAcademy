namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using StudentsAndWorkers;

    class SchoolStart
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student(3.52, "Ivaylo", "Petrov"),
                new Student(4.25, "Pesho", "Peshov"),
                new Student(5.83, "Aivan", "Ivanov"),
                new Student(4, "Kircho", "Kirev"),
                new Student(3.89, "Stoyan", "Petrov"),
                new Student(6, "Emilia", "Peshova"),
                new Student(3, "Kunio", "Kunev"),
                new Student(4.73, "Evgeni", "Minchev"),
                new Student(5.52, "Dragan", "Draganov"),
                new Student(3.28, "Mamut", "Peshov")
            };

            var sortedByGrade = from student in students
                                orderby student.Grade ascending
                                select student;

            //foreach (var student in sortedByGrade)
            //{
            //    Console.WriteLine(student);
            //}
            var workers = new List<Worker>()
            {
                new Worker(530,10, "Kamilcho", "Kamilov"),
                new Worker(250,3, "Ivan", "Ivanov"),
                new Worker(440,5, "Drajo", "Kamilov"),
                new Worker(1000,10, "Penio", "Penkov"),
                new Worker(320,4, "Samurcho", "Kenchev"),
                new Worker(220,2, "Nasakoto", "Qkata"),
                new Worker(885,7, "Predpoloji", "Dokolenkov"),
                new Worker(100,1, "Samuil", "Ivanov"),
                new Worker(760,5, "Pepa", "Pupkova"),
                new Worker(490,3, "Iliana", "Kuritanova"),
            };


            var sortedBySalery = from worker in workers
                                 orderby worker.HourSalery(worker.WeekSalery) descending
                                 select worker;

            Console.WriteLine(new string('-', 50));

            //foreach (var worker in sortedBySalery)
            //{
            //    Console.WriteLine(worker);
            //}
            Console.WriteLine(new string('-', 50));

            var mergedListHuman = new List<Human>();

            foreach (var student in students)
            {
                mergedListHuman.Add(student);
            }
            foreach (var worker in workers)
            {
                mergedListHuman.Add(worker);
            }

            var humansByName = from human in mergedListHuman
                               orderby human.FirstName ascending, human.LastName ascending
                               select human;

            foreach (var human in humansByName)
            {
                Console.WriteLine(human);
            }

        }
    }
}
