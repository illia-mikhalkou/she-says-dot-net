using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Achievement
    {
        public int Id { get; set; }
        public string Descripotion { get; set; }
        public string Url { get; set; }
        public decimal Cost { get; set; }
    }
}
