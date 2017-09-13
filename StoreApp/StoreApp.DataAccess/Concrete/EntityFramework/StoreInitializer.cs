using StoreApp.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.DataAccess.Concrete.EntityFramework
{
    public class StoreInitializer : DropCreateDatabaseAlways<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            List<Category> categories = new List<Category>()
            {
                new Category() { Name="category 1" },
                new Category() { Name="category 2" },
                new Category() { Name="category 3" },
                new Category() { Name="category 4" },
                new Category() { Name="category 5" },
                new Category() { Name="category 6" },
                new Category() { Name="category 7" }
            };

            foreach (var item in categories)
            {
                context.Categories.Add(item);
            }

            context.SaveChanges();


            List<Product> products = new List<Product>()
            {
                new Product() { Name="Product lorem 1", Description="description 1", Image="1.jpg", isHome=true,isApproved=true, isFeatured=true, Price=100, Stock=100, CategoryId=1,Date=DateTime.Now.AddDays(-10) },
                new Product() { Name="Product 2", Description="description lorem 1", Image="2.jpg", isHome=true,isApproved=true, isFeatured=true, Price=100, Stock=100, CategoryId=1,Date=DateTime.Now.AddDays(-10) },
                new Product() { Name="Product 3", Description="description 1", Image="3.jpg", isHome=false,isApproved=true, isFeatured=true, Price=100, Stock=100, CategoryId=1,Date=DateTime.Now.AddDays(-20) },
                new Product() { Name="Product 4", Description="description 1", Image="4.jpg", isHome=true,isApproved=true, isFeatured=false, Price=200, Stock=0, CategoryId=1 ,Date=DateTime.Now.AddDays(-22)},
                new Product() { Name="Product 5", Description="description 1", Image="1.jpg", isHome=true,isApproved=true, isFeatured=false, Price=300, Stock=100, CategoryId=1,Date=DateTime.Now.AddDays(-24) },
                new Product() { Name="Product lorem 6", Description="description 1", Image="2.jpg", isHome=false,isApproved=true, isFeatured=false, Price=300, Stock=100, CategoryId=2,Date=DateTime.Now.AddDays(-50) },
                new Product() { Name="Product 7", Description="description 1", Image="3.jpg", isHome=false,isApproved=true, isFeatured=true, Price=400, Stock=100, CategoryId=2,Date=DateTime.Now.AddDays(-1) },
                new Product() { Name="Product 8", Description="description lorem 1", Image="4.jpg", isHome=true,isApproved=true, isFeatured=false, Price=500, Stock=100, CategoryId=2 ,Date=DateTime.Now.AddDays(-40)},
                new Product() { Name="Product 9", Description="description 1", Image="1.jpg", isHome=true,isApproved=false, isFeatured=true, Price=100, Stock=100, CategoryId=2 ,Date=DateTime.Now.AddDays(-10)},
                new Product() { Name="Product 10", Description="description 1", Image="2.jpg", isHome=true,isApproved=false, isFeatured=false, Price=100, Stock=0, CategoryId=2,Date=DateTime.Now.AddDays(-42) },
                new Product() { Name="Product 11", Description="description lorem 1", Image="3.jpg", isHome=true,isApproved=true, isFeatured=false, Price=100, Stock=100, CategoryId=3,Date=DateTime.Now.AddDays(-13) },
                new Product() { Name="Product 12", Description="description 1", Image="4.jpg", isHome=true,isApproved=true, isFeatured=true, Price=100, Stock=0, CategoryId=3 ,Date=DateTime.Now.AddDays(-15)},
                new Product() { Name="Product 13", Description="description 1", Image="1.jpg", isHome=true,isApproved=false, isFeatured=true, Price=100, Stock=100, CategoryId=4,Date=DateTime.Now.AddDays(-78) },
                new Product() { Name="Product 15", Description="description 1", Image="2.jpg", isHome=true,isApproved=true, isFeatured=true, Price=100, Stock=0, CategoryId=4,Date=DateTime.Now.AddDays(-6) },
                new Product() { Name="Product 16", Description="description 1", Image="3.jpg", isHome=false,isApproved=true, isFeatured=true, Price=100, Stock=0, CategoryId=4,Date=DateTime.Now.AddDays(-7) },
                new Product() { Name="Product 17", Description="description 1", Image="4.jpg", isHome=true,isApproved=true, isFeatured=true, Price=100, Stock=100, CategoryId=4,Date=DateTime.Now.AddDays(-8) },
                new Product() { Name="Product 18", Description="description 1", Image="1.jpg", isHome=false,isApproved=true, isFeatured=true, Price=100, Stock=100, CategoryId=4,Date=DateTime.Now.AddDays(-9) },
                new Product() { Name="Product 19", Description="description 1", Image="2.jpg", isHome=true,isApproved=false, isFeatured=true, Price=100, Stock=100, CategoryId=5,Date=DateTime.Now.AddDays(-17) },
                new Product() { Name="Product 20", Description="description 1", Image="3.jpg", isHome=true,isApproved=false, isFeatured=true, Price=100, Stock=100, CategoryId=5,Date=DateTime.Now.AddDays(-19) },
                new Product() { Name="Product 21", Description="description 1", Image="4.jpg", isHome=true,isApproved=true, isFeatured=true, Price=100, Stock=100, CategoryId=5,Date=DateTime.Now.AddDays(-25) },
                new Product() { Name="Product 21", Description="description 1", Image="1.jpg", isHome=true,isApproved=false, isFeatured=true, Price=100, Stock=100, CategoryId=5,Date=DateTime.Now.AddDays(-30) }
            };

            foreach (var item in products)
            {
                context.Products.Add(item);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
