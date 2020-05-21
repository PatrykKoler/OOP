using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
   public  class ProductRepository
   {
        public Product Pobierz(int produktId)
        {
            Product produkt = new Product(produktId);

            if (produktId == 2)
            {
                produkt.productName = "Piłka";
                produkt.specification = "Piłka rozmiar 5, Mundial 2018 Rosja";
                produkt.actualPrice = 349.99M;
            }           
            return produkt;
        }
        public bool Zapisz()
        {
            return true;
        }
    }
}
