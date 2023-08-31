using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dtos.AdminDtos
{
    public class CountListDto:AdminBaseDto
    {
        public int Doctors { get; set; }// doktorlar
        public int Departments { get; set; }//bölümler
        public int ReserarchLabs { get; set; }//Araştırma laboratuvarları
        public int Awards { get; set; }//ödüler

    }
}
