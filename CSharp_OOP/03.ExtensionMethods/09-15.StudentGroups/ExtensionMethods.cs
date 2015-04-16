
namespace ExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Student;

    public static class ExtensionMethods
    {
        public static List<Student> GetGroup(this List<Student> students, int group)
        {
            var list = new List<Student>();
            foreach (var student in students)
            {
                if (student.GroupNumber == group)
                {
                    list.Add(student);
                }
            }
            return list;
        }

        public static List<Student> StudentsWithTwoMarks(this List<Student> students)
        {
            var result = new List<Student>();
            foreach (var student in students)
            {
                if(student.Marks.Count == 2 )
                {
                    result.Add(student);
                }
            }
            return result;
        }

    }
}
