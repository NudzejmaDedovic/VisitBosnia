using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitBosnia.Model
{
    public class Category 
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        //public virtual ICollection<Agency> Agencies { get; set; }
        //public virtual ICollection<Forum> Forums { get; set; }
        //public virtual ICollection<TouristFacility> TouristFacilities { get; set; }
    }
}
