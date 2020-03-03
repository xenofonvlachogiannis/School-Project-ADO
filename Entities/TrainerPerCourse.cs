using System;

namespace PrivateSchoolPartB_Vlachogiannis
{
    public class TrainerPerCourse
    {
        public int TrainerId { get; set; }
        public int CourseId { get; set; }

        public TrainerPerCourse() { }
        public TrainerPerCourse(int trainerId, int courseId)
        {
            TrainerId = trainerId;
            CourseId = courseId;
        }
    }
}
