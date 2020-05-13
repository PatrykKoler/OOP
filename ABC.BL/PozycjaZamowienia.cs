using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
    public class PozycjaZamowienia
    {
        private int produktId;

        public PozycjaZamowienia()
        {

        }
        public PozycjaZamowienia(int pozycjaZamoweniaId)
        {
            this.pozycjaZamoweniaId = pozycjaZamoweniaId;
        }

        public int pozycjaZamoweniaId { set; private get; }
        public int ilosc { get; set; }
        public int productId { get; set; }
        public Decimal? Price { get; set; }
        public PozycjaZamowienia Pobierz(int orderId)
        {
            return new PozycjaZamowienia();
        }
        public bool Zapisz()
        {
            return true;
        }
        public bool zwaliduj()
        {
            var poprawne = true;
            if (ilosc <= 0 || productId <=0 || Price == null)
            {
                poprawne = false;
            }            
            return poprawne;
        }
    }
}
