using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTraider.Domain.Models
{
    public class Stock
    {
        public string Symbol { get; set; }
        public double PricePerShare { get; set; }
    }
}
