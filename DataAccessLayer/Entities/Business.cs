using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
  public class Business:BaseEntity
    {
        public string About { get; set; }
        public string AboutDecription { get; set; }
        public string Mission { get; set; }
        public string MissionDescription { get; set; }
        public string Vision { get; set; }
        public string VisionDescription { get; set; }
        public string ImageUrl { get; set; }

    }
}
