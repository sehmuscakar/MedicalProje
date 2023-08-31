using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dtos.AdminDtos
{
  public class QuestionListDto:AdminBaseDto
    {
        public int TabIndex { get; set; }// bu varlık herbirinin index id sini bbelitmek için sunum katmanında herbinie tıklanınca ayrı ayrı açılsın diye
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
