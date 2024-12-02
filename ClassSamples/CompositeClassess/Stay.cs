﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeClassess
{
    public class Stay
    {
        public DateTime DateIN { get; set; }
        public DateTime DateOut { get; set; }

        public Stay()
        {
            DateIN = DateTime.Today;
            DateOut = DateTime.Today.AddDays(1);
        }

        public Stay(DateTime datein, DateTime dateout)
        {
            DateIN = datein;
            DateOut = dateout;
        }
    }
}
