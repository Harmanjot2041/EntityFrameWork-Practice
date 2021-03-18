using System;
using System.Collections.Generic;



namespace StudentEntities.Entities
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDiscription { get; set; }
        public string ProductColor { get; set; }
        public long ProductPrice { get; set; }
        public long NoOfProducts { get; set; }
        public string Catagory { get; set; }
        public bool ShippingAllowed { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
