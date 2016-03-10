using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class Bob
    {
        public string Hey(string remark)
        {
            if (CheckSilence(remark))
            {
                return "Fine. Be that way!";
            }
            if (CheckYelling(remark))
            {
                return "Whoa, chill out!";
            }
            if (CheckQuestion(remark))
            {
                return "Sure.";
            }
            return "Whatever.";
        }

        public bool CheckYelling(string remark)
        {
            return remark == IsAllUpper(remark);
        }

        private string IsAllUpper(string remark)
        {
            return "";
        }

        public bool CheckQuestion(string remark)
        {
            return remark.EndsWith("?") && remark != remark.ToUpper();
        }

        public bool CheckSilence(string remark)
        {
            return remark == null || remark.Trim() == "";
        }


    }
}
