using System;

namespace PrivateSchoolPartB_Vlachogiannis
{
     static class FrontEnd
    {
        //All methods for printing data
        public static void PrintStudents()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"                    --STUDENTS INFO--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine($"ID  First Name      Last Name           Date of Birth    Fees");
            Console.WriteLine("---------------------------------------------------------------");
            foreach (var item in Queries.SelectAllStudents())
            {
                item.PrintStudent();
            }
        }
        public static void PrintTrainers()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"        --TRAINERS INFO--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"--------------------------------------------");
            Console.WriteLine($"ID  First Name      Last Name       Subject");
            Console.WriteLine($"--------------------------------------------");
            foreach (var item in Queries.SelectAllTrainers())
            {
                item.PrintTrainer();
            }
        }
        public static void PrintCourses()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"                        --COURSES INFO--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"-------------------------------------------------------------------------");
            Console.WriteLine($"ID    Title          Stream         Type       Start Date      End Date");
            Console.WriteLine($"-------------------------------------------------------------------------");
            foreach (var item in Queries.SelectAllCourses())
            {
                item.PrintCourse();
            }
        }
        public static void PrintAssignments()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"                                    --ASSIGNMENTS INFO--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"-------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"ID          Title                      Description                Sub Date    Oral Mark   Total Mark");
            Console.WriteLine($"------------------------------------------------------------------------------------------------------");
            foreach (var item in Queries.SelectAllAssignments())
            {
                item.PrintAssignment();
            }
        }
        public static void PrintStudentPerCourse()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"     --STUDENTS PER COURSE--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Course   First Name      Last Name  ");
            Console.WriteLine("----------------------------------------");
            foreach (var item in Queries.SelectAllStudentsPerCourse())
            {
                Console.WriteLine($"{item.Item1,-9} {item.Item2,-15} {item.Item3,-15}");
            }
        }
        public static void PrintTrainerPerCourse()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"     --TRAINER PER COURSE--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Course     First Name      Last Name  ");
            Console.WriteLine("----------------------------------------");
            foreach (var item in Queries.SelectAllTrainerPerCourse())
            {
                Console.WriteLine($"{item.Item1,-9} {item.Item2,-15} {item.Item3,-15}");
            }
        }
        public static void PrintAssignmentPerCourse()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"     --ASSIGNMENT PER COURSE--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Course     Assignment");
            Console.WriteLine("----------------------------------");
            foreach (var item in Queries.SelectAllAssignmentsPerCourse())
            {
                Console.WriteLine($"{item.Item1,-9} {item.Item2,-15}");
            }
        }
        public static void PrintAssignmentPerStudentPerCourse()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"     --ALL ASSIGNMENT PER STUDENT PER COURSE--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine($"Course     Assignment                     First Name      Last Name");
            Console.WriteLine("-----------------------------------------------------------------------");
            foreach (var item in Queries.SelectAllAssignmentsPerCoursePerStudent())
            {
                Console.WriteLine($"{item.Item1,-10} {item.Item2,-30} {item.Item3,-15} {item.Item4,-30}");
            }
        }
        public static void PrintStudentsWithMoreCourses()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"     --STUDENTS WITH MORE COURSES--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"First Name      Last Name         Courses");
            Console.WriteLine("------------------------------------------");
            foreach (var item in Queries.SelectAllStudentsWithMoreCourses())
            {
                Console.WriteLine($"{item.Item1,-15} {item.Item2,-20} {item.Item3,-15}");
            }
            Console.WriteLine();
        }
        public static void RunAllPrintMethods()
        {
            PrintStudents();
            PrintTrainers();
            PrintAssignments();
            PrintCourses();
            PrintStudentPerCourse();
            PrintTrainerPerCourse();
            PrintAssignmentPerCourse();
            PrintAssignmentPerStudentPerCourse();
            PrintStudentsWithMoreCourses();
        }
    }
}
