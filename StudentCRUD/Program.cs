using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Getstudent crud = new Getstudent();
            do
            {
                Console.WriteLine("1.StudentList");
                Console.WriteLine("2.Get Student by Id");
                Console.WriteLine("3.Add new Student");
                Console.WriteLine("4.Update Student ");
                Console.WriteLine("5.Delete student");
                Console.WriteLine("Enter the Option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        List<Student> list = crud.StudentList();
                        Console.WriteLine("RollNo \t Name \t Percetage \t Department");
                        foreach (Student s in list)
                        {
                            Console.WriteLine($"{s.RollNo}\t {s.Name} \t {s.Per}\t {s.Dept}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the Roll No want to Display");
                        int rollno = Convert.ToInt32(Console.ReadLine());
                        Student s1 = crud.GetStudentbyRollNo(rollno);
                        Console.WriteLine("rollno \t Name \t Percentage \t Department");
                        Console.WriteLine($"{s1.RollNo} \t {s1.Name} \t {s1.Per} \t {s1.Dept}");
                        break;
                    case 3:
                        Student s2 = new Student();
                        Console.WriteLine("Enter the Roll no of the student");
                        s2.RollNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Name of student ");
                        s2.Name = Console.ReadLine();
                        Console.WriteLine("Enter the persentage");
                        s2.Per = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the Department");
                        s2.Dept = Console.ReadLine();
                        crud.AddStudent(s2);
                        break;
                    case 4:
                        Student s3 = new Student();
                        Console.WriteLine("Enter the Rollno");
                        s3.RollNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Name");
                        s3.Name = Console.ReadLine();
                        Console.WriteLine("Enter the Persentage");
                        s3.Per = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the Department");
                        s3.Dept = Convert.ToString(Console.ReadLine());
                        crud.UpdateStudent(s3);
                        break;
                    case 5:
                        Console.WriteLine("Enter the Roll no want to delete");
                        int rollnO = Convert.ToInt32(Console.ReadLine());
                        crud.DeleteStudent(rollnO);
                        Console.WriteLine($"{rollnO} Deleted Sucessefully");
                        break;
                }
                Console.WriteLine("press 1 for continue");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n == 1);
        }
    }
}
