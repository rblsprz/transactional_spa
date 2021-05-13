using System;
using System.Collections.Generic;

#nullable disable

namespace Primer_Proyecto.Models.Entities
{
    public partial class Course
    {
        public Course()
        {
            Appointments = new HashSet<Appointment>();
            PrivateMessages = new HashSet<PrivateMessage>();
            ProfessorCourses = new HashSet<ProfessorCourse>();
            PublicConsultations = new HashSet<PublicConsultation>();
            StudentCourses = new HashSet<StudentCourse>();
        }

        public int Id { get; set; }
        public string Initials { get; set; }
        public string Name { get; set; }
        public int IsActive { get; set; }
        public int Credits { get; set; }
        public int Cycle { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<PrivateMessage> PrivateMessages { get; set; }
        public virtual ICollection<ProfessorCourse> ProfessorCourses { get; set; }
        public virtual ICollection<PublicConsultation> PublicConsultations { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
