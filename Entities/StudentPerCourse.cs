using System;

namespace PrivateSchoolPartB_Vlachogiannis
{
    public class StudentPerCourse
    {
   
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public StudentPerCourse() { }
        public StudentPerCourse(int studentId, int courseId)
        {
            StudentId = studentId;
            CourseId = courseId;
        }

    }
}
