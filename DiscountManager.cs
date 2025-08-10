using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraly
{
    internal class DiscountManager
    {
         public List<Discount> Discounts{  get; set; } 
         public List<Discount> ShowDiscounts()
        {
            return Discounts;
        }
    }
}
