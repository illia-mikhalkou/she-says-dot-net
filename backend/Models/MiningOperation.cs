using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class MiningOperation
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Origin { get; set; }
    }
}
