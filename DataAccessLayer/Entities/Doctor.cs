using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Doctor:BaseEntity
    {
        public string ImageUrl { get; set; }
        public string FullName { get; set; }
        public string Branch { get; set; }
        public string Description { get; set; }
        public string SocialMedia1 { get; set; }
        public string SocialMedia2 { get; set; }
        public string SocialMedia3 { get; set; }
        public string SocialMedia4 { get; set; }

    }
}
