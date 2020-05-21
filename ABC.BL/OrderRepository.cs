using System;

namespace ABC.BL
{
    public class OrderRepository
    {
        public order Pobierz(int orderId)
        {
            order order = new order(orderId);

            if (orderId == 10)            
                order.dateOrder = new DateTimeOffset(2020, 5, 21, 10, 00, 00, new TimeSpan(7, 0, 0));
            
            return order;
        }
        public bool Zapisz()
        {
            return true;
        }
    }
}
