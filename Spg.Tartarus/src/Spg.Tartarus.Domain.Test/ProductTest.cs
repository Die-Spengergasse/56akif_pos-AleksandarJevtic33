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
    }
}
