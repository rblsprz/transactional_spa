using System;
using System.Collections.Generic;

namespace ProyectoAPI.Models
{
    public partial class News
    {
        public News()
        {
            Comment = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string DateTime { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Comment> Comment { get; set; }
    }
}
