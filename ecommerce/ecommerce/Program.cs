using System;
using System.Collections.Generic;
using System.Text;


namespace ecommerce
{
    class Product
    {
        public string ProdName { get; set; }
        public ProductType Category { get; set; }
    }

    enum ProductType : int
    {
        Electronics = 1,
        Indoor,
        Outdoor,
        Tools,
        Miscellaneous
    }
}
