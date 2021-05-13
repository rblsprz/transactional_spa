using System;
using System.Collections.Generic;

#nullable disable

namespace Primer_Proyecto.Models.Entities
{
    public partial class Appointment
    {
        public int Id { get; set; }
        public int? CourseId { get; set; }
        public int? StudentId { get; set; }
        public int? ProfessorId { get; set; }
        public string Motive { get; set; }
        public int Accepted { get; set; }
        public DateTime? DateTime { get; set; }

        public virtual Course Course { get; set; }
        public virtual Professor Professor { get; set; }
        public virtual Student Student { get; set; }
    }
}
