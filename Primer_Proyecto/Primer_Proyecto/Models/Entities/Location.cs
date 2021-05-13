using System;
using System.Collections.Generic;

#nullable disable

namespace Primer_Proyecto.Models.Entities
{
    public partial class Location
    {
        public Location()
        {
            Professors = new HashSet<Professor>();
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public int? ProvinceId { get; set; }
        public int? CantonId { get; set; }
        public int? DistrictId { get; set; }

        public virtual Canton Canton { get; set; }
        public virtual District District { get; set; }
        public virtual Province Province { get; set; }
        public virtual ICollection<Professor> Professors { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
