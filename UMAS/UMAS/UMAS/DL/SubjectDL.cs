using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMAS.BL;
using System.IO;

namespace UMAS.DL
{
    class SubjectDL
    {
        public static List<SubjectRegister> subjectList = new List<SubjectRegister>();

        public static void addSubjectIntoList(SubjectRegister s)
        {
            subjectList.Add(s);
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
                    string code = splittedRecord[0];
                    string type = splittedRecord[1];
                    int CreditHours = int.Parse(splittedRecord[2]);
                    int subjectFees = int.Parse(splittedRecord[3]);
                    SubjectRegister s = new SubjectRegister(CreditHours, code, type, subjectFees);
                    addSubjectIntoList(s);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void storeintoFile(string path, SubjectRegister s)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(s.GetCode() + "," + s.GetSubjectType() + "," + s.GetCreditHours() + "," + s.GetSubjectFee());
            f.Flush();
            f.Close();
        }
        public static SubjectRegister isSubjectExists(string type)
        {
            foreach (SubjectRegister s in subjectList)
            {
                if (s.GetSubjectType() == type)
                {
                    return s;
                }
            }
            return null;
        }
    }
}
