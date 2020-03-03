using System;

namespace PrivateSchoolPartB_Vlachogiannis
{
    static class InputsMethods
    {
        //Αll methods for keyboard input
        public static string GiveFirstName()
        {
            Console.Write("Enter first name: ");
            string fname = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(fname))
            {
                Console.WriteLine("You can't give an empty name, try again.");
                fname = Console.ReadLine();
            }
            return fname;
        }
        public static string GiveLastName()
        {
            Console.Write("Enter last name: ");
            string lname = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(lname))
            {
                Console.WriteLine("You can't give an empty lastname, try again.");
                lname = Console.ReadLine();
            }
            return lname;
        }
        public static string GiveTitle()
        {
            Console.Write("Enter Title: ");
            string title = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("You can't give an empty title, try again.");
                title = Console.ReadLine();
            }
            return title;
        }
        public static string GiveDescription()
        {
            Console.Write("Enter description: ");
            string description = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(description))
            {
                Console.WriteLine("You can't give an empty description, try again.");
                description = Console.ReadLine();
            }
            return description;
        }
        public static string GiveSubject()
        {
            Console.Write("Enter subject: ");
            string subject = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(subject))
            {
                Console.WriteLine("You can't give an empty subject, try again.");
                subject = Console.ReadLine();
            }
            return subject;
        }
        public static string GiveStream()
        {
            Console.Write("Enter stream: ");
            string stream = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(stream))
            {
                Console.WriteLine("You can't give an empty stream, try again.");
                stream = Console.ReadLine();
            }
            return stream;
        }
        public static string GiveType()
        {
            Console.Write("Enter type: ");
            string type = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(type))
            {
                Console.WriteLine("You can't give an empty type, try again.");
                type = Console.ReadLine();
            }
            return type;
        }

        public static DateTime? GiveStartDate()
        {
            Console.Write("Give Start Date of Course (y/m/d): ");
            string startDate = Console.ReadLine();
            while ((!string.IsNullOrWhiteSpace(startDate)) && (!DateTime.TryParse(startDate, out DateTime date)))
            {
                Console.WriteLine("Wrong input! Give again start date of course (y/m/d)");
                startDate = Console.ReadLine();
            }

            return string.IsNullOrWhiteSpace(startDate) ? (DateTime?)null : Convert.ToDateTime(startDate);

        }
        public static DateTime? GiveEndDate()
        {
            Console.Write("Give End Date of Course (y/m/d): ");
            string endDate = Console.ReadLine();
            while ((!string.IsNullOrWhiteSpace(endDate)) && (!DateTime.TryParse(endDate, out DateTime date)))
            {
                Console.WriteLine("Wrong input! Give again end date of course (y/m/d)");
                endDate = Console.ReadLine();
            }

            return string.IsNullOrWhiteSpace(endDate) ? (DateTime?)null : Convert.ToDateTime(endDate);
        }
        public static DateTime? GiveSubDate()
        {
            Console.Write("Give submission date (y/m/d): ");
            string subDate = Console.ReadLine();
            while ((!string.IsNullOrWhiteSpace(subDate)) && (!DateTime.TryParse(subDate, out DateTime date)))
            {
                Console.WriteLine("Wrong input! Give again date of submission (y/m/d)");
                subDate = Console.ReadLine();
            }

            return string.IsNullOrWhiteSpace(subDate) ? (DateTime?)null : Convert.ToDateTime(subDate);
        }
        public static DateTime GiveDateOfBirth()
        {
            DateTime date;
            Console.Write("Enter date of birth (y/m/d): ");
            while (!DateTime.TryParse(Console.ReadLine(), out date))
            {
                Console.WriteLine("Wrong input! Give again date of birth (y/m/d)");
            }
            return date;
        }

        public static double? GiveOralMark()
        {

            Console.WriteLine("Give oral mark of Assignment: ");
            string oralMark = Console.ReadLine();
            while ((!string.IsNullOrWhiteSpace(oralMark)) && (!Double.TryParse(oralMark, out double mark)))
            {
                Console.WriteLine("Wrong input! Give again oral mark");
                oralMark = Console.ReadLine();
            }
            return string.IsNullOrWhiteSpace(oralMark) ? (double?)null : Convert.ToDouble(oralMark);
        }
        public static double? GiveTotalMark()
        {

            Console.WriteLine("Give total mark of Assignment: ");
            string totalMark = Console.ReadLine();
            while ((!string.IsNullOrWhiteSpace(totalMark)) && (!Double.TryParse(totalMark, out double mark)))
            {
                Console.WriteLine("Wrong input! Give again total mark");
                totalMark = Console.ReadLine();
            }
            return string.IsNullOrWhiteSpace(totalMark) ? (double?)null : Convert.ToDouble(totalMark);
        }
        public static double? GiveFees()
        {

            Console.WriteLine("Give fees of Student: ");
            string fees = Console.ReadLine();
            double mark = 0;
            while ((!string.IsNullOrWhiteSpace(fees)) && ((!Double.TryParse(fees, out mark)) || (mark<0)))
            {
                Console.WriteLine("Wrong input! Give again fees");
                fees = Console.ReadLine();
            }
            return string.IsNullOrWhiteSpace(fees) ? (double?)null : Convert.ToDouble(fees);
        }

        public static int SelectStudentId()
        {
            Console.WriteLine();
            Console.WriteLine("Select one student Id from the above");
            int select;
            while (!int.TryParse(Console.ReadLine(), out select))
            {
                Console.WriteLine("Wrong input! Give a right student Id");
            }
            return select;
        }
        public static int SelectCourseId()
        {
            Console.WriteLine();
            Console.WriteLine("Select Course Id from the above");
            int select;
            while (!int.TryParse(Console.ReadLine(), out select))
            {
                Console.WriteLine("Wrong input! Give a right course Id");
            }
            return select;
        }
        public static int SelectTrainerId()
        {
            Console.WriteLine();
            Console.WriteLine("Select Trainer Id from the above");
            int select;
            while (!int.TryParse(Console.ReadLine(), out select))
            {
                Console.WriteLine("Wrong input! Give a right trainer Id");
            }
            return select;
        }
        public static int SelectAssignmentId()
        {
            Console.WriteLine();
            Console.WriteLine("Select the assignment Id from the above");
            int select;
            while (!int.TryParse(Console.ReadLine(), out select))
            {
                Console.WriteLine("Wrong input! Give a right assignment Id");
            }
            return select;
        }
    }
}
