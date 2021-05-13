using System;
using System.Collections.Generic;

#nullable disable

namespace Primer_Proyecto.Models.Entities
{
    public partial class Student
    {
        public Student()
        {
            Appointments = new HashSet<Appointment>();
            PrivateMessages = new HashSet<PrivateMessage>();
            PublicConsultations = new HashSet<PublicConsultation>();
            RepliesPrivateMessages = new HashSet<RepliesPrivateMessage>();
            RepliesPublicConsultations = new HashSet<RepliesPublicConsultation>();
            SocialNetworksStudents = new HashSet<SocialNetworksStudent>();
            StudentCourses = new HashSet<StudentCourse>();
        }

        public int Id { get; set; }
        public string StudentCard { get; set; }
        public string StudentName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public string Mail { get; set; }
        public string Image { get; set; }
        public int? LocationId { get; set; }
        public string RegistrationStatus { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreateAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual User CreatedByNavigation { get; set; }
        public virtual User IdNavigation { get; set; }
        public virtual Location Location { get; set; }
        public virtual User UpdatedByNavigation { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<PrivateMessage> PrivateMessages { get; set; }
        public virtual ICollection<PublicConsultation> PublicConsultations { get; set; }
        public virtual ICollection<RepliesPrivateMessage> RepliesPrivateMessages { get; set; }
        public virtual ICollection<RepliesPublicConsultation> RepliesPublicConsultations { get; set; }
        public virtual ICollection<SocialNetworksStudent> SocialNetworksStudents { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
