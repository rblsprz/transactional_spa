using System;
using System.Collections.Generic;

#nullable disable

namespace Primer_Proyecto.Models.Entities
{
    public partial class StudentCourse
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreateAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Course Course { get; set; }
        public virtual User CreatedByNavigation { get; set; }
        public virtual Student Student { get; set; }
        public virtual User UpdatedByNavigation { get; set; }
    }
}
