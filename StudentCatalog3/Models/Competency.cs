using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentCatalog3.Models
{
    public class Competency
    {
        public int CompetencyId { get; set; }
        public string Name { get; set; }

        public int CompetencyHeaderId { get; set; }
        public CompetencyHeader CompetecyHeader { get; set; }
    }
}