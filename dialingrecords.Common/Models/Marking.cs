﻿using System;

namespace dialingrecords.Common.Models
{
    public class Marking
    {
        public int IdEmployee { get; set; }
        public DateTime Date { get; set; }
        public int Type { get; set; }
        public bool Consolidated { get; set; }
    }
}
