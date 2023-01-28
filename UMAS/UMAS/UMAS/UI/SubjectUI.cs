using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMAS.BL;
using UMAS.DL;

namespace UMAS.UI
{
    class SubjectUI
    {
        public static List<SubjectRegister> AddSubjects(DegreeProgram degree)
        {
            List<SubjectRegister> Subject = new List<SubjectRegister>();
            Console.WriteLine("How many subjects you want to enter in this degree: ");
            int sub = int.Parse(Console.ReadLine());
            int totalCH = 0;
            for (int i = 0; i < sub; i++)
            {

                Console.WriteLine("Enter Subject code: ");
                string code = (Console.ReadLine());
                Console.WriteLine("Enter subject Type: ");
                string SubjectType = Console.ReadLine();
                Console.WriteLine("Enter subject Credit hours: ");
                int CreditHours = int.Parse(Console.ReadLine());
                totalCH = totalCH + CreditHours;
                Console.WriteLine("Enter subject fee: ");
                int SubjectFee = int.Parse(Console.ReadLine());
                SubjectRegister temp = new SubjectRegister(CreditHours, code, SubjectType, SubjectFee);
                if (temp.TotalCH(Subject, temp) <= 20)
                {
                    if (!degree.IsSubjectExists(temp))
                    {
                        Subject.Add(temp);
                        SubjectDL.storeintoFile("subject.txt", temp);
                    }
                }
                else
                {
                    Console.WriteLine("A degree can only contain 20 credit hour");
                }
            }
            return Subject;
        }


        public static void DisplaySub(SubjectRegister s)
        {
            Console.WriteLine("Subject Type is: " + s.GetSubjectType() + " Subject Code is: " + s.GetCode());
        }


        public static void RegisterSubject()
        {
            int idx = -1;
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            for (int i = 0; i < StudentDL.stu.Count; i++)
            {
                if (StudentDL.stu[i].GetName() == name)
                {
                    if (StudentDL.stu[i].GetApplies() != null)
                    {
                        idx = i;
                        break;
                    }
                    
                }
            }
            if (idx != -1)
            {

                foreach (SubjectRegister s in StudentDL.stu[idx].GetApplies().GetSubjctList())
                {
                    DisplaySub(s);
                    Console.Write("Do you want to register this subject: press y for yes ");
                    char opt = char.Parse(Console.ReadLine());
                   
                    if (opt == 'Y' || opt == 'y')
                    {
                       
                       if (!StudentDL.stu[idx].IsSubjectRegister(s))
                       {
                           if (s.TotalCH(StudentDL.stu[idx].GetRegisteredSubject(), s) <= 9)
                           {
                                StudentDL.stu[idx].GetRegisteredSubject().Add(s);
                           }
                           else
                           {
                                Console.WriteLine("You can only registered subject less than or equal to 9 credit hours");
                           }
                       }
                       else
                       {
                           Console.WriteLine("Subject is already Registered");
                       }

                    }
                    
                }
            }
        }


    }
}
