using System;
using System.Collections.Generic;

#nullable disable

namespace Primer_Proyecto.Models.Entities
{
    public partial class PublicConsultation
    {
        public PublicConsultation()
        {
            RepliesPublicConsultations = new HashSet<RepliesPublicConsultation>();
        }

        public int Id { get; set; }
        public int? CourseId { get; set; }
        public int? StudentId { get; set; }
        public string DateTime { get; set; }
        public string Motive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreateAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? ProfessorId { get; set; }

        public virtual Course Course { get; set; }
        public virtual User CreatedByNavigation { get; set; }
        public virtual Professor Professor { get; set; }
        public virtual Student Student { get; set; }
        public virtual User UpdatedByNavigation { get; set; }
        public virtual ICollection<RepliesPublicConsultation> RepliesPublicConsultations { get; set; }
    }
}
