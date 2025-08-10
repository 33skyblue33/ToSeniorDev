using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Libraly
{
    public class ProductManager
    {
        public List<Product> Products { get; set; }
        public List<Product> ShowProducts(int pageIndex, int pageLength)
        {
            int start = pageIndex * pageLength;
            return Products.Take(new Range(start, start+pageLength-1)).ToList();

        }
        public List<Product> SortedListByPrice(int pageIndex, int pageLength)
        {
            int start = pageIndex * pageLength;
            return Products.OrderBy(p => p.Price).Take(new Range(start, start+pageLength-1)).ToList();
        }
        public List<Product> SortedListByPopularity(int pageIndex, int pageLength)
        {
            int start = pageIndex * pageLength;
            return Products.OrderByDescending(p=>p.Popularity).ToList();
        }
    }
}
