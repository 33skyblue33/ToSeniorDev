﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraly
{
    public class Account
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public bool IsAdmin { get; set; }
        public List<Product>? FavouriteProduct { get; set; }

    }
}
