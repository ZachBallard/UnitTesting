﻿using System;
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
            if (remark.Any(t => char.IsDigit(t) && remark.EndsWith("!")))
            {
                return true;
            }

            return remark == ReplaceNumbers(remark.ToUpper());
        }

        private string ReplaceNumbers(string remark)
        {
            for (int i = 0; i < remark.Length; i++)
            {
                if (char.IsDigit(remark[i]))
                {
                    remark = remark.Replace(remark[i], '*');
                }
            }

            return remark;
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
