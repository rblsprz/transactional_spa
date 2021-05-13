using System;
using System.Collections.Generic;

#nullable disable

namespace Primer_Proyecto.Models.Entities
{
    public partial class User
    {
        public User()
        {
            ProfessorCourseCreatedByNavigations = new HashSet<ProfessorCourse>();
            ProfessorCourseUpdatedByNavigations = new HashSet<ProfessorCourse>();
            ProvinceCreatedByNavigations = new HashSet<Province>();
            ProvinceUpdatedByNavigations = new HashSet<Province>();
            PublicConsultationCreatedByNavigations = new HashSet<PublicConsultation>();
            PublicConsultationUpdatedByNavigations = new HashSet<PublicConsultation>();
            SocialNetworksStudentCreatedByNavigations = new HashSet<SocialNetworksStudent>();
            SocialNetworksStudentUpdatedByNavigations = new HashSet<SocialNetworksStudent>();
            StudentCourseCreatedByNavigations = new HashSet<StudentCourse>();
            StudentCourseUpdatedByNavigations = new HashSet<StudentCourse>();
            StudentCreatedByNavigations = new HashSet<Student>();
            StudentUpdatedByNavigations = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int IsAdministrator { get; set; }
        public string Status { get; set; }

        public virtual Professor Professor { get; set; }
        public virtual Student StudentIdNavigation { get; set; }
        public virtual ICollection<ProfessorCourse> ProfessorCourseCreatedByNavigations { get; set; }
        public virtual ICollection<ProfessorCourse> ProfessorCourseUpdatedByNavigations { get; set; }
        public virtual ICollection<Province> ProvinceCreatedByNavigations { get; set; }
        public virtual ICollection<Province> ProvinceUpdatedByNavigations { get; set; }
        public virtual ICollection<PublicConsultation> PublicConsultationCreatedByNavigations { get; set; }
        public virtual ICollection<PublicConsultation> PublicConsultationUpdatedByNavigations { get; set; }
        public virtual ICollection<SocialNetworksStudent> SocialNetworksStudentCreatedByNavigations { get; set; }
        public virtual ICollection<SocialNetworksStudent> SocialNetworksStudentUpdatedByNavigations { get; set; }
        public virtual ICollection<StudentCourse> StudentCourseCreatedByNavigations { get; set; }
        public virtual ICollection<StudentCourse> StudentCourseUpdatedByNavigations { get; set; }
        public virtual ICollection<Student> StudentCreatedByNavigations { get; set; }
        public virtual ICollection<Student> StudentUpdatedByNavigations { get; set; }
    }
}
