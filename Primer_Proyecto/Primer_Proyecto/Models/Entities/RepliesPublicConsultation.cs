using System;
using System.Collections.Generic;

#nullable disable

namespace Primer_Proyecto.Models.Entities
{
    public partial class RepliesPublicConsultation
    {
        public int Id { get; set; }
        public int? PublicConsultationId { get; set; }
        public int? StudentId { get; set; }
        public int? ProfessorId { get; set; }
        public string DateTime { get; set; }
        public string Motive { get; set; }

        public virtual Professor Professor { get; set; }
        public virtual PublicConsultation PublicConsultation { get; set; }
        public virtual Student Student { get; set; }
    }
}
