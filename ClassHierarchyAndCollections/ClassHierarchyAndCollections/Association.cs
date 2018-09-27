﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchyAndCollections
{
    public class Association: Organization, IAnnualProfit
    {
        public string Description { get; set; }

        public string AnnualGoal { get; set; }
    }
}
