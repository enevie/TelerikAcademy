namespace _01.StudentClass
{
    using System;
    public class Student : ICloneable, IComparable<Student>
    {

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public int SSN { get; set; }

        public string PermanentAdress { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public int Course { get; set; }

        public Faculties Faculty { get; set; }

        public Specialties Speciality { get; set; }

        public Universities University { get; set; }


        public override bool Equals(Object param)
        {
            Student student = param as Student;
            if(student == null)
            {
                return false;
            }
            if(!object.Equals(this.FirstName,student.FirstName))
            {
                return false;
            }
            if(!object.Equals(this.SSN,student.SSN))
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} studying {3} in {4} with GSM number: {5}"
                , this.FirstName, this.MiddleName, this.LastName, this.Speciality, this.University, this.MobilePhone);
        }

        public override int GetHashCode()
        {
           return this.SSN.GetHashCode() ^ this.Course.GetHashCode();
        }

        public static bool operator == (Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator != (Student student1, Student student2)
        {
            return !(Student.Equals(student1,student2));
        }

        public object Clone()
        {
            var studentCloned = new Student();
            this.LastName = studentCloned.FirstName;
            this.Faculty = studentCloned.Faculty;

            return studentCloned;
        }



        public int CompareTo(Student student)
        {
            if(this.SSN != student.SSN)
            {
                return this.SSN - student.SSN;
            }
            return 0;
        }
    }
}
