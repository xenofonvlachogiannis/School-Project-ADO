using System;

namespace PrivateSchoolPartB_Vlachogiannis
{
    public class AssignmentPerStudentPerCourse
    {
        public int CourseId { get; set; }
        public int AssignemntId { get; set; }
        public int StudentId { get; set; }

        public AssignmentPerStudentPerCourse() { }
        public AssignmentPerStudentPerCourse(int courseId, int assignemntId, int studentId)
        {
            CourseId = courseId;
            AssignemntId = assignemntId;
            StudentId = studentId;
        }

    }
}
