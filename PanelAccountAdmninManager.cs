using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraly
{
    public class PanelAccountAdmninManager
    {
        public  List<Discount> Discounts { get; set; }
        public List<Product> Products { get; set; }

        public void AddNewDiscount(Discount discount)
        {
            Discounts.Add(discount);
        }
        public void AddNewProduct(Product product)
        {
            Products.Add(product);
        }
    }
}
