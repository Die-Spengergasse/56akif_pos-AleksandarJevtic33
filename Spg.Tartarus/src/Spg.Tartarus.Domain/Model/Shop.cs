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
        public UrlAttribute Url { get; set; } = default!; // wie null steht am anfang in der instanz null forgiving 
        public string Name { get; set; } =string.Empty;
        public IPAddress IpAddress { get; set; } = default!;
        public int ReviewID { get; set; }
        public int ProductId { get; set; }
        public Address? Address { get; set; } = default!;
        public List<Review> _reviews = new();
        public IReadOnlyList<Review> Reviews => _reviews;
        public List<Product> _procucts = new();
        public IReadOnlyList<Product> Products => _procucts;
        

        //TODO Constructor
        protected Shop()
        {
    
        }

        public Shop(UrlAttribute url, string name, IPAddress ipAddress, int reviewID, int productId, Address? address)
        {
            Url = url;
            Name = name;
            IpAddress = ipAddress;
            ReviewID = reviewID;
            ProductId = productId;
            Address = address;
        }
        //TODO Backingfields
    }
}
