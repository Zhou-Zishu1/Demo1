using System;
using System.Collections.Generic;

namespace CMS.BusinessLayer
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            // Перенесенный код из оригинального Product.cs
            return new Product();
        }

        public bool Save(Product product)
        {
            // Перенесенный код из оригинального Product.cs
            if (product.Validate())
            {
                return true;
            }
            return false;
        }
    }
}
