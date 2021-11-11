using System.Collections.Generic;

namespace Student.models
{
    public abstract class Student
    {
        public string Name { get; set; }
        public int NoOfSubjectsTaken { get; set; }
        public Dictionary<string, int> Courses { get; set; }
        public string Address { get; set; }


        public virtual void AttendLecture() { }
        
        public virtual void EnrolToCourse() { }
    }
}