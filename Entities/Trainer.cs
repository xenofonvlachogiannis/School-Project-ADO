using System;

namespace PrivateSchoolPartB_Vlachogiannis
{
    public class Trainer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }

        public Trainer() { }
        public Trainer(int id, string firstName, string lastname, string subject)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastname;
            Subject = subject;
        }

        public void PrintTrainer()
        {
            Console.WriteLine($"{Id,-3} {FirstName,-15}  {LastName,-15}  {Subject,-10}");
        }
    }
}
