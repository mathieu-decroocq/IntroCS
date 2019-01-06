using Cesi.IntroCS.CoreDataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Cesi.IntroCS.CoreDataAccess
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> options)
            : base(options)
        {
        }

        public BloggingContext()
        {

        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;ConnectRetryCount=0");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasData(new Blog { Id = 1, Url = "http://sample.com" });
            modelBuilder.Entity<Post>().HasData(new Post { BlogId = 1, Id = 1, Title = "First post", Content = "Test 1" });
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
