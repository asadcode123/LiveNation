﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SETestFreelancer.Models
{
    public class LiveNationSummaryResponseDto
    {
        public string Result { get; set; }

        public Dictionary<string, int> Summary { get; set; }
    }
}