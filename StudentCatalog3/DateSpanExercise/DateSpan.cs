using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentCatalog3.DateSpanExercise
{
    public class DateSpan
    {
        public DateTime from { get; set; }
        public DateTime to { get; set; }
        public bool IsOverlap(DateTime start, DateTime finish)
        {
            if (start > finish)
            {
                throw new 
                    ArgumentException("Start is larger than finish");
            }
            else if (start > to || finish < from)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}