using Microsoft.Data.SqlClient;
using SchoolRegisterLabb3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegisterLabb3
{
    internal class Retrieve
    {
        public static void RetrieveAggregateGradesOnCourse()
        {
            Console.Clear();
            SchoolRegisterContext dbcontext = new SchoolRegisterContext();
            var result = from g in dbcontext.Grades
                         join e in dbcontext.Enrollments on g.GradeId equals e.FkgradeId
                         join s in dbcontext.Students on e.FkstudentId equals s.StudentId
                         join c in dbcontext.Courses on e.FkcourseId equals c.CourseId
                         group g by c.CourseName into grouped
                         select new
                         {
                             CourseName = grouped.Key,
                             AvgGrade = grouped.Average(x => x.GradeByNr),
                             TopGrade = grouped.Max(x => x.GradeByNr),
                             LowestGrade = grouped.Min(x => x.GradeByNr)
                         };
            foreach (var item in result)
            {
                Console.WriteLine($"Course: {item.CourseName}, Average Grade:{item.AvgGrade}, Top Grade:{item.TopGrade}, Lowest Grade:{item.LowestGrade}");
            }
            Console.ReadKey();
        }
        public static void RetrieveGrades()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Database=SchoolRegister;Trusted_Connection=True;MultipleActiveResultSets=true";
            Console.Clear();
            using(SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT FirstName,LastName, CourseName, Grade FROM Grade " +
                        "JOIN Enrollment ON Grade.GradeID = Enrollment.FKGradeID " +
                        "JOIN Students ON Students.StudentID = Enrollment.FKStudentID " +
                        "JOIN Course ON Course.CourseID = Enrollment.FKCourseID WHERE SetDate > DATEADD(month, -1, GETDATE())", sqlConnection);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["FirstName"] + "-" + reader["LastName"]+ "   "+reader["CourseName"] + " - " + reader["Grade"] );
                            
                        }
                        Console.ReadKey();
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Something went wrong");
                    Console.ReadKey();
                }
            }

        }

        public static void RetrieveEmployees()
        {

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Database=SchoolRegister;Trusted_Connection=True;MultipleActiveResultSets=true";
            Console.Clear();
            Console.WriteLine("***** All Employees *****");
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("SELECT EmpFirstName, EmpLastName FROM Employees",sqlConnection);
                    using(SqlDataReader read = command.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            Console.WriteLine(read["EmpFirstName"]+ "-" + read["EmpLastName"]);
                        }
                        Console.ReadKey();
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("Something went wrong");
                }
            }

        }

        public static void RetrieveTeachers()
        {

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Database=SchoolRegister;Trusted_Connection=True;MultipleActiveResultSets=true";
            Console.Clear();
            Console.WriteLine("***** Teachers *****");
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("SELECT EmpFirstName, EmpLastName FROM Employees WHERE FKRoleID=1", sqlConnection);
                    using (SqlDataReader read = command.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            Console.WriteLine(read["EmpFirstName"] + "-" + read["EmpLastName"]);
                        }
                        Console.ReadKey();
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("Something went wrong");
                }
            }

        }

        public static void RetrievePrincipal()
        {

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Database=SchoolRegister;Trusted_Connection=True;MultipleActiveResultSets=true";
            Console.Clear();
            Console.WriteLine("***** Principal *****");
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("SELECT EmpFirstName, EmpLastName FROM Employees WHERE FKRoleID=2", sqlConnection);
                    using (SqlDataReader read = command.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            Console.WriteLine(read["EmpFirstName"] + "-" + read["EmpLastName"]);
                        }
                        Console.ReadKey();
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("Something went wrong");
                }
            }

        }

        public static void RetrieveAdmin()
        {

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Database=SchoolRegister;Trusted_Connection=True;MultipleActiveResultSets=true";
            Console.Clear();
            Console.WriteLine("***** Administrator *****");
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("SELECT EmpFirstName, EmpLastName FROM Employees WHERE FKRoleID=3", sqlConnection);
                    using (SqlDataReader read = command.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            Console.WriteLine(read["EmpFirstName"] + "-" + read["EmpLastName"]);
                        }
                        Console.ReadKey();
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("Something went wrong");
                }
            }

        }

        public static void RetrieveNurses()
        {

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Database=SchoolRegister;Trusted_Connection=True;MultipleActiveResultSets=true";
            Console.Clear();
            Console.WriteLine("***** School Nurse *****");
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("SELECT EmpFirstName, EmpLastName FROM Employees WHERE FKRoleID=4", sqlConnection);
                    using (SqlDataReader read = command.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            Console.WriteLine(read["EmpFirstName"] + "-" + read["EmpLastName"]);
                        }
                        Console.ReadKey();
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("Something went wrong");
                }
            }

        }
        // ClassID = 1
        public static void RetrieveSByClass1FnameDesc()
        {
            using SchoolRegisterContext context = new SchoolRegisterContext();

            var students = context.Students.Where(s => s.FkclassId == 1).OrderByDescending(s => s.FirstName).ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            Console.ReadKey();
        }

        public static void RetrieveSByClass1FnameAsc()
        {
            using SchoolRegisterContext context = new SchoolRegisterContext();

            var students = context.Students.Where(s => s.FkclassId == 1).OrderBy(s => s.FirstName).ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            Console.ReadKey();
        }

        public static void RetrieveSByClass1LnameDesc()
        {
            using SchoolRegisterContext context = new SchoolRegisterContext();

            var students = context.Students.Where(s => s.FkclassId == 1).OrderByDescending(s => s.LastName).ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.LastName} {student.FirstName}");
            }
            Console.ReadKey();
        }

        public static void RetrieveSByClass1LnameAsc()
        {
            using SchoolRegisterContext context = new SchoolRegisterContext();

            var students = context.Students.Where(s => s.FkclassId == 1).OrderBy(s => s.LastName).ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.LastName} {student.FirstName}");
            }
            Console.ReadKey();
        }
        // ClassID = 2
        public static void RetrieveSByClass2FnameDesc()
        {
            using SchoolRegisterContext context = new SchoolRegisterContext();

            var students = context.Students.Where(s => s.FkclassId == 2).OrderByDescending(s => s.FirstName).ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            Console.ReadKey();
        }

        public static void RetrieveSByClass2FnameAsc()
        {
            using SchoolRegisterContext context = new SchoolRegisterContext();

            var students = context.Students.Where(s => s.FkclassId == 2).OrderBy(s => s.FirstName).ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            Console.ReadKey();
        }

        public static void RetrieveSByClass2LnameDesc()
        {
            using SchoolRegisterContext context = new SchoolRegisterContext();

            var students = context.Students.Where(s => s.FkclassId == 2).OrderByDescending(s => s.LastName).ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.LastName} {student.FirstName}");
            }
            Console.ReadKey();
        }

        public static void RetrieveSByClass2LnameAsc()
        {
            using SchoolRegisterContext context = new SchoolRegisterContext();

            var students = context.Students.Where(s => s.FkclassId == 2).OrderBy(s => s.LastName).ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.LastName} {student.FirstName}");
            }
            Console.ReadKey();
        }
        // ClassID = 3
        public static void RetrieveSByClass3FnameDesc()
        {
            using SchoolRegisterContext context = new SchoolRegisterContext();

            var students = context.Students.Where(s => s.FkclassId == 3).OrderByDescending(s => s.FirstName).ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            Console.ReadKey();
        }

        public static void RetrieveSByClass3FnameAsc()
        {
            using SchoolRegisterContext context = new SchoolRegisterContext();

            var students = context.Students.Where(s => s.FkclassId == 3).OrderBy(s => s.FirstName).ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            Console.ReadKey();
        }

        public static void RetrieveSByClass3LnameDesc()
        {
            using SchoolRegisterContext context = new SchoolRegisterContext();

            var students = context.Students.Where(s => s.FkclassId == 3).OrderByDescending(s => s.LastName).ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.LastName} {student.FirstName}");
            }
            Console.ReadKey();
        }

        public static void RetrieveSByClass3LnameAsc()
        {
            using SchoolRegisterContext context = new SchoolRegisterContext();

            var students = context.Students.Where(s => s.FkclassId == 3).OrderBy(s => s.LastName).ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.LastName} {student.FirstName}");
            }
            Console.ReadKey();
        }
    }
}
