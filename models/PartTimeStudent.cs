using Student.interfaces;

namespace Student.models
{
    public class PartTimeStudent: Student, IRemotable
    {
        public void StudyRemotely() { }
    }
}