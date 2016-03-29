﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentCatalog3.Models
{
    public class CompetencyHeader
    {
        public int CompetencyHeaderId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Competency> Competencies { get; set; }
    }
}