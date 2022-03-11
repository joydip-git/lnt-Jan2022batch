using System;
using EFDemo.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.IO;

namespace EFDemo
{
    class A : IDisposable
    {
        //SqlConnection con;
        StreamReader reader;

        public void Dispose()
        {
            //clean up unmanaged resources like file, database connection etc.
            reader.Close();
            Console.WriteLine("reader disposed");
        }

        public void M1()
        {
            reader = new StreamReader(@"E:/LnT-Training/lnt-Jan2022batch/codes/aspnet-apps/EFDemo/EFDemo/notes.txt");
            //reader.Close();
        }
    }
    class Program
    {
        static void AddRecord()
        {
            using (var db = new appdbContext())
            {
                var allRecords = db.Products;

                allRecords.Add(new Products { Productid = 4, Productname = "Lenovo Thinkpad", Price = 54000, Description = "new laptop from Lenovo" });
                int result = db.SaveChanges();
                Console.WriteLine($"{result} record added successfully");
                //db.Dispose();
            }
        }
        static void UpdateRecord()
        {
            using (var db = new appdbContext())
            {
                var allRecords = db.Products;

                Products found = allRecords.Where(p => p.Productid == 4).First<Products>();
                found.Price = 55000;
                int updateResult = db.SaveChanges();
                Console.WriteLine($"{updateResult} record updated successfully");
            }
        }
        static void DeleteRecord()
        {
            using (var db = new appdbContext())
            {
                var allRecords = db.Products;

                Products found = allRecords.Where(p => p.Productid == 4).First<Products>();
                allRecords.Remove(found);
                int deleteResult = db.SaveChanges();
                Console.WriteLine($"{deleteResult} record deleted successfully");
            }
        }
        static void ShowRecords()
        {
            using (var db = new appdbContext())
            {
                var allRecords = db.Products;

                allRecords
                    .ToList<Products>()
                    .ForEach(p => Console.WriteLine(p.Productname));
            }
        }
        static void Main()
        {
            //ShowRecords();
            //select price from products where productid=4
            //command.ComandText="select price from products where productid=4";
            //Nullable<decimal> d = (decimal)command.ExecuteScalar();
            //NULL
            //decimal d = null;
            //string str = null;

            //nullable type
            //d is NOT a variable of type decimal
            //means d can store either null or a decimal value

            //Nullable<decimal> d = null;
            //or
            decimal? d = null;
            //d = 12.34M;            
            if (d.HasValue)
            {
                Console.WriteLine(d.Value);
            }
            else
            {
                Console.WriteLine("NULL");
            }
            int? x = null;
            x = 20;
            Console.WriteLine(x.Value);

            DateTime? dt = null;
            dt = new DateTime(2022, 3, 11);
            Console.WriteLine(dt.Value);

            char? ch = null;
            ch = 'a';
            Console.WriteLine(ch.Value);

            using (A obj = new A())
            {
                obj.M1();
                //you can't nullfy any object in using block
                //obj = null;
            }            
        }
    }
}