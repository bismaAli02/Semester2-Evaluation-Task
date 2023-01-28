using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMAS.BL;
using UMAS.DL;

namespace UMAS.UI
{
    class DegreeUI
    {

        public static void displayDegree(DegreeProgram d)
        {

            Console.WriteLine("Degree title: " + d.GetTitle());
        }


        public static List<DegreeProgram> AddPrefrences()
        {
            List<DegreeProgram> Prefrences = new List<DegreeProgram>();
            Console.WriteLine("All degrees");
            foreach (DegreeProgram d in DegreeProgramDL.degree)
            {
                displayDegree(d);
            }
            Console.WriteLine("How many prefrences you want to add: ");
            int p = int.Parse(Console.ReadLine());
            if (DegreeProgramDL.degree.Count >= p)
            {
                p = DegreeProgramDL.degree.Count;
            }
            else
            {
                Console.WriteLine("You can add prefrence only equal to No of degrees");
            }
            Console.WriteLine("Choose Your prefrences....");
                for (int i = 0; i < p; i++)
                {
                    Console.WriteLine("Enter your  {0} prefrence: ", i + 1);
                    string pref = Console.ReadLine();
                    DegreeProgram d = DegreeProgramDL.IsDegreeExists(pref);
                    if (d != null)
                    {
                        Prefrences.Add(d);
                    }
                    else
                    {
                        Console.WriteLine("This degree is not available");
                    }
                }
                return Prefrences;
         }


        public static DegreeProgram AddDegree()
        {

            Console.WriteLine("Enter Degree name: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter Degree Duration: ");
            string duration = Console.ReadLine();
            Console.WriteLine("Enter seats : ");
            int seats = int.Parse(Console.ReadLine());

            DegreeProgram degree = new DegreeProgram(title, duration, seats);
            List<SubjectRegister> Subject = SubjectUI.AddSubjects(degree);
            degree.AddSubjectsInList(Subject);
            return degree;

        }

        public static string degreeName()
        {
            Console.WriteLine("Enter degree name which students you want to see: ");
            string d = Console.ReadLine();
            return d;
        }
    }
}
