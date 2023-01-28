using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMAS.BL;
using UMAS.DL;

namespace UMAS.UI
{
    class StudentUI
    {

        public static Student takeInput()
        {
            Console.WriteLine("Enter Student name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your FscMarks: ");
            float FscMarks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your EcatMarks: ");
            float EcatMarks = float.Parse(Console.ReadLine());
            List<DegreeProgram> Prefrences = DegreeUI.AddPrefrences();
            Student s = new Student(name, age, FscMarks, EcatMarks, Prefrences);
            return s;

        }

        public static void viewRegisteredStudent()
        {
            foreach (Student s in StudentDL.stu)
            {
                if (s.GetApplies() != null)
                {
                    Console.WriteLine("student name: " + s.GetName());
                    Console.WriteLine("student age: " + s.GetAge());
                    Console.WriteLine("student FscMarks: " + s.GetFscMarks());
                    Console.WriteLine("student ecatMarks: " + s.GetEcatMarks());
                    Console.WriteLine("student got admission in " + s.GetApplies().GetTitle());
                    Console.WriteLine(" ");
                }


            }
        }


        public static void viewSpecificStudent(string degree)
        {

            int count = 0;
            Console.WriteLine("Students List of " + degree);
            foreach (Student s in StudentDL.stu)
            {
                if (s.GetApplies() != null)
                {

                    if (s.GetApplies().GetTitle() == degree)
                    {
                        Console.WriteLine("student name: " + s.GetName());
                        Console.WriteLine("student age: " + s.GetAge());
                        Console.WriteLine("student FscMarks: " + s.GetFscMarks());
                        Console.WriteLine("student ecatMarks: " + s.GetEcatMarks());
                        Console.WriteLine(" ");
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("There are no students in this degree");
            }
        }

        public static void DisplayFee()
        {
            foreach (var stu in StudentDL.stu)
            {
                string fee = stu.CalculateFee();
                Console.WriteLine(fee);
            }
        }


        public static void MeritList()
        {
            List<Student> newList = StudentDL.Sort();
            foreach (Student s in newList)
            {
                if (StudentDL.IsApplicable(s) == true)
                {
                    Console.WriteLine("Student " + s.GetName() + " got admission in: " + s.GetApplies().GetTitle());
                }
                else
                {
                    Console.WriteLine("Student " + s.GetName() + " did'nt got admission");
                }
            }
        }
    }
}
