using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Booking:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public DateTime Tarih { get; set; }
        public string Branch { get; set; }
        public string Doctor { get; set; }
        public string Message { get; set; }

        public int RowOrder { get; set; }
    }
}
