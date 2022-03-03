using ProductManagementSystem.BusinessEntities;
using System.Collections.Generic;

namespace ProductManagementSystem.DataAccessLayer.Contract
{
    public interface IProductDaoManager : IDaoManager<Product>
    {
        List<Product> GetPoductsByName(string name);
        List<Product> GetProductsByCategoryId(int categoryId);
    }
}
