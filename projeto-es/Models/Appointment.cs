﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_es.Models
{
    class Appointment
    {
        public uint id { get; set; }
        public DateTime date { get; set; }
        public string description { get; set; }
        public DateTime scheduled_time { get; set; }
        public uint StaffAccountId { get; set; }
        public uint ClientAccountId { get; set; }
    }
}
