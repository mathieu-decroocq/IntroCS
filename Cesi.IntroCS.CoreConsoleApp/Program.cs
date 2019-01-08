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

            using (GenericDal<Post> dal = new GenericDal<Post>())
            {
                List<Post> posts = dal.Find(p => p.Content.Contains("Test"));

                foreach (Post post in posts)
                {
                    Console.WriteLine($"Id : {post.Id} Titre : {post.Title}");
                }
            }
      

            // AddPost();

            // UpdateBlogUrl();

            // DeleteLastPost();

            // ReadAll();

            Console.ReadLine();
        }


        private static void AddPost()
        {
            using (var context = new BloggingContext())
            {
                var post = new Post { Title = "Post du jour", Content = "Du contenu", BlogId = 1 };
                context.Posts.Add(post);
                context.SaveChanges();
            }
        }

        private static void UpdateBlogUrl()
        {
            //using (var context = new BloggingContext())
            //{
            //    var blog = context.Blogs.First();
            //    blog.Url = "http://sample.com/blog";
            //    context.SaveChanges();
            //}
        }

        private static void DeleteLastPost()
        {
            using (var context = new BloggingContext())
            {
                var post = context.Posts.Last();
                context.Posts.Remove(post);
                context.SaveChanges();
            }
        }

        private static void ReadAll()
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
        }

        private static void UpdateWithDAL()
        {
            var postDAL = new PostDAL();
            postDAL.Update(new Post { Id = 2, Title = "Post 2 up", Content = "Du contenu", BlogId = 1 });
        }
    }
}
