using SchoolRegisterLabb3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegisterLabb3
{
    internal class AddPerson
    {
        public static void AddStudent()
        {
            Console.Clear();
            Console.WriteLine("Add New Student ");
            Console.WriteLine("Enter students First Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter students Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter students personalnumber in 12 digits ex 200701012356:");
            string pnr = Console.ReadLine();
            Console.WriteLine("Enter students class with 1, 2 or 3: ");
            Console.WriteLine("1) Economics23A");
            Console.WriteLine("2) Aesthetics22B");
            Console.WriteLine("3) NaturalScience23C");
            int myclass = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();

            using SchoolRegisterContext context = new SchoolRegisterContext();

            Student student1 = new Student()
            {
                FirstName = firstName,
                LastName = lastName,
                PersonalNumber = pnr,
                FkclassId = myclass
            };
           
            context.Students.Add(student1);
            context.SaveChanges();
        }

        public static void AddTeacher()
        {
            Console.Clear();
            Console.WriteLine("Add new Teacher");
            Console.WriteLine("Enter First Name: ");
            string tFirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            string tLastName = Console.ReadLine();
            Console.ReadKey();
            using SchoolRegisterContext context = new SchoolRegisterContext();

            Employee emp1 = new Employee()
            {
                EmpFirstName = tFirstName,
                EmpLastName = tLastName,
                FkroleId = 1
            };
            context.Employees.Add(emp1);
            context.SaveChanges();
        }

        public static void AddNurse()
        {
            Console.Clear();
            Console.WriteLine("Add new SchoolNurse");
            Console.WriteLine("Enter First Name: ");
            string nFirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            string nLastName = Console.ReadLine();
            Console.ReadKey();
            using SchoolRegisterContext context = new SchoolRegisterContext();

            Employee emp2 = new Employee()
            {
                EmpFirstName = nFirstName,
                EmpLastName = nLastName,
                FkroleId = 4
            };
            context.Employees.Add(emp2);
            context.SaveChanges();
            
        }

        public static void AddAdmin()
        {
            Console.Clear();
            Console.WriteLine("Add new Administrator");
            Console.WriteLine("Enter First Name: ");
            string aFirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            string aLastName = Console.ReadLine();
            Console.ReadKey();
            using SchoolRegisterContext context = new SchoolRegisterContext();

            Employee emp3 = new Employee()
            {
                EmpFirstName = aFirstName,
                EmpLastName = aLastName,
                FkroleId = 3
            };
            context.Employees.Add(emp3);
            context.SaveChanges();
        }
    }
}
