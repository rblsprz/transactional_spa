using System;
using System.Collections.Generic;

#nullable disable

namespace Primer_Proyecto.Models.Entities
{
    public partial class Canton
    {
        public Canton()
        {
            Districts = new HashSet<District>();
            Locations = new HashSet<Location>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ProvinceId { get; set; }

        public virtual Province Province { get; set; }
        public virtual ICollection<District> Districts { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
    }
}
