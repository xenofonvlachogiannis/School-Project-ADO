using System;

namespace PrivateSchoolPartB_Vlachogiannis
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Course() { }
        public Course(int courseId, string title, string stream, string type, DateTime? startDate, DateTime? endDate)
        {
            CourseId = courseId;
            Title = title;
            Stream = stream;
            Type = type;
            StartDate = startDate;
            EndDate = endDate;
        }

        public void PrintCourse()
        {
            Console.WriteLine($"{CourseId,-3} {Title,-15} {Stream,-15} {Type,-10} {StartDate?.ToString("dd/MM/yyyy"),-15} {EndDate?.ToString("dd/MM/yyyy"),-15}");
        }
    }
}
