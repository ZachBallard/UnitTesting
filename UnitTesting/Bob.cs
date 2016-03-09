using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            else if (CheckYelling(remark))
            {
                return "Whoa, chill out!";
            }
            else if (CheckQuestion(remark))
            {
                return "Sure.";
            }
            else
            {
                return "Whatever.";
            }
           
        }

        public bool CheckYelling(string remark)
        {
            int useless;
            return (remark == remark.ToUpper() && int.TryParse(remark, out useless)) && !remark.EndsWith("!");
        }

        public bool CheckQuestion(string remark)
        {
            return remark.EndsWith("?");
        }

        public bool CheckSilence(string remark)
        {
            return remark == null || remark.Trim() == "";
        }
    }
}
