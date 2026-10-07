using System;

namespace CMS.BusinessLayer
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        public bool Save(Order order)
        {
            if (order.Validate())
            {
                return true;
            }
            return false;
        }
    }
}
