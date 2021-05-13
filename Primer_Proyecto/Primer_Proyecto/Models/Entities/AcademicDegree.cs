using System;
using System.Collections.Generic;

#nullable disable

namespace Primer_Proyecto.Models.Entities
{
    public partial class AcademicDegree
    {
        public AcademicDegree()
        {
            Professors = new HashSet<Professor>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Professor> Professors { get; set; }
    }
}
