using System;
using System.Collections.Generic;

#nullable disable

namespace Primer_Proyecto.Models.Entities
{
    public partial class Professor
    {
        public Professor()
        {
            Appointments = new HashSet<Appointment>();
            PrivateMessages = new HashSet<PrivateMessage>();
            ProfessorCourses = new HashSet<ProfessorCourse>();
            PublicConsultations = new HashSet<PublicConsultation>();
            RepliesPrivateMessages = new HashSet<RepliesPrivateMessage>();
            RepliesPublicConsultations = new HashSet<RepliesPublicConsultation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public int? AcademicDegreeId { get; set; }
        public string Image { get; set; }
        public int? LocationId { get; set; }

        public virtual AcademicDegree AcademicDegree { get; set; }
        public virtual User IdNavigation { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<PrivateMessage> PrivateMessages { get; set; }
        public virtual ICollection<ProfessorCourse> ProfessorCourses { get; set; }
        public virtual ICollection<PublicConsultation> PublicConsultations { get; set; }
        public virtual ICollection<RepliesPrivateMessage> RepliesPrivateMessages { get; set; }
        public virtual ICollection<RepliesPublicConsultation> RepliesPublicConsultations { get; set; }
    }
}
