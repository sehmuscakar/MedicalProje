using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dtos.AdminDtos
{
  public class FooterListDto:AdminBaseDto
    {
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Twiter { get; set; }
        public string Facebook { get; set; }
        public string Instegram { get; set; }
        public string Linkedin { get; set; }
        public string Skype { get; set; }
    }
}
