namespace Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string facultyNumber;
        private string telephone;
        private string email;
        private List<int> marks;
        private int groupNumber;

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value.Length < 3 || value.Length > 10)
                {
                    throw new ArgumentException("The name must be between 3 and 10 chars");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value.Length < 3 || value.Length > 10)
                {
                    throw new ArgumentException("The name must be between 3 and 10 chars");
                }
                this.lastName = value;
            }
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.Length != 7)
                {
                    throw new ArgumentException("The faculty number must be 6 digits");
                }
                this.facultyNumber = value;
            }
        }

        public string Telephone { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public Student(string firstName, string lastName, string facultyNumber, List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyNumber = facultyNumber;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
            this.Email = null;
            this.Telephone = null;
        }

        public Student()
        {

        }

        public override string ToString()
        {
            return string.Format("{0} {1} , faculty Number{2} in group {3} \n with {4} grades and mail {5} \n telephone: {6}", this.FirstName, this.LastName, this.FacultyNumber,this.GroupNumber, string.Join(", ",this.Marks),this.Email, this.Telephone);
        }

        public static List<Student> EmailABV(List<Student> students)
        {
            var result = new List<Student>();
            string mailAbv = "abv.bg";
            int startIndex = 0;
            string currentMail = string.Empty;

            foreach (var student in students)
            {
                startIndex =student.Email.IndexOf('@');
                currentMail = student.Email.Substring(startIndex+1);
                if(currentMail == mailAbv)
                {
                    result.Add(student);
                }
            }
            return result;
        }
    }
}

