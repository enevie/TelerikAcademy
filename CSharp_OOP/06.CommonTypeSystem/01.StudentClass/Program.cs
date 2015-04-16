using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {

            var student = new Student();
            student.University = Universities.NBU;
            student.PermanentAdress = "Sofia";
            student.SSN = 2335021;
            student.Course = 4;
            student.Faculty = Faculties.Informatics;
            student.Speciality = Specialties.SoftwareEnginner;
            student.FirstName = "Pesho";
            student.MobilePhone = "0887239931";

            Console.WriteLine(student.ToString());

            Console.WriteLine(student.GetHashCode());


            var student2 = new Student();
            student2.FirstName = "Pesho1";
            student2.SSN = 2335021;

            bool test = student == student2;

            Console.WriteLine(Student.Equals(student, student2));
            Console.WriteLine(test);

            var student3 = student2.Clone();

            Console.WriteLine(student.ToString());

            Console.WriteLine(student.CompareTo(student2));


            var person = new Person("Iofcho",26);
            Console.WriteLine(person.ToString());
        }
    }
}
