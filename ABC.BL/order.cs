using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
    public class order
    {
        public order()
        {

        }
        public order(int orderId)
        {
            this.orderId = orderId;
        }
        public int orderId { get; private set; }
        public DateTimeOffset? dateOrder { get; set; }

        public order Pobierz(int orderId)
        {
            return new order();
        }
        public bool Zapisz()
        {
            return true;
        }
        public bool zwaliduj()
        {
            var poprawne = true;
            if (dateOrder == null)
            {
                poprawne = false;
            }
            return poprawne;
        }
    }
}
