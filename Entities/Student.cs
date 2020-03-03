using System;

namespace PrivateSchoolPartB_Vlachogiannis
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double? Fees { get; set; }

        public Student() { }
        public Student(int id, string firstName, string lastName, DateTime dateOfBirth, double? fees = 2500)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Fees = fees;
        }

        public void PrintStudent()
        {
            Console.WriteLine($"{Id,-3} {FirstName,-15} {LastName,-20} {DateOfBirth.ToString("dd/MM/yyyy"),-15} {Fees,-5}");
        }
    }
}
