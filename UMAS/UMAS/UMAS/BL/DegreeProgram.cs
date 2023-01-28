using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMAS.BL
{
    class DegreeProgram
    {

        public DegreeProgram(string title, string duration, int seats)
        {
            this.title = title;
            this.duration = duration;
            this.seats = seats;
        }

        private string title;
        private string duration;
        private int seats;
        private List<SubjectRegister> Contain = new List<SubjectRegister>();

        public string GetTitle()
        {
            return title;
        }

        public string GetDuration()
        {
            return duration;
        }

        public int GetSeats()
        {
            return seats;
        }

        public void setSeats(int seats)
        {
            this.seats = seats;
        }

        public List<SubjectRegister> GetSubjctList()
        {
            return Contain;
        }



        public bool IsSubjectExists(SubjectRegister subject)
        {
            foreach (var sub in Contain)
            {
                if (sub.GetCode() == subject.GetCode())
                {
                    return true;
                }
            }
            return false;
        }
        public void AddSubjectsInList(List<SubjectRegister> Contain)
        {
            this.Contain = Contain;
        }
        public void AddSubject(SubjectRegister sub)
        {
            Contain.Add(sub);
        }



    }
}