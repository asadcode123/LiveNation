using SETestFreelancer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SETestFreelancer.Services
{
    public class LiveNationRuleValidator : IRuleValidator
    {
        public bool ApplyRule(int number)
        {
            return number % 5 == 0 && number % 3 == 0;
        }

        public string getDescription()
        {
            return "LiveNation";
        }
    }
}