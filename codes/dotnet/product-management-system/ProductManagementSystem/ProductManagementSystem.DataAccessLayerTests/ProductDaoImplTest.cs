using NUnit.Framework;
using ProductManagementSystem.DataAccessLayer.Implementation;
using ProductManagementSystem.BusinessEntities;
using System.Collections.Generic;

namespace ProductManagementSystem.DataAccessLayerTests
{
    public class ProductDaoImplTest
    {
        ProductDaoImpl productDao;
        [SetUp]
        public void Setup()
        {
            productDao = new ProductDaoImpl();
        }

        [Test]
        public void GetAllRecordsTest()
        {            
            //variable declared with var keyword is known as implicitly typed local variable (actualRecords)
            var actualRecords = productDao.GetAllRecords();
            var expectedRecords = new List<Product>
            {
                new Product{ ProductId=100, ProductName="dell xps", CategoryId=1, Price=10000.00M, Description="new product from dell", ImagePath="NA", ReleaseDate=new System.DateTime(2022,1,1), StarRating=4.5M }
            };
            CollectionAssert.AreEqual(expectedRecords, actualRecords);
            //Product p1= expectedRecords[0];
            //Product p2= actualRecords[0];
            //p1.Equals(p2)
            //Assert.AreEqual(expectedRecords[0].ProductId, actualRecords[0].ProductId);
        }
    }
}