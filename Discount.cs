using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraly
{
    public class Discount
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public List<int>? Products { get; set; }
        public float Value { get; set; }
    }
}
