using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
   public class Question:BaseEntity // sıkça sorulan sorular
    {

        public int TabIndex { get; set; }// bu varlık herbirinin index id sini bbelitmek için sunum katmanında herbinie tıklanınca ayrı ayrı açılsın diye
        public string Title { get; set; }
        public string Description { get; set; }


    }
}
