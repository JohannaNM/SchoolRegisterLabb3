using Microsoft.EntityFrameworkCore;
using SchoolRegisterLabb3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegisterLabb3
{
    internal class Run
    {
        internal bool MainMenu()
        {
            bool runMenu = true;
            bool displayMainMenu = true;
            bool displaySubMenu = true;

            do
            {
                displaySubMenu = true;
                int option = MyMenu.Menus("Retrieve all Employees", "Retrieve all Students", "Retrieve all students in a particular class",
                    "Retrieve all grades, set last month", "Retrieve a list with all courses with students AVG, MAX and MIN grade", "Add new Student",
                    "Add new Employee", "Exit");
                switch (option)
                {
                    case 1:
                        do
                        {
                            Console.Clear();
                            option = MyMenu.Menus("Retrieve all Employees", "Retrieve all Teachers", "Retrieve Principal",
                                "Retrieve all Administrators", "Retrieve all School Nurses", "Return to Main Menu");
                            switch (option)
                            {
                                case 1:
                                    var retrieve = new Retrieve();
                                    Retrieve.RetrieveEmployees();
                                    break;
                                case 2:
                                    Retrieve.RetrieveTeachers();
                                    break;
                                case 3:
                                    Retrieve.RetrievePrincipal();
                                    break;
                                case 4:
                                    Retrieve.RetrieveAdmin();
                                    break;
                                case 5:
                                    Retrieve.RetrieveNurses();
                                    break;
                                case 6:
                                    displaySubMenu = false;
                                    break;
                            }

                        } while (displaySubMenu == true);
                        break;

                    case 2:
                        do
                        {
                            Console.Clear();
                            option = MyMenu.Menus("Students sorted by First Name","Students Sorted by Last Name", "Return to Main Menu");
                            switch (option)
                            {
                                case 1:
                                    do
                                    {
                                        Console.Clear();
                                        option = MyMenu.Menus("First Name ASC","First Name DESC","Return");
                                        switch (option)
                                        {
                                            case 1:
                                                Console.Clear();
                                                SchoolRegisterContext dbcontext = new SchoolRegisterContext();
                                                var students2 = dbcontext.Students.OrderBy(s => s.FirstName).ToList();
                                                foreach (var student in students2)
                                                {
                                                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                                                }
                                                Console.ReadKey();
                                                break;
                                            case 2:
                                                Console.Clear();
                                                SchoolRegisterContext dbcontext2 = new SchoolRegisterContext();
                                                var students = dbcontext2.Students.OrderByDescending(s => s.FirstName).ToList();
                                                foreach (var student in students)
                                                {
                                                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                                                }
                                                Console.ReadKey();
                                                break;
                                            case 3:
                                                displaySubMenu = false;
                                                break;
                                        }

                                    } while (displaySubMenu == true);
                                    break;

                                case 2:
                                    do
                                    {
                                        Console.Clear();
                                        option = MyMenu.Menus("Last Name ASC", "Last Name DESC", "Return");
                                        switch (option)
                                        {
                                            case 1:
                                                Console.Clear();
                                                SchoolRegisterContext dbcontext = new SchoolRegisterContext();
                                                var students2 = dbcontext.Students.OrderBy(s => s.LastName).ToList();
                                                foreach (var student in students2)
                                                {
                                                    Console.WriteLine($"{student.LastName} {student.FirstName}");
                                                }
                                                Console.ReadKey();
                                                break;
                                            case 2:
                                                Console.Clear();
                                                SchoolRegisterContext dbcontext2 = new SchoolRegisterContext();
                                                var students = dbcontext2.Students.OrderByDescending(s => s.LastName).ToList();
                                                foreach (var student in students)
                                                {
                                                    Console.WriteLine($"{student.LastName} {student.FirstName}");
                                                }
                                                Console.ReadKey();
                                                break;
                                            case 3:
                                                displaySubMenu = false;
                                                break;
                                        }

                                    } while (displaySubMenu == true);
                                    break;

                                case 3:
                                    displaySubMenu = false;
                                    break;
                            }
                        } while (displaySubMenu == true);
                        break;
                    case 3:
                        do
                        {
                            Console.Clear();
                            option = MyMenu.Menus("Economics23A", "Aesthetics22B", "NaturalScience23C", "Return");
                            switch (option)
                            {

                                case 1:

                                    do
                                    {
                                        Console.Clear();
                                        option = MyMenu.Menus("Students sorted by First Name", "Students Sorted by Last Name", "Return to Main Menu");
                                        switch (option)
                                        {
                                            case 1:
                                                do
                                                {
                                                    Console.Clear();
                                                    option = MyMenu.Menus("First Name ASC", "First Name DESC", "Return");
                                                    switch (option)
                                                    {
                                                        case 1:
                                                            Console.Clear();
                                                            Console.WriteLine("Economics23A");
                                                            Console.WriteLine("*******************");
                                                            var retrieveSByClass1FnameAsc = new Retrieve();
                                                            Retrieve.RetrieveSByClass1FnameAsc();

                                                            break;
                                                        case 2:
                                                            Console.Clear();
                                                            Console.WriteLine("Economics23A");
                                                            Console.WriteLine("*******************");
                                                            var retrieveSByClass1FnameDesc = new Retrieve();
                                                            Retrieve.RetrieveSByClass1FnameDesc();
                                                            break;
                                                        case 3:
                                                            displaySubMenu = false;
                                                            break;
                                                    }

                                                } while (displaySubMenu == true);
                                                break;

                                            case 2:
                                                do
                                                {
                                                    Console.Clear();
                                                    option = MyMenu.Menus("Last Name ASC", "Last Name DESC", "Return");
                                                    switch (option)
                                                    {
                                                        case 1:
                                                            Console.Clear();
                                                            Console.WriteLine("Economics23A");
                                                            Console.WriteLine("*******************");
                                                            var retrieveSByClass1LnameAsc = new Retrieve();
                                                            Retrieve.RetrieveSByClass1LnameAsc();
                                                            break;
                                                        case 2:
                                                            Console.Clear();
                                                            Console.WriteLine("Economics23A");
                                                            Console.WriteLine("*******************");
                                                            var retrieveByClass1LnameDesc = new Retrieve();
                                                            Retrieve.RetrieveSByClass1LnameDesc();
                                                            break;
                                                        case 3:
                                                            displaySubMenu = false;
                                                            break;
                                                    }

                                                } while (displaySubMenu == true);
                                                break;

                                            case 3:
                                                displaySubMenu = false;
                                                break;
                                        }
                                    } while (displaySubMenu == true) ;
                                    break;

                                case 2:

                                    do
                                    {
                                        Console.Clear();
                                        option = MyMenu.Menus("Students sorted by First Name", "Students Sorted by Last Name", "Return to Main Menu");
                                        switch (option)
                                        {
                                            case 1:
                                                do
                                                {
                                                    Console.Clear();
                                                    option = MyMenu.Menus("First Name ASC", "First Name DESC", "Return");
                                                    switch (option)
                                                    {
                                                        case 1:
                                                            Console.Clear();
                                                            Console.WriteLine("Aesthetics22B");
                                                            Console.WriteLine("*******************");
                                                            var retrieveSByClass2FnameAsc = new Retrieve();
                                                            Retrieve.RetrieveSByClass2FnameAsc();

                                                            break;
                                                        case 2:
                                                            Console.Clear();
                                                            Console.WriteLine("Aesthetics22B");
                                                            Console.WriteLine("*******************");
                                                            var retrieveSByClass2FnameDesc = new Retrieve();
                                                            Retrieve.RetrieveSByClass2FnameDesc();
                                                            break;
                                                        case 3:
                                                            displaySubMenu = false;
                                                            break;
                                                    }

                                                } while (displaySubMenu == true);
                                                break;

                                            case 2:
                                                do
                                                {
                                                    Console.Clear();
                                                    option = MyMenu.Menus("Last Name ASC", "Last Name DESC", "Return");
                                                    switch (option)
                                                    {
                                                        case 1:
                                                            Console.Clear();
                                                            Console.WriteLine("Aesthetics22B");
                                                            Console.WriteLine("*******************");
                                                            var retrieveSByClass2LnameAsc = new Retrieve();
                                                            Retrieve.RetrieveSByClass2LnameAsc();
                                                            break;
                                                        case 2:
                                                            Console.Clear();
                                                            Console.WriteLine("Aesthetics22B");
                                                            Console.WriteLine("*******************");
                                                            var retrieveByClass2LnameDesc = new Retrieve();
                                                            Retrieve.RetrieveSByClass2LnameDesc();
                                                            break;
                                                        case 3:
                                                            displaySubMenu = false;
                                                            break;
                                                    }

                                                } while (displaySubMenu == true);
                                                break;

                                            case 3:
                                                displaySubMenu = false;
                                                break;
                                        }
                                    } while (displaySubMenu == true);
                                    break;
                                 
                                case 3:


                                    {
                                        Console.Clear();
                                        option = MyMenu.Menus("Students sorted by First Name", "Students Sorted by Last Name", "Return to Main Menu");
                                        switch (option)
                                        {
                                            case 1:
                                                do
                                                {
                                                    Console.Clear();
                                                    option = MyMenu.Menus("First Name ASC", "First Name DESC", "Return");
                                                    switch (option)
                                                    {
                                                        case 1:
                                                            Console.Clear();
                                                            Console.WriteLine("NaturalScience23C");
                                                            Console.WriteLine("*******************");
                                                            var retrieveSByClass3FnameAsc = new Retrieve();
                                                            Retrieve.RetrieveSByClass3FnameAsc();

                                                            break;
                                                        case 2:
                                                            Console.Clear();
                                                            Console.WriteLine("NaturalScience23C");
                                                            Console.WriteLine("*******************");
                                                            var retrieveSByClass3FnameDesc = new Retrieve();
                                                            Retrieve.RetrieveSByClass3FnameDesc();
                                                            break;
                                                        case 3:
                                                            displaySubMenu = false;
                                                            break;
                                                    }

                                                } while (displaySubMenu == true);
                                                break;

                                            case 2:
                                                do
                                                {
                                                    Console.Clear();
                                                    option = MyMenu.Menus("Last Name ASC", "Last Name DESC", "Return");
                                                    switch (option)
                                                    {
                                                        case 1:
                                                            Console.Clear();
                                                            Console.WriteLine("NaturalScience23C");
                                                            Console.WriteLine("*******************");
                                                            var retrieveSByClass3LnameAsc = new Retrieve();
                                                            Retrieve.RetrieveSByClass3LnameAsc();
                                                            break;
                                                        case 2:
                                                            Console.Clear();
                                                            Console.WriteLine("NaturalScience23C");
                                                            Console.WriteLine("*******************");
                                                            var retrieveByClass3LnameDesc = new Retrieve();
                                                            Retrieve.RetrieveSByClass3LnameDesc();
                                                            break;
                                                        case 3:
                                                            displaySubMenu = false;
                                                            break;
                                                    }

                                                } while (displaySubMenu == true);
                                                break;

                                            case 3:
                                                displaySubMenu = false;
                                                break;
                                        }
                                    } while (displaySubMenu == true) ;
                                    break;
                        
                                case 4:
                                    displaySubMenu = false;
                                    break;
                            }

                        } while (displaySubMenu == true);

                        break;
                    case 4:
                        var retrieveGrades = new Retrieve();
                        Retrieve.RetrieveGrades();
                        break;
                    case 5:
                        var retrieveAggregation = new Retrieve();
                        Retrieve.RetrieveAggregateGradesOnCourse();
                        break;
                    case 6:
                        var mystudent = new AddPerson();
                        AddPerson.AddStudent();
                        break;

                    case 7:
                        do
                        {
                            Console.Clear();
                            option = MyMenu.Menus("Add new Teacher", "Add new Administrator", "Add new School Nurse", "Return to Main Menu");
                            switch (option)
                            {
                                case 1:
                                    var myTeacher = new AddPerson();
                                    AddPerson.AddTeacher();
                                    break;
                                case 2:
                                    var myAdmin = new AddPerson();
                                    AddPerson.AddAdmin();
                                    break;
                                case 3:
                                    var myNurse = new AddPerson();
                                    AddPerson.AddNurse();
                                    break;
                                case 4:
                                    displaySubMenu = false;
                                    break;
                            }
                               
                        } while (displaySubMenu == true);
                        break;
                    case 8:

                        Console.WriteLine("**** Closing program ****");
                        Console.ReadKey();
                        runMenu = false;
                        displayMainMenu = false;
                        break;



                }
            } while (displayMainMenu == true);
            return runMenu;
        }

        public void RunMenu()
        {
            bool runMenu;
            do
            {
                runMenu = MainMenu();
            } while (runMenu == true);
        }
    }
}
