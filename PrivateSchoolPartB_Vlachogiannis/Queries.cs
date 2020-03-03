using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PrivateSchoolPartB_Vlachogiannis
{
    public static class Queries
    {
        //Connection string
        public static string connectionString = Properties.Settings.Default.connectionString;

        //All methods for queries at the database
        public static List<Student> SelectAllStudents()
        {
            List<Student> students = new List<Student>();
            string query = @"Select * from Student";
            using (SqlConnection dbcon = new SqlConnection(connectionString))
            {
                dbcon.Open();
                SqlCommand cmd = new SqlCommand(query, dbcon);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var StudentId = (int)reader[0];
                        var FirstName = (string)reader[1];
                        var LastName = (string)reader[2];
                        var DateOfBirth = (DateTime)reader[3];
                        var Fees = reader[4] == DBNull.Value ? (double?)null : Convert.ToInt64(reader[4]);
                        Student s = new Student(StudentId, FirstName, LastName, DateOfBirth, Fees);
                        students.Add(s);
                    }
                }
            }
            return students;
        }
        public static List<Trainer> SelectAllTrainers()
        {
            List<Trainer> trainers = new List<Trainer>();
            string query = @"Select * from Trainer";
            using (SqlConnection dbcon = new SqlConnection(connectionString))
            {
                dbcon.Open();
                SqlCommand cmd = new SqlCommand(query, dbcon);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var TrainerId = (int)reader[0];
                        var FirstName = (string)reader[1];
                        var LastName = (string)reader[2];
                        var Subject = (string)reader[3];

                        Trainer t = new Trainer(TrainerId, FirstName, LastName, Subject);
                        trainers.Add(t);
                    }
                }
            }
            return trainers;
        }
        public static List<Course> SelectAllCourses()
        {
            List<Course> courses = new List<Course>();
            string query = @"Select * from Course";
            using (SqlConnection dbcon = new SqlConnection(connectionString))
            {
                dbcon.Open();
                SqlCommand cmd = new SqlCommand(query, dbcon);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var CourseId = (int)reader[0];
                        var Title = (string)reader[1];
                        var Stream = (string)reader[2];
                        var Type = (string)reader[3];
                        var StartDate = reader[4] == DBNull.Value ? (DateTime?)null : (DateTime)reader[4];
                        var EndDate = reader[5] == DBNull.Value ? (DateTime?)null : (DateTime)reader[5];


                        Course c = new Course(CourseId, Title, Stream, Type, StartDate, EndDate);
                        courses.Add(c);
                    }
                }
            }
            return courses;
        }
        public static List<Assignment> SelectAllAssignments()
        {
            List<Assignment> assignments = new List<Assignment>();
            string query = @"Select * from Assignment";
            using (SqlConnection dbcon = new SqlConnection(connectionString))
            {
                dbcon.Open();
                SqlCommand cmd = new SqlCommand(query, dbcon);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var AssignmentId = (int)reader[0];
                        var Title = (string)reader[1];
                        var Description = (string)reader[2];
                        var SubDateTime = reader[3] == DBNull.Value ? (DateTime?)null : (DateTime)reader[3];
                        var StartDate = reader[4] == DBNull.Value ? (int?)null : (int)reader[4];
                        var EndDate = reader[5] == DBNull.Value ? (int?)null : (int)reader[5];

                        Assignment a = new Assignment(AssignmentId, Title, Description, SubDateTime, StartDate, EndDate);
                        assignments.Add(a);
                    }
                }
            }
            return assignments;
        }
        public static List<Tuple<string, string, string>> SelectAllStudentsPerCourse()
        {
            var temp = new List<Tuple<string, string, string>>();
            string query = @"SELECT c.Title, s.First_Name, s.Last_Name FROM Student s
                             INNER JOIN Student_Per_Course SPC ON SPC.Student_ID = s.Student_ID
                             INNER JOIN Course c ON SPC.Course_ID = c.Course_ID
                             ORDER BY c.Title;";
            using (SqlConnection dbcon = new SqlConnection(connectionString))
            {
                dbcon.Open();
                SqlCommand cmd = new SqlCommand(query, dbcon);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string title = (string)reader[0];
                        string fname = (string)reader[1];
                        string lname = (string)reader[2];

                        temp.Add(new Tuple<string, string, string>(title, fname, lname));
                    }
                }
            }
            return temp;
        }
        public static List<Tuple<string, string, string>> SelectAllTrainerPerCourse()
        {
            var temp = new List<Tuple<string, string, string>>();
            string query = @"SELECT c.Title, t.First_Name, t.Last_Name FROM Trainer T
                             INNER JOIN Trainer_Per_Course TPC ON TPC.Trainer_ID = T.Trainer_ID
                             INNER JOIN Course c ON c.Course_ID = TPC.Course_ID
                             ORDER BY c.Title;";
            using (SqlConnection dbcon = new SqlConnection(connectionString))
            {
                dbcon.Open();
                SqlCommand cmd = new SqlCommand(query, dbcon);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string title = (string)reader[0];
                        string fname = (string)reader[1];
                        string lname = (string)reader[2];

                        temp.Add(new Tuple<string, string, string>(title, fname, lname));
                    }
                }
            }
            return temp;
        }
        public static List<Tuple<string, string>> SelectAllAssignmentsPerCourse()
        {
            var temp = new List<Tuple<string, string>>();
            string query = @"SELECT c.Title, a.Title FROM Assignment A
                             INNER JOIN Assignment_Per_Course APC ON APC.Assignment_ID = A.Assignment_ID
                             INNER JOIN Course c ON c.Course_ID = APC.Course_ID
                             ORDER BY c.Title;";
            using (SqlConnection dbcon = new SqlConnection(connectionString))
            {
                dbcon.Open();
                SqlCommand cmd = new SqlCommand(query, dbcon);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        string courseTitle = (string)reader[0];
                        string assignmentTitle = (string)reader[1];

                        temp.Add(new Tuple<string, string>(courseTitle, assignmentTitle));
                    }
                }
            }
            return temp;
        }
        public static List<Tuple<string, string, string, string>> SelectAllAssignmentsPerCoursePerStudent()
        {
            var temp = new List<Tuple<string, string, string, string>>();
            string query = @"SELECT c.Title, A.Title, s.First_Name, s.Last_Name FROM Student s
                             INNER JOIN Student_Per_Course SPC ON SPC.Student_ID = s.Student_ID
                             INNER JOIN Course c ON SPC.Course_ID = c.Course_ID
                             INNER JOIN Assignment_Per_Course APC ON APC.Course_ID = c.Course_ID
                             INNER JOIN Assignment A ON A.Assignment_ID = APC.Assignment_ID
                             ORDER BY c.Title, A.Title, First_Name;";
            using (SqlConnection dbcon = new SqlConnection(connectionString))
            {
                dbcon.Open();
                SqlCommand cmd = new SqlCommand(query, dbcon);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string cTitle = (string)reader[0];
                        string aTitle = (string)reader[1];
                        string fname = (string)reader[2];
                        string lname = (string)reader[3];

                        temp.Add(new Tuple<string, string, string, string>(cTitle, aTitle, fname, lname));
                    }
                }
            }
            return temp;
        }
        public static List<Tuple<string, string, int>> SelectAllStudentsWithMoreCourses()
        {
            var temp = new List<Tuple<string, string, int>>();
            string query = @"SELECT s.First_Name, s.Last_Name, COUNT(spc.Student_ID) AS Total_Courses FROM Student s , Student_Per_Course spc
                             WHERE spc.Student_ID = s.Student_ID
                             GROUP BY s.First_Name, s.Last_Name
                             HAVING COUNT(spc.Student_ID)>1;";
            using (SqlConnection dbcon = new SqlConnection(connectionString))
            {
                dbcon.Open();
                SqlCommand cmd = new SqlCommand(query, dbcon);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var fname = (string)reader[0];
                        var lname = (string)reader[1];
                        var totalcourse = (int)reader[2];

                        temp.Add(new Tuple<string, string, int>(fname, lname, totalcourse));
                    }
                }
            }
            return temp;
        }

    }
}

