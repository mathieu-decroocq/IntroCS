using Cesi.IntroCS.CoreDataAccess;
using Cesi.IntroCS.CoreDataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cesi.IntroCS.CoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BloggingContext())
            {
                List<Blog> blogs = context.Blogs.Include(b => b.Posts).ToList();
                foreach (Blog item in blogs)
                {
                    Console.WriteLine(item.Url);
                    foreach (Post post in item.Posts)
                    {
                        Console.WriteLine($"Id : {post.Id} Titre : {post.Title}");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
