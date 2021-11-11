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

        public List<Student> ComputeGrade(List<Student> students)
        {
            Dictionary<string, char> results = new Dictionary<string, char>();
            List<Student> newStudentsList = new List<Student>();
            char grade;
            
            foreach (var student in students)
            {
                foreach (var course in student.Courses)
                {
                    if (course.Value > 50)
                    {
                        grade = 'p';
                        results.Add(course.Key, grade);
                    }
                    else
                    {
                        grade = 'f';
                        results.Add(course.Key, grade);
                    }
                }
                newStudentsList.Add(student);
            }

            return newStudentsList;
        }
    }
}