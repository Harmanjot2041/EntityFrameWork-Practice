using StudentEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentDataAccess
{
    public class ProductAccess : IProductAccess
    {
        private readonly StudentEntities.Entities.EmployeeDbCOntext _context;
        public ProductAccess(StudentEntities.Entities.EmployeeDbCOntext context)
        {
            _context = context;
        }
        public int AddProduct(Product model)
        {
            //Product temp = new Product();
            //temp.Catagory = model.Catagory;
            //temp.ExpiryDate = model.ExpiryDate;
            //temp.NoOfProducts = model.NoOfProducts;
            //temp.ProductColor = model.ProductColor;
            //temp.ProductDiscription = model.ProductDiscription;
            //temp.ProductName = model.ProductName;
            //temp.ProductPrice = temp.ProductPrice;
            //temp.ShippingAllowed = temp.ShippingAllowed;
            _context.Products.Add(model);
            
            return _context.SaveChanges();
        }

        public int DeleteProduct(int id)
        {
            Product temp = _context.Products.FirstOrDefault(products => products.ProductId == id);
            _context.Products.Remove(temp);
            return _context.SaveChanges();
        }

        public int EditProdcut(int id,Product model)
        {
            Product temp = _context.Products.FirstOrDefault(products => products.ProductId == id);
            temp.Catagory = model.Catagory;
            temp.ExpiryDate = model.ExpiryDate;
            temp.NoOfProducts = model.NoOfProducts;
            temp.ProductColor = model.ProductColor;
            temp.ProductDiscription = model.ProductDiscription;
            temp.ProductName = model.ProductName;
            temp.ProductPrice = temp.ProductPrice;
            temp.ShippingAllowed = temp.ShippingAllowed;
            _context.Products.Update(temp);
            return _context.SaveChanges();



            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetSingleProduct(int id)
        {
            return _context.Products.FirstOrDefault(products => products.ProductId == id);
        }
    }
}
