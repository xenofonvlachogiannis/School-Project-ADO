using System;

namespace PrivateSchoolPartB_Vlachogiannis
{
    public class Assignment
    {
        public int AssignmentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? SubDateTime { get; set; }
        public double? OralMark { get; set; }
        public double? TotalMark { get; set; }

        public Assignment() { }
        public Assignment(int assignmentId, string title, string description, DateTime? subDateTime, double? oralMark, double? totalMark)
        {
            AssignmentId = assignmentId;
            Title = title;
            Description = description;
            SubDateTime = subDateTime;
            OralMark = oralMark;
            TotalMark = totalMark;
        }

        public void PrintAssignment()
        {
            Console.WriteLine($"{AssignmentId,-3} {Title,-33} {Description,-25}  {SubDateTime?.ToString("dd/MM/yyyy"),-15}  {OralMark,-10}  {TotalMark,-10}");
        }
    }
}
