using Microsoft.EntityFrameworkCore;
using Spg.Tartarus.Domain.Model;
using Spg.Tartarus.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Tartarus.Domain.Test
{
    public class ProductTest 
    {

        private TartarusContext GenerateDb()
        {
            DbContextOptionsBuilder optionsbuilder = new DbContextOptionsBuilder();
            optionsbuilder.UseSqlite("Data Source = Tartarus.db");
            TartarusContext db = new TartarusContext(optionsbuilder.Options);

            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            return db;

        }

        [Fact]
        public void Seeddb()
        {
            TartarusContext db = GenerateDb();
            db.Seed();
            Assert.True(true);
        }
        [Fact]
        public void Product_Add_OneEntity_SuccessTest()
        {
            // AAA
            // 1. Arange
            TartarusContext db = GenerateDb();
            Product newProduct = new Product("Name", "Description", 200,null);
            // 2. Act
            db.Products.Add(newProduct);
            db.SaveChanges();
            // 3. Assert 
            Assert.Equal(1,db.Products.Count());
        }
        [Fact]
        public void Shop_Add_OneEntity_SuccessTest()
        {
            // AAA
            // 1. Arange
            TartarusContext db = GenerateDb();
            Shop newShop = new Shop("shop.com", "Shop", "1.1.1.1");
            // 2. Act
            db.Shops.Add(newShop);
            db.SaveChanges();
            // 3. Assert 
            Assert.Equal(1, db.Shops.Count());
        }
        [Fact]
        public void User_Add_One_Entity()
        {
            TartarusContext db = GenerateDb();
            User newUser = new User(100,Genders.Male,"Alex","Wer","email", new DateTime(1990,10,19), new DateTime(2018,12,18));

            db.Users.Add(newUser);
            db.SaveChanges();

            Assert.Equal(1, db.Users.Count());
        }

        [Fact]
        public void Review_Add_One_Entity()
        {
            TartarusContext db = GenerateDb();
            Review newReview = new Review(100, "Schlecht", 2,new DateTime(2002,10,19),Status.Old) ;

            db.Reviews.Add(newReview);
            db.SaveChanges();

            Assert.Equal(1, db.Reviews.Count());
        }

    }
}
