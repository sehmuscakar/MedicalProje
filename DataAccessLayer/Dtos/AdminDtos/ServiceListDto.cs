﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dtos.AdminDtos
{
    public class ServiceListDto:AdminBaseDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string İcon { get; set; }

    }
}
