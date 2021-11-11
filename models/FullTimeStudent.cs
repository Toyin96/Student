using Student.interfaces;

namespace Student.models
{
    public class FullTimeStudent: Student, IAssessable
    {
        public double TakeAccessment(string course)
        {
            return 100d;
        }
    }
}