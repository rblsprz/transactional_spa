using System;
using System.Collections.Generic;

#nullable disable

namespace Primer_Proyecto.Models.Entities
{
    public partial class SocialNetworksStudent
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public string Url { get; set; }
        public int? SocialNetworksNameId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreateAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual User CreatedByNavigation { get; set; }
        public virtual SocialNetworksCatalog SocialNetworksName { get; set; }
        public virtual Student Student { get; set; }
        public virtual User UpdatedByNavigation { get; set; }
    }
}
