﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BuyerModel
    {
        public int id { get; set; }
        public Nullable<int> uid { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
    }
}