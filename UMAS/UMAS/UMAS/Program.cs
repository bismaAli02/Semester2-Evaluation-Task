using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMAS.BL;
using UMAS.DL;
using UMAS.UI;
namespace UMAS
{
    class Program
    {





        static void Main(string[] args)
        {
            string degPath = "degree.txt";
            string SubPath = "subject.txt";
            string StuPath = "student.txt";
            if (SubjectDL.readFromFile(SubPath))
            {
                MenuUI.Load();
            }
            else
            {
                MenuUI.UnLoad();
            }
            if (DegreeProgramDL.readFromFile(degPath))
            {
                MenuUI.Load();
            }
            else
            {
                MenuUI.UnLoad();
            }

            if (StudentDL.readFromFile(StuPath))
            {
                MenuUI.Load();
            }
            else
            {
                MenuUI.UnLoad();
            }

            Console.ReadKey();

            while (true)
            {
                char option = MenuUI.menu();
                MenuUI.systemCls();
                MenuUI.header();
                if (option == '1')
                {
                    Student stu = StudentUI.takeInput();
                    StudentDL.stu.Add(stu);
                    StudentDL.storeintoFile(StuPath, stu);
                }
                else if (option == '2')
                {
                    DegreeProgram d = DegreeUI.AddDegree();
                    if (DegreeProgramDL.IsDegreeExists(d.GetTitle()) == null)
                    {
                        DegreeProgramDL.AddDegreeInList(d);
                        DegreeProgramDL.storeintoFile(degPath, d);
                    }
                    else
                    {
                        MenuUI.DisplayDegreeExist();
                    }

                }
                else if (option == '3')
                {
                    StudentUI.MeritList();


                }
                else if (option == '4')
                {
                    StudentUI.viewRegisteredStudent();

                }
                else if (option == '5')
                {
                    string d = DegreeUI.degreeName();
                    StudentUI.viewSpecificStudent(d);

                }
                else if (option == '6')
                {
                    SubjectUI.RegisterSubject();

                }
                else if (option == '7')
                {
                    StudentUI.DisplayFee();

                }
                else if (option == '8')
                {
                    break;
                }
                else
                {
                    MenuUI.DisplayWrongOption();
                }
                MenuUI.systemCls();
            }

        }
    }
}
