using Cesi.IntroCS.CoreDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cesi.IntroCS.CoreWebApp
{
    public class MyDependency : IDependency
    {
        BloggingContext context;
        public MyDependency(BloggingContext context)
        {
            this.context = context;
        }

        
        public Task WriteMessage(string msg)
        {
            Console.WriteLine(
                $"MyDependency.WriteMessage called. Message: {msg}");
            return Task.FromResult(0);
        }
    }
}
