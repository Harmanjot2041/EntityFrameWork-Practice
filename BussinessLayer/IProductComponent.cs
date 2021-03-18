using System;
using System.Collections.Generic;
using System.Text;
using StudentEntities;

namespace BussinessLayer
{
    public interface IProductComponent
    {
        List<StudentEntities.Entities.Product> GetProducts();
        int AddProduct(StudentEntities.Entities.Product model);
        int DeleteProduct(int id);
        int EditProdcut(int id,StudentEntities.Entities.Product model);
        StudentEntities.Entities.Product GetSingleProduct(int id);
    }
}
