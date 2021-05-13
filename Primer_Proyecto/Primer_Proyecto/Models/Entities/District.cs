using System;
using System.Collections.Generic;

#nullable disable

namespace Primer_Proyecto.Models.Entities
{
    public partial class District
    {
        public District()
        {
            Locations = new HashSet<Location>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CantonId { get; set; }

        public virtual Canton Canton { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
    }
}
