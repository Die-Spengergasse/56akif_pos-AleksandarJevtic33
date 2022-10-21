﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Tartarus.Domain.Model
{
    public class Shop
    {
        public UrlAttribute Url { get; set; } = default!; // wie null steht am anfang in der instanz
        public string Name { get; set; } =string.Empty;
        public IPAddress IpAddress { get; set; } = default!;
        public List<Review> Reviews { get; set; } = new();
        public List<Product> Products { get; set; } = new();
    }
}
