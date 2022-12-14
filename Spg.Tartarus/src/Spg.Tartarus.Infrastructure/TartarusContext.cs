using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Spg.Tartarus.Domain.Model;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Tartarus.Infrastructure
{
    // 1.Diese klasse muss von DbContext ableiten
    public class TartarusContext : DbContext
    {
        //2. die Tabellen der Datenbank als Properties auflisten

        public DbSet<User> Users => Set<User>();
        public DbSet<Shop> Shops => Set<Shop>();
        public DbSet<Review> Reviews => Set<Review>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Address> Addresss => Set<Address>();

        // 3. Constructor

        public TartarusContext()
        { }

        public TartarusContext(DbContextOptions options) 
            : base (options) // Wo ist meine Datnebank und wo kommt Sie her: connectionString der Base Klasse weitergeben
        { }

        
        //Zwei methoden on configuring oder on creating
        //4.Konfiguration vor DB erstellung
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // IST VIRTUAL deswegen Override
        {
            //Wenn schon eine Config dabei
            //if (!optionsBuilder.IsConfigured)
            //{
                optionsBuilder.UseSqlite("Data Source = Tartarus.db"); // Connection String von der Datenbank die ich nutzen will
            //}
        }
        // 5. Optionen während DB Erstellung
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //var x = new Product("", "", new[], new List<Category>, 1).GetType().GetProperties();
            //string pName = x[1].Name;
            //modelBuilder.Entity<Product>().ToTable("Prodikte"); Wollen wir nicht ändern
            //modelBuilder.Entity<Category>().HasKey(c => c.Id);
            //modelBuilder.Entity<Category>().Property(c=> c.Id).IsRequired();
            modelBuilder.Entity<Product>().HasKey(p => p.Name);
            modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired();
            modelBuilder.Entity<Shop>().HasKey(s => s.Url);
            modelBuilder.Entity<Shop>().Property(s => s.Url).IsRequired();
            modelBuilder.Entity<Address>().HasKey(a => a.Street);
            modelBuilder.Entity<Address>().Property(a => a.Street).IsRequired();


            //modelBuilder.Entity<Product>().HasMany(p => p.Categories); // Nice aber unnötig Convention oder Configuration

            //Value Object:
            //modelBuilder.Entity<Shop>().OwnsOne(s => s.Address);
            modelBuilder.Entity<Product>().OwnsOne(p => p.CategoryNavigation);
            //modelBuilder.Entity<User>().OwnsMany(u => u.Reviews);
            //modelBuilder.Entity<Review>().OwnsOne(r => r.WrittenByUser);
            //modelBuilder.Entity<Review>().OwnsOne(r => r.RelatedProduct);
            modelBuilder.Entity<Review>().OwnsOne(r => r.PostedShop);





        }

        public void Seed()
        {

            Randomizer.Seed = new Random(12330201);


            List<Address> addresses = new Faker<Address>().CustomInstantiator(f =>
            new Address
                (
                f.Address.StreetName(),
                f.Address.BuildingNumber(),
                f.Address.City(),
                f.Address.ZipCode()
                ))
            .Generate(100)
            .ToList();

            Addresss.AddRange(addresses);
            SaveChanges();

            

            //TODO für Alle Entities SEEDS machen
            List<User> users = new Faker<User>().CustomInstantiator(f => //Instanzieren des Users mit Faker
            new User(f.Random.Int(11_111, 99_999),
                f.Random.Enum<Genders>(), 
                f.Name.FirstName(),
                f.Name.LastName(),
                f.Internet.Email(),
                f.Date.Between(DateTime.Now.AddYears(-60), DateTime.Now.AddYears(-16)),
                f.Date.Between(DateTime.Now.AddYears(-10), DateTime.Now.AddYears(-2))
                )).Rules((f,c) =>
                {
                    if( c.Gender == Genders.Male)
                    {
                        c.FirtsName = f.Name.FirstName(Bogus.DataSets.Name.Gender.Male);
                    }
                    else
                    {
                        c.FirtsName = f.Name.FirstName(Bogus.DataSets.Name.Gender.Female);
                    }


                    c.Address = f.Random.ListItem(addresses);
                    
                })
                .Generate(20)
                .ToList();

            Users.AddRange(users);
            SaveChanges();

            //List<Review> reviews = new Faker<Review>().CustomInstantiator(
            //    f =>
            //    new Review(
            //        f.Random.Int(1, 2000),
            //        f.Name.FullName(),
            //        f.Random.Int(1, 5),
            //        f.Date.Between(new DateTime(2000, 10, 10), new DateTime(2022, 10, 10)),
            //        f.Random.Enum<Status>()
            //        )).Rules((f, r) =>
            //        {
            //            r.WrittenByUser = f.Random.ListItem(users);

            //        })
            //        .Generate(20)
            //        .ToList();
            //Reviews.AddRange(reviews);
            //SaveChanges();



           



            //List<Shop> shops = new Faker<Shop>().CustomInstantiator(
            //    f => 
            //    new Shop (
            //        f.Internet.Url(),
            //        f.Internet.DomainName(),
            //        f.Name.FullName()
                    
            //        ))
            //    .Rules((f, r) =>
            //    {

            //    })
        }

    }
}
