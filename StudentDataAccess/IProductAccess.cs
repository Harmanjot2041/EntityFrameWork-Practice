using System;
using System.Collections.Generic;
using System.Text;
using StudentEntities.Entities;

namespace StudentDataAccess
{
    public interface IProductAccess
    {
        List<StudentEntities.Entities.Product> GetProducts();
        int AddProduct(StudentEntities.Entities.Product model);
        int DeleteProduct(int id);
        int EditProdcut(int id, StudentEntities.Entities.Product model);
        Product GetSingleProduct(int id);
    }
}
