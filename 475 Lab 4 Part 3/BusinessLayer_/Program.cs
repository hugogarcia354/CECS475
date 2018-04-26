using _475_Lab_4_Part_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer_
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();

        }

        static void Menu()
        {
            try
            {
                int choice = 0;
                while (choice != 3)
                {
                    Console.WriteLine("\n1.Standard\n2.Student\n3.Exit");
                    Console.WriteLine("Selection: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        StandardMenu();
                    }
                    else if (choice == 2)
                    {
                        StudentMenu();
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("Goodbye");
                    }
                    else
                    {
                        Console.WriteLine("Not a valid selection");
                    }
                }

            }
            catch (Exception e)
            {
                if (e.Message.Equals("Object reference not set to an instance of an object."))
                {
                    Console.WriteLine("ID not in table");
                }
                else
                    Console.WriteLine(e.Message);
                Menu();
            }
        }

        static void StandardMenu()
        {
            BusinessLayer business = new BusinessLayer();
            int choice = 0;
            while (choice != 5)
            {
                Console.WriteLine("\n1.Insert\n2.Delete\n3.Get Standard by ID\n4.Get All\n5.Exit");
                Console.WriteLine("Selection: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    //Console.Write("Standard ID: ");
                    //var id = Console.ReadLine();
                    Console.Write("Standard Name: ");
                    var name = Console.ReadLine();
                    Console.Write("Standard Description: ");
                    var description = Console.ReadLine();

                    Standard standard = new Standard
                    {
                        //StandardId = Convert.ToInt32(id),
                        StandardName = name,
                        Description = description
                    };

                    business.addStandard(standard);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Delete Standard");
                    Console.Write("ID #: ");
                    var id = Console.ReadLine();
                    Standard standard = business.GetStandardByID(Convert.ToInt32(id));
                    business.removeStandard(standard);
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Get Standard by ID");
                    Console.Write("ID #: ");
                    var id = Console.ReadLine();
                    Standard standard = business.GetStandardByID(Convert.ToInt32(id));
                    Console.WriteLine($"ID: {standard.StandardId}\nName: {standard.StandardName}\nDescription: {standard.Description}");
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Get All Standard");
                    var standards = business.getAllStandards();
                    foreach( var standard in standards)
                    {
                        Console.WriteLine($"ID: {standard.StandardId}\nName: {standard.StandardName}\nDescription: {standard.Description}\n\n");
                    }
                    
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Returning to main menu");
                }
                else
                {
                    Console.WriteLine("Not a valid selection");
                }
            }
        }

        static void StudentMenu()
        {
            BusinessLayer business = new BusinessLayer();
            int choice = 0;
            while (choice != 6)
            {
                Console.WriteLine("\n1.Insert\n2.Delete\n3.Get Student by ID\n4.Get All\n5.Get all Students from a Standard Id\n6.Exit");
                Console.WriteLine("Selection: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Write("Student Name: ");
                    var name = Console.ReadLine();
                    Console.Write("Standard ID:");
                    var id = Console.ReadLine();
                    Student student = new Student
                    {
                        StudentName = name,
                        StandardId = Convert.ToInt32(id)
                    };

                    business.addStudent(student);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Delete Student");
                    Console.Write("ID #: ");
                    var id = Console.ReadLine();
                    Student student = business.GetStudentByID(Convert.ToInt32(id));
                    business.RemoveStudent(student);
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Get Student by ID");
                    Console.Write("ID #: ");
                    var id = Console.ReadLine();
                    Student student = business.GetStudentByID(Convert.ToInt32(id));
                    Console.WriteLine($"ID: {student.StandardId}\nName: {student.StudentName}");
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Get All Students");
                    var students = business.getAllStudents();
                    foreach (var student in students)
                    {
                        Console.WriteLine($"ID: {student.StudentID}\nName: {student.StudentName}");
                    }

                }
                else if (choice == 5)
                {
                    Console.WriteLine("Get All Students of a Standard");
                    Console.Write("ID #: ");
                    var id = Console.ReadLine();
                    var students = business.GetStudentsByStandard(Convert.ToInt32(id));
                    foreach (var student in students)
                    {
                        Console.WriteLine($"ID: {student.StudentID}\nName: {student.StudentName}");
                    }
                }
                else if (choice == 6)
                {
                    Console.WriteLine("Returning to main menu");
                }
                else
                {
                    Console.WriteLine("Not a valid selection");
                }
            }
        }
    }

    
}
