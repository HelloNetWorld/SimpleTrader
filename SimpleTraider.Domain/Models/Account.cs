using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTraider.Domain.Models
{
    public class Account
    {
        public int Id { get; set; }
        public User AccountHandler { get; set; }
        public double Balance { get; set; }
        public IEnumerable<AssetTransaction> AssetTransactions { get; set; }
    }
}
