﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class Restaurant
    {
        public Restaurant()
        {
            Address = new Address();
        }

        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
    }
}
