﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viktor.Models
{
    public class Measure : BaseEntity
    {
        public decimal Value { get; set; }
        public ICollection<Sranec> Sranecs { get; set; }
    }
}
