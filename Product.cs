using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraly
{
    public class Product
    {
        public long Id {  get; set; }
        public string? Name {  get; set; }
        public float Price { get; set; }
        public int Popularity {  get; set; }
    }
}
