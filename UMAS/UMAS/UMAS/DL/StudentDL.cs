using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using UMAS.BL;

namespace UMAS.DL
{
    class StudentDL
    {
        public static List<Student> stu = new List<Student>();
        public static List<Student> newList = new List<Student>();
        public static List<Student> Sort()
        {
            newList = stu.OrderByDescending(o => o.GetMerit()).ToList();
            return newList;
        }


        public static bool IsApplicable(Student s)
        {
            int seats = 0;
            for (int x = 0; x < s.GetRegister().Count; x++)
            {
                DegreeProgram degree = s.GetRegister()[x];
                if (degree.GetSeats() != 0)
                {
                    seats = degree.GetSeats();
                    degree.setSeats(seats - 1);
                    s.setApplies(degree);
                    return true;
                }
            }
            DegreeProgram Applies = s.GetApplies();
            Applies = null;
            s.setApplies(Applies);
            return false;


        }


        public static void storeintoFile(string path, Student s)
        {
            StreamWriter f = new StreamWriter(path, true);
            string degreeNames = "";
            for (int x = 0; x < s.GetRegister().Count - 1; x++)
            {
                degreeNames = degreeNames + s.GetRegister()[x].GetTitle() + ";";
            }
            degreeNames = degreeNames + s.GetRegister()[s.GetRegister().Count - 1].GetTitle();
            f.WriteLine(s.GetName() + "," + s.GetAge() + "," + s.GetFscMarks() + "," + s.GetEcatMarks() + "," + degreeNames);
            f.Flush();
            f.Close();
        }

        public static bool readFromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    int age = int.Parse(splittedRecord[1]);
                    float FscMarks = float.Parse(splittedRecord[2]);
                    float EcatMarks = float.Parse(splittedRecord[3]);
                    string[] splittedRecordForPreference = splittedRecord[4].Split(';');
                    List<DegreeProgram> preferences = new List<DegreeProgram>();

                    for (int x = 0; x < splittedRecordForPreference.Length; x++)
                    {
                        DegreeProgram d = DegreeProgramDL.IsDegreeExists(splittedRecordForPreference[x]);
                        if (d != null)
                        {
                            if (!(preferences.Contains(d)))
                            {
                                preferences.Add(d);
                            }
                        }
                    }
                    Student s = new Student(name, age, FscMarks, EcatMarks, preferences);
                    stu.Add(s);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
