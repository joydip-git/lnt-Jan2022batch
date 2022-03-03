using NUnit.Framework;
using ProductManagementSystem.BusinessEntities;
using ProductManagementSystem.DataAccessLayer.Implementation;
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

        [TearDown]
        public void Clear()
        {
            productDao = null;
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

        [Test]
        public void InsertRecordTest()
        {
            //object initializer
            Product sample = new Product
            {
                ProductName = "hp probook",
                Price = 67000.00M,
                CategoryId = 1,
                Description = "new product from hp",
                ImagePath = "NA",
                StarRating = 4,
                ReleaseDate = new System.DateTime(2022, 1, 12)
            };
            var actualStatus = productDao.InsertRecord(sample);
            Assert.AreEqual(true, actualStatus);
        }

        [Test]
        public void UpdateRecordTest()
        {
            //object initializer
            Product sample = new Product
            {
                ProductId = 102,
                ProductName = "one plus 9",
                Price = 70000.00M,
                CategoryId = 2,
                Description = "new mobile from one plus",
                ImagePath = "NA",
                StarRating = 4.5M,
                ReleaseDate = new System.DateTime(2022, 1, 15)
            };
            var actualStatus = productDao.UpdateRecord(sample);
            Assert.AreEqual(true, actualStatus);
        }

        [Test]
        public void GetARecordByIdTest()
        {
            //variable declared with var keyword is known as implicitly typed local variable (actualRecords)
            var actualRecord = productDao.GetARecordById(100);
            var expectedRecord = new Product { ProductId = 100, ProductName = "dell xps", CategoryId = 1, Price = 10000.00M, Description = "new product from dell", ImagePath = "NA", ReleaseDate = new System.DateTime(2022, 1, 1), StarRating = 4.5M };
            Assert.AreEqual(expectedRecord, actualRecord);
            //Product p1= expectedRecords[0];
            //Product p2= actualRecords[0];
            //p1.Equals(p2)
            //Assert.AreEqual(expectedRecords[0].ProductId, actualRecords[0].ProductId);
        }
    }
}