using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoAPI.Models.Entities
{
    public partial class News
    {
        public News()
        {
            Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string DateTime { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
