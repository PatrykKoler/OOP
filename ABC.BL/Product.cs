using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
    public class Product
    {
        public Product()
        {
            
        }
        public Product(int productId)
        {
            this.productId = productId;
        }

        public int productId { get; private set; }
        public Decimal? actualPrice { get; set; }
        public string specification { get; set; }
        public string productName { get; set; }

        public Product Pobierz(int produktId)
        {
            return new Product();
        }
        public bool Zapisz()
        {
            return true;
        }
        public bool zwaliduj()
        {
            var poprawne = true;
            if (string.IsNullOrWhiteSpace(productName))
            {
                poprawne = false;
            }            
            return poprawne;
        }
    }
}
