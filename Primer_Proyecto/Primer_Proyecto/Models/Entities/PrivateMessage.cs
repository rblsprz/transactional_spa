using System;
using System.Collections.Generic;

#nullable disable

namespace Primer_Proyecto.Models.Entities
{
    public partial class PrivateMessage
    {
        public PrivateMessage()
        {
            RepliesPrivateMessages = new HashSet<RepliesPrivateMessage>();
        }

        public int Id { get; set; }
        public int? CourseId { get; set; }
        public int? StudentId { get; set; }
        public string DateTime { get; set; }
        public string Motive { get; set; }
        public int? ProfessorId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Professor Professor { get; set; }
        public virtual Student Student { get; set; }
        public virtual ICollection<RepliesPrivateMessage> RepliesPrivateMessages { get; set; }
    }
}
