using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMAS.BL
{
    class Student
    {
        public Student(string name, int age, float FscMarks, float EcatMarks, List<DegreeProgram> Prefrences)
        {
            this.name = name;
            this.age = age;
            this.FscMarks = FscMarks;
            this.EcatMarks = EcatMarks;
            Applies = null;
            merit = Calculatemerit();
            this.Register = Prefrences;
        }





        private string name;
        private int age;
        private float FscMarks;
        private float EcatMarks;
        private float merit;
        private List<DegreeProgram> Register = new List<DegreeProgram>();
        private List<SubjectRegister> RegisteredSubject = new List<SubjectRegister>();
        private DegreeProgram Applies;

        public string GetName()
        {
            return name;
        }
        public int GetAge()
        {
            return age;
        }
        
        public float GetFscMarks()
        {
            return FscMarks;
        }

        public float GetEcatMarks()
        {
            return EcatMarks;
        }

        public float GetMerit()
        {
            return merit;
        }

        public DegreeProgram GetApplies()
        {
            return Applies;
        }

        public void setApplies(DegreeProgram Applies)
        {
            this.Applies = Applies;
        }

        public List<SubjectRegister> GetRegisteredSubject()
        {
            return RegisteredSubject;
        }

        public List<DegreeProgram> GetRegister()
        {
            return Register;
        }

        public float Calculatemerit()
        {
            float agg = ((FscMarks / 1100 * 60) + (EcatMarks / 400 * 40));
            return agg;
        }

        public bool IsSubjectRegister(SubjectRegister sub)
        {
            foreach(SubjectRegister s in RegisteredSubject)
            {
                if(s == sub)
                {
                    return true;
                }
            }
            return false;
        }
        public string CalculateFee()
        {
            float fee = 0;
            if (Applies != null)
            {
                for (int x = 0; x < RegisteredSubject.Count; x++)
                {
                    fee = fee + RegisteredSubject[x].GetSubjectFee();
                }
                return ("Student name: " + name + " Student fee: " + fee);
            }
            return null;

        }
    }
}










       

