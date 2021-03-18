using StudentDataAccess;
using StudentEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer
{
    public class ProductComponent : IProductComponent
    {
        private readonly IProductAccess _productAccess;
        public ProductComponent(IProductAccess productAccess)
        {
            _productAccess = productAccess;
        }
        public int AddProduct(Product model)
        {
            return _productAccess.AddProduct(model);
        }

        public int DeleteProduct(int id)
        {
            return _productAccess.DeleteProduct(id);
            
        }

        public int EditProdcut(int id,Product model)
        {
            return _productAccess.EditProdcut(id, model);
        }
        public Product GetSingleProduct(int id)
        {
            return _productAccess.GetSingleProduct(id);
        }

        public List<Product> GetProducts()
        {
            return _productAccess.GetProducts();
        }
    }
}
