using System;
using System.Collections.Generic;

#nullable disable

namespace Primer_Proyecto.Models.Entities
{
    public partial class SocialNetworksCatalog
    {
        public SocialNetworksCatalog()
        {
            SocialNetworksStudents = new HashSet<SocialNetworksStudent>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<SocialNetworksStudent> SocialNetworksStudents { get; set; }
    }
}
