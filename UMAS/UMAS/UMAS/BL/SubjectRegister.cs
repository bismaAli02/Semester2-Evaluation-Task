using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMAS.BL
{
    class SubjectRegister
    {
        public SubjectRegister(int CreditHours, string code,string SubjectType, int SubjectFee )
        {
            this.CreditHours = CreditHours;
            this.code = code;
            this.SubjectType = SubjectType;
            this.SubjectFee = SubjectFee;
        }
        
        
        private int CreditHours;
        private string code;
        private string SubjectType;
        private int SubjectFee;

        public int GetCreditHours()
        {
            return CreditHours;
        }
        public string GetCode()
        {
            return code;
        }

        public string GetSubjectType()
        {
            return SubjectType;
        }

        public int GetSubjectFee()
        {
            return SubjectFee;
        }
        

        public int TotalCH(List<SubjectRegister> Subject, SubjectRegister s)
        {
            int totalCH = 0;
            foreach(SubjectRegister sub in Subject)
            {
                totalCH = totalCH + sub.CreditHours;
            }
            totalCH = totalCH + s.CreditHours;
            return totalCH;
        }  
         
    }

}
