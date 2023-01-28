using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using UMAS.BL;

namespace UMAS.DL
{
    class DegreeProgramDL
    {
        public static List<DegreeProgram> degree = new List<DegreeProgram>();
        public static DegreeProgram IsDegreeExists(string degTitle)
        {
            foreach (DegreeProgram d in degree)
            {
                if (d.GetTitle() == degTitle)
                {
                    return d;
                }
            }

            return null;
        }
        public static void AddDegreeInList(DegreeProgram deg)
        {
            degree.Add(deg);
        }



        public static void storeintoFile(string path, DegreeProgram d)
        {
            StreamWriter f = new StreamWriter(path, true);
            string SubjectNames = "";
            for (int x = 0; x < d.GetSubjctList().Count - 1; x++)
            {
                SubjectNames = SubjectNames + d.GetSubjctList()[x].GetSubjectType() + ";";
            }
            SubjectNames = SubjectNames + d.GetSubjctList()[d.GetSubjctList().Count - 1].GetSubjectType();
            f.WriteLine(d.GetTitle() + "," + d.GetDuration() + "," + d.GetSeats() + "," + SubjectNames);
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
                    string title = splittedRecord[0];
                    string duration = splittedRecord[1];
                    int seats = int.Parse(splittedRecord[2]);
                    string[] splittedRecordForSubject = splittedRecord[3].Split(';');
                    DegreeProgram d = new DegreeProgram(title, duration, seats);
                    for (int x = 0; x < splittedRecordForSubject.Length; x++)
                    {
                        SubjectRegister s = SubjectDL.isSubjectExists(splittedRecordForSubject[x]);
                        if (s != null)
                        {
                            d.AddSubject(s);
                        }
                    }
                    AddDegreeInList(d);
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
