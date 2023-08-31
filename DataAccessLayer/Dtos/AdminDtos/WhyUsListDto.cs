using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dtos.AdminDtos
{
   public class WhyUsListDto:AdminBaseDto
    {
        public string Header { get; set; }
        public string HeaderDescription { get; set; }
        public string Title1 { get; set; }
        public string TitleDecription1 { get; set; }
        public string Title2 { get; set; }
        public string TitleDecription2 { get; set; }
        public string Title3 { get; set; }
        public string TitleDecription3 { get; set; }
    }
}
