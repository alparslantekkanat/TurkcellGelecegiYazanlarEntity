using GyEntity2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyEntity2.Data
{
    public class eticaretDbContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Blood> Bloods { get; set; }
        public DbSet<Gender> Genders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\Mssqllocaldb; Database=CloneDb; Integrated Security=yes");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().Property(x => x.Name)
                                           .IsRequired().HasMaxLength(50);


            modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired()
                                                    .HasMaxLength(250);
            modelBuilder.Entity<Product>().HasOne(p => p.Category)
                                    .WithMany(category => category.Products)
                                    .HasForeignKey(x => x.CategoryId)
                                    ;


            //modelBuilder.Entity<Cart>().HasOne(ccc => ccc.User)
            //                           .WithMany()
            //                           .HasForeignKey(x => x.ProductId)
            //                           .HasForeignKey(y => y.UserId)
            //                           ;


            modelBuilder.Entity<User>().Property(u => u.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<User>().Property(u => u.Surname).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<User>().HasOne(u => u.Gender)
                                       .WithMany()
                                       .HasForeignKey(u => u.GenderId);
            modelBuilder.Entity<User>().HasOne(u => u.Blood)
                                       .WithMany()
                                       .HasForeignKey(u => u.BloodId);
            modelBuilder.Entity<User>().HasOne(u => u.Country)
                                       .WithMany()
                                       .HasForeignKey(u => u.CountryId);

            modelBuilder.Entity<Country>().Property(co => co.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Blood>().Property(bl => bl.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Gender>().Property(ge => ge.Name).IsRequired().HasMaxLength(50);

            modelBuilder.Entity<Country>().HasData(new Country { Id = 1, Name = "Antalya" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 2, Name = "İstanbul" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 3, Name = "Zonguldak" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 4, Name = "İzmir" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 5, Name = "Ankara" });

            modelBuilder.Entity<Blood>().HasData(new Blood { Id = 1, Name = "A+" });
            modelBuilder.Entity<Blood>().HasData(new Blood { Id = 2, Name = "A-" });
            modelBuilder.Entity<Blood>().HasData(new Blood { Id = 3, Name = "B+" });
            modelBuilder.Entity<Blood>().HasData(new Blood { Id = 4, Name = "B-" });
            modelBuilder.Entity<Blood>().HasData(new Blood { Id = 5, Name = "AB+" });
            modelBuilder.Entity<Blood>().HasData(new Blood { Id = 6, Name = "AB-" });
            modelBuilder.Entity<Blood>().HasData(new Blood { Id = 7, Name = "0+" });
            modelBuilder.Entity<Blood>().HasData(new Blood { Id = 8, Name = "0-" });

            modelBuilder.Entity<Gender>().HasData(new Gender { Id = 1, Name = "Erkek" });
            modelBuilder.Entity<Gender>().HasData(new Gender { Id = 2, Name = "Kadın" });

            modelBuilder.Entity<User>().HasData(new User { Id = 1, Name = "Alparslan", Surname = "Tekkanat", FullName = "Alparslan Tekkanat", Mail = "tekkanatalp@gmail.com", BloodId = 8, CountryId = 1, GenderId = 1 });
            modelBuilder.Entity<User>().HasData(new User { Id = 2, Name = "Muammer", Surname = "Tekkanat", FullName = "Muammer Tekkanat", Mail = "tekkanatmuammer@gmail.com", BloodId = 4, CountryId = 5, GenderId = 1 });
            modelBuilder.Entity<User>().HasData(new User { Id = 3, Name = "Gizem Kübra", Surname = "Yaman", FullName = "Gizem Kübra Yaman", Mail = "gizemyaman@gmail.com", BloodId = 2, CountryId = 3, GenderId = 2 });

            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, Name = "Teknoloji" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, Name = "Moda" });

            //modelBuilder.Entity<Product>().HasData(new Product { Id = 1, Name = "Iphone13", Price = 30000, CategoryId = 1, Code = 0707 });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 2, Name = "Iphone12", Price = 25000, CategoryId = 1, Code = 0708 });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 3, Name = "Iphone11", Price = 20000, CategoryId = 1, Code = 0709 });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 4, Name = "Gömlek", Price = 1000, CategoryId = 2, Code = 6707 });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 4, Name = "Pantolon", Price = 1500, CategoryId = 2, Code = 6708 });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 4, Name = "Ayakkabı", Price = 5000, CategoryId = 2, Code = 6709 });

            //modelBuilder.Entity<Cart>().HasData(new Cart { Id = 1, ProductId = 1, UserId = 1, Quantity = 1 });
            //modelBuilder.Entity<Cart>().HasData(new Cart { Id = 2, ProductId = 2, UserId = 2, Quantity = 1 });
            //modelBuilder.Entity<Cart>().HasData(new Cart { Id = 3, ProductId = 3, UserId = 3, Quantity = 1 });
            //modelBuilder.Entity<Cart>().HasData(new Cart { Id = 4, ProductId = 4, UserId = 1, Quantity = 1 });
            //modelBuilder.Entity<Cart>().HasData(new Cart { Id = 2, ProductId = 5, UserId = 2, Quantity = 1 });
            //modelBuilder.Entity<Cart>().HasData(new Cart { Id = 3, ProductId = 6, UserId = 3, Quantity = 1 });


        }

    }
}
