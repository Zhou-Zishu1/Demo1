using System;

namespace CMS.BusinessLayer
{
    public class OrderItemRepository
    {
        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        public bool Save(OrderItem orderItem)
        {
            if (orderItem.Validate())
            {
                return true;
            }
            return false;
        }
    }
}
