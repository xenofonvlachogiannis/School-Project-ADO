using System;
using System.Data.SqlClient;

namespace PrivateSchoolPartB_Vlachogiannis
{
    public static class Inserts
    {
        //Methods to create a new object for insert to database
        public static Student AddStudent()
        {
            Student s = new Student();
            s.FirstName = InputsMethods.GiveFirstName();
            s.LastName = InputsMethods.GiveLastName();
            s.DateOfBirth = InputsMethods.GiveDateOfBirth();
            s.Fees = InputsMethods.GiveFees();
            return s;
        }
        public static Course AddCourse()
        {
            Course c = new Course();
            c.Title = InputsMethods.GiveTitle();
            c.Stream = InputsMethods.GiveStream();
            c.Type = InputsMethods.GiveType();
            c.StartDate = InputsMethods.GiveStartDate();
            c.EndDate = InputsMethods.GiveEndDate();
            return c;
        }
        public static Trainer AddTrainer()
        {
            Trainer t = new Trainer();
            t.FirstName = InputsMethods.GiveFirstName();
            t.LastName = InputsMethods.GiveLastName();
            t.Subject = InputsMethods.GiveSubject();
            return t;
        }
        public static Assignment AddAssignment()
        {
            Assignment a = new Assignment();
            a.Title = InputsMethods.GiveTitle();
            a.Description = InputsMethods.GiveDescription();
            a.SubDateTime = InputsMethods.GiveSubDate();
            a.OralMark = InputsMethods.GiveOralMark();
            a.TotalMark = InputsMethods.GiveTotalMark();
            return a;
        }
        public static StudentPerCourse AddStudentPerCourse()
        {
            StudentPerCourse spc = new StudentPerCourse();
            FrontEnd.PrintStudents();
            spc.StudentId = InputsMethods.SelectStudentId();
            FrontEnd.PrintCourses();
            spc.CourseId = InputsMethods.SelectCourseId();
            return spc;
        }
        public static TrainerPerCourse AddTrainertPerCourse()
        {
            TrainerPerCourse tpc = new TrainerPerCourse();
            FrontEnd.PrintTrainers();
            tpc.TrainerId = InputsMethods.SelectTrainerId();
            FrontEnd.PrintCourses();
            tpc.CourseId = InputsMethods.SelectCourseId();
            return tpc;
        }
        public static AssignmentPerStudentPerCourse AddAssignmentPerCourse()
        {
            AssignmentPerStudentPerCourse apc = new AssignmentPerStudentPerCourse();
            FrontEnd.PrintAssignments();
            apc.AssignemntId = InputsMethods.SelectAssignmentId();
            FrontEnd.PrintCourses();
            apc.CourseId = InputsMethods.SelectCourseId();
            FrontEnd.PrintStudents();
            apc.StudentId = InputsMethods.SelectStudentId();
            return apc;
        }

        //Methods for Insert an element to the database
        public static void InsertStudent(Student s)
        {
            var connectionString = Properties.Settings.Default.connectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Student VALUES(@FirstName, @LastName, @Date, @Fees)";
                SqlCommand cmd = new SqlCommand(query, con);

                //Pass values to Parameters
                cmd.Parameters.AddWithValue("@FirstName", s.FirstName);
                cmd.Parameters.AddWithValue("@LastName", s.LastName);
                cmd.Parameters.AddWithValue("@Date", s.DateOfBirth.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Fees", s.Fees ?? (object)DBNull.Value);


                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Records Inserted Successfully");
                    Menu.RunMenu();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error Generated. Details: " + e.ToString());
                }
                finally
                {
                    con.Close();
                    Console.ReadKey();
                }
            }

        }
        public static void InsertCourse(Course c)
        {
            var connectionString = Properties.Settings.Default.connectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Course VALUES(@Title, @Stream, @Type, @StartDate, @EndDate)";
                SqlCommand cmd = new SqlCommand(query, con);

                //Pass values to Parameters
                cmd.Parameters.AddWithValue("@Title", c.Title);
                cmd.Parameters.AddWithValue("@Stream", c.Stream);
                cmd.Parameters.AddWithValue("@Type", c.Type);
                cmd.Parameters.AddWithValue("@StartDate", c.StartDate?.ToString("yyyy-MM-dd") ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@EndDate", c.EndDate?.ToString("yyyy-MM-dd") ?? (object)DBNull.Value);


                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Records Inserted Successfully");
                    Menu.RunMenu();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error Generated. Details: " + e.ToString());
                }
                finally
                {
                    con.Close();
                    Console.ReadKey();
                }
            }

        }
        public static void InsertTrainer(Trainer t)
        {
            var connectionString = Properties.Settings.Default.connectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Trainer VALUES(@FirstName, @LastName, @Subject)";
                SqlCommand cmd = new SqlCommand(query, con);

                //Pass values to Parameters
                cmd.Parameters.AddWithValue("@FirstName", t.FirstName);
                cmd.Parameters.AddWithValue("@LastName", t.LastName);
                cmd.Parameters.AddWithValue("@Subject", t.Subject);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Records Inserted Successfully");
                    Menu.RunMenu();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error Generated. Details: " + e.ToString());
                }
                finally
                {
                    con.Close();
                    Console.ReadKey();
                }
            }
        }
        public static void InsertAssignment(Assignment a)
        {
            var connectionString = Properties.Settings.Default.connectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Assignment VALUES(@Title, @Description, @SubDateTime, @OralMark, @TotalMark)";
                SqlCommand cmd = new SqlCommand(query, con);

                //Pass values to Parameters
                cmd.Parameters.AddWithValue("@Title", a.Title);
                cmd.Parameters.AddWithValue("@Description", a.Description);
                cmd.Parameters.AddWithValue("@SubDateTime", a.SubDateTime?.ToString("yyyy-MM-dd") ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@OralMark", a.OralMark ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@TotalMark", a.TotalMark ?? (object)DBNull.Value);


                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Records Inserted Successfully");
                    Menu.RunMenu();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error Generated. Details: " + e.ToString());
                }
                finally
                {
                    con.Close();
                    Console.ReadKey();
                }
            }

        }
        public static void InsertStudentPerCourse(StudentPerCourse spc)
        {
            var connectionString = Properties.Settings.Default.connectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Student_Per_Course VALUES(@StudentId, @CourseId)";
                SqlCommand cmd = new SqlCommand(query, con);

                //Pass values to Parameters
                cmd.Parameters.AddWithValue("@StudentId", spc.StudentId);
                cmd.Parameters.AddWithValue("@CourseId", spc.CourseId);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Records Inserted Successfully");
                    Menu.RunMenu();
                }
                catch (SqlException e) when (e.Number == 2627) //Exception this relationship already exists
                {
                    Console.WriteLine("\n Wrong\n The Id already exists try again");
                    Inserts.InsertStudentPerCourse(Inserts.AddStudentPerCourse());
                }
                catch (SqlException e) when (e.Number == 547) //Exception the id doesn't exist
                {
                    Console.WriteLine("\n Wrong\n The Id does not exist try again");
                    Inserts.InsertStudentPerCourse(Inserts.AddStudentPerCourse());
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error Generated. Details: " + e.ToString());
                }
                finally
                {
                    con.Close();
                    Console.ReadKey();
                }
            }
        }
        public static void InsertTrainerPerCourse(TrainerPerCourse tpc)
        {
            var connectionString = Properties.Settings.Default.connectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Trainer_Per_Course VALUES(@TrainerId, @CourseId)";
                SqlCommand cmd = new SqlCommand(query, con);

                //Pass values to Parameters
                cmd.Parameters.AddWithValue("@TrainerId", tpc.TrainerId);
                cmd.Parameters.AddWithValue("@CourseId", tpc.CourseId);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Records Inserted Successfully");
                    Menu.RunMenu();
                }
                catch (SqlException e) when (e.Number == 2627) //Exception this relationship already exists
                {
                    Console.WriteLine("\n Wrong\n The Id already exists try again");
                    Inserts.InsertTrainerPerCourse(Inserts.AddTrainertPerCourse());
                }
                catch (SqlException e) when (e.Number == 547) //Exception the id doesn't exist
                {
                    Console.WriteLine("\n Wrong\n The Id does not exist try again");
                    Inserts.InsertStudentPerCourse(Inserts.AddStudentPerCourse());
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error Generated. Details: " + e.ToString());
                }
                finally
                {
                    con.Close();
                    Console.ReadKey();
                }
            }
        }
        public static void InsertAssignmentPerStudentPerCourse(AssignmentPerStudentPerCourse apc)
        {
            var connectionString = Properties.Settings.Default.connectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Assignment_Per_Course VALUES(@CourseId, @AssignmentId)INSERT INTO Student_Per_Course VALUES(@StudentId,@CourseId)";
                SqlCommand cmd = new SqlCommand(query, con);
                //Pass values to Parameters
                cmd.Parameters.AddWithValue("@CourseId", apc.CourseId);
                cmd.Parameters.AddWithValue("@AssignmentId", apc.AssignemntId);
                cmd.Parameters.AddWithValue("@StudentId", apc.StudentId);


                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Records Inserted Successfully");
                    Menu.RunMenu();
                }
                catch (SqlException e) when (e.Number == 2627) //Exception this relationship already exists
                {
                    Console.WriteLine("\n Wrong\n The combination already exists try again");
                    Inserts.InsertAssignmentPerStudentPerCourse(Inserts.AddAssignmentPerCourse());
                }
                catch (SqlException e) when (e.Number == 547) //Exception the id doesn't exist
                {
                    Console.WriteLine("\n Wrong\n The Id does not exist try again");
                    Inserts.InsertStudentPerCourse(Inserts.AddStudentPerCourse());
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error Generated. Details: " + e.ToString());
                }
                finally
                {
                    con.Close();
                    Console.ReadKey();
                }
            }
        }

    }
}
