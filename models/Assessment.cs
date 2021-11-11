using System.Collections.Generic;

namespace Student.models
{
    public class Assessment
    {
        public int TotalNumberOfCoursesTaken { get; set; }
        
        public int CalculateNumberOfCoursesTaken(List<Student> students)
        {
            foreach (var student in students)
            {
                TotalNumberOfCoursesTaken += student.NoOfSubjectsTaken;
            }

            return TotalNumberOfCoursesTaken;
        }

        public Dictionary<string, char> AssignGrade(List<Student> students)
        {
            Dictionary<string, char> results = new Dictionary<string, char>();
            foreach (var student in students)
            {
                foreach (var course in student.Courses)
                {
                    if (course.Value > 50)
                    {
                        var grade = 'p';
                        results.Add(course.Key, grade);
                    }
                    else
                    {
                        var grade = 'f';
                        results.Add(course.Key, grade);
                    }
                }
            }

            return results;
        }
    }
}