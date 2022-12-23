using Microsoft.EntityFrameworkCore;
using Spg.DomainLinQ.App.Infrastructure;
using Spg.DomainLinQ.App.Model;
namespace Spg.DomainLinQ.Domain.Test
{
    public class UnitTest1
    {
        
        
            private School2000Context GenerateDb()
            {
                DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
                optionsBuilder.UseSqlite("Data Source= School2000.db");

                School2000Context db = new School2000Context(optionsBuilder.Options);
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                return db;
            }

        [Fact]
        public void SeedDb()
        {
            School2000Context db = GenerateDb();
            db.Seed();
            Assert.True(true);
        }

        //[Fact]
        //public void Product_Add_OneEntity_SuccessTest()
        //{
        //    // AAA
        //    // 1. Arrange
        //    School2000Context db = GenerateDb();
        //    Exam newProduct = new Exam()
                

        //    // 2. Act
        //    db.Exams.Add(newProduct);
        //    db.SaveChanges();

        //    // 3. Assert
        //    Assert.Equal(1, db.Exams.Count());
        //}

    }
}