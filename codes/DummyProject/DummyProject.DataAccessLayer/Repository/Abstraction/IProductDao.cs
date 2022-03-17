using DummyProject.BusinessModels;
using System.Collections.Generic;

namespace DummyProject.DataAccessLayer.Repository.Abstraction
{
    public interface IProductDao
    {
        int Add(ProductModel productModel);
        int Delete(int id);
        int Udate(int id);
        List<ProductModel> GetAll();
        ProductModel Get(int id);
    }
}
