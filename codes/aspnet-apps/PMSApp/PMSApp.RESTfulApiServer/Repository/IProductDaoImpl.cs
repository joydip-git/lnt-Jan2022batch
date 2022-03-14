using PMSApp.RESTfulApiServer.Models;
using System.Collections.Generic;

namespace PMSApp.RESTfulApiServer.Repository
{
    public interface IProductDaoImpl
    {
        List<Product> FetchAll();
        Product FetchOne(int id);
        int AddOne(Product product);
        List<Product> Filter(string productName);
    }
}
