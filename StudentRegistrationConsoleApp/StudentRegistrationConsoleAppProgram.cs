using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using StudentRegistrationCodeFirstFromDB;
using static System.Console;

namespace StudentRegistrationConsoleApp
{
    class StudentRegistrationConsoleAppProgram
    {
        // Test CRUD operations against the StudentRegistrationDB
        static void Main(string[] args)
        {
            Console.WriteLine("==== Display all tables and registrations");

            // Open connection to DB
            StudentRegistrationDBEntities context = new StudentRegistrationDBEntities();

            // Display Departments table
            context.Departments.Load();
            WriteLine("Display Departments table");
            foreach (Department department in context.Departments)
            {
                WriteLine(department);
            }
            WriteLine();

            // Display Courses table
            context.Courses.Load();
            WriteLine("Display Courses table");
            foreach(Cours course in context.Courses)
            {
                WriteLine(course);
            }
            WriteLine();

            // Display Students table
            context.Students.Load();
            WriteLine("Display Students table");
            foreach( Student student in context.Students)
            {
                WriteLine(student);
            }
            WriteLine();

            context.StudentCourses.Load();
            WriteLine("Display Students Course");
            foreach (StudentCours studentCourse in context.StudentCourses)
            {
                WriteLine(studentCourse);
            }
            WriteLine();

            // HINT: write a generic method to display using DbSet<T>

            Console.WriteLine("==== Register all students in FINC 101");

            string query = "INSERT INTO StudentCourses(CourseId, StudentId)" +
                "SELECT CourseId, StudentId " +
                "FROM Students JOIN Departments ON Students.DepartmentId = Departments.DepartmentId " +
                "JOIN Courses ON Courses.DepartmentId = Departments.DepartmentId" +
                "WHERE Courses.CourseNumber = 101 AND Departments.DepartmentCode = 'FINC' ";

            context.Database.ExecuteSqlCommand(query);




            Console.WriteLine("==== Show updated registrations");

            context.StudentCourses.Load();
            WriteLine("Display Students Course");
            foreach (StudentCours studentCourse in context.StudentCourses)
            {
                WriteLine(studentCourse);
            }
            WriteLine();

         

            Console.WriteLine("==== Add student John Duvee CSIS, then display Student table");

            var studentAdd = new Student
            {
                StudentFirstName = "Jonh",
                StudentLastName = "Duvee",
                DepartmentId = 1
            };

            int StudentIDAdded = studentAdd.StudentId;
            context.Students.Add(studentAdd);
            context.SaveChanges();

            Console.WriteLine("Students");
            context.Students.Load();
            foreach (Student student in context.Students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("==== Remove student John Duvee CSIS, then display Student table");

            Student studentToDelete = context.Students.Find(StudentIDAdded);
            //context.Students.Remove(studentToDelete);
            //context.SaveChanges();


            Console.WriteLine("==== Change student Michael Thorson CSIS,  to Michael Thomas FINC then display Student table");

            // your code here

            Console.WriteLine("==== Remove student Svetlana Rostov CSIS, then display Student table and registrations");

            // your code here

            Console.ReadLine();
        }

 
    }
}
