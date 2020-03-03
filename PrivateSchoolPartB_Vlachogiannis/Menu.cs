using System;

namespace PrivateSchoolPartB_Vlachogiannis
{
    static class Menu
    {
        public static void RunMenu()
        {
            string choice;
            do
            {
                Menu.MenuStart();
                Console.Write("Choose one of the above: ");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    Menu.MenuInsert();
                }
                else if (choice == "2")
                {
                    FrontEnd.RunAllPrintMethods();
                }
                else if (choice == "3")
                {
                    Environment.Exit(0);
                }
                else if (choice != "3")
                {
                    Console.WriteLine("-- Wrong input --");
                    Console.WriteLine();
                }

            } while (choice != "3");
        }
        static void MenuStart()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to Private School Manager");
            Console.WriteLine();
            Console.WriteLine("1.   For Input");
            Console.WriteLine("2.   For Synthetic Data");
            Console.WriteLine("3.   Exit");
            Console.WriteLine();
        }
        static void MenuSubMenu()
        {
            Console.Clear();
            Console.WriteLine("1.   Input Course");
            Console.WriteLine("2.   Input Student");
            Console.WriteLine("3.   Input Trainer");
            Console.WriteLine("4.   Input Assignment");
            Console.WriteLine("5.   Input Student Per Course");
            Console.WriteLine("6.   Input Trainer Per Course");
            Console.WriteLine("7.   Input Assignment Per Course");
            Console.WriteLine("8.   Go Back");
            Console.WriteLine();
            Console.Write("Choose one of the above: ");
            Console.WriteLine();
        }
        static void MenuInsert()
        {
            int temp = 0;
            Menu.MenuSubMenu();
            while (!Int32.TryParse(Console.ReadLine(), out temp))
            {
                Console.WriteLine("-- Wrong input --");
            }

            switch (temp)
            {
                case 1:
                    Inserts.InsertCourse(Inserts.AddCourse());
                    break;
                case 2:
                    Inserts.InsertStudent(Inserts.AddStudent());
                    break;
                case 3:
                    Inserts.InsertTrainer(Inserts.AddTrainer());
                    break;
                case 4:
                    Inserts.InsertAssignment(Inserts.AddAssignment());
                    break;
                case 5:
                    Inserts.InsertStudentPerCourse(Inserts.AddStudentPerCourse());
                    break;
                case 6:
                    Inserts.InsertTrainerPerCourse(Inserts.AddTrainertPerCourse());
                    break;
                case 7:
                    Inserts.InsertAssignmentPerStudentPerCourse(Inserts.AddAssignmentPerCourse());
                    break;
                case 8:
                    RunMenu();
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
        }
    }
}

