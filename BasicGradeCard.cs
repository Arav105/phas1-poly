﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase1_poly
{
  
        public class BasicGradeCard
        {
            protected int totalMarks;

            public BasicGradeCard()
            {
                totalMarks = 0;
            }

            public virtual int getTotalMarks()
            {
                return totalMarks;
            }
        }
}
