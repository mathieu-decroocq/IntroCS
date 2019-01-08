using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Cesi.IntroCS.GotSDK
{
    public class GotClient
    {
        private HttpClient client;
        public GotClient()
        {
            client = new HttpClient
            {
                BaseAddress = new Uri("https://www.anapioficeandfire.com/api")
            };
        }

        public async Task<IList<Book>> GetBooks()
        {
            string booksJson = await client.GetStringAsync("/books");
            return JsonConvert.DeserializeObject<List<Book>>(booksJson);
        }

        public async Task<IList<Book>> FindBook(Func<Book, bool> findExpression)
        {
            IList<Book> books = await GetBooks();
            return books.Where(findExpression).ToList();
        }
    }

    public class Book : IBook
    {
        public string Url { get; set; }
        public string Name { get; set; }
        public string Isbn { get; set; }
        public List<string> Authors { get; set; }
        public int NumberOfPages { get; set; }
        public string Publisher { get; set; }
        public string Country { get; set; }
        public string MediaType { get; set; }
        public DateTime Released { get; set; }
        public List<string> Characters { get; set; }
        public List<string> PovCharacters { get; set; }


        private string name;

        public void ClearAuthors()
        {
            throw new NotImplementedException();
        }
    }

    public interface IBook
    {
        string Url { get; set; }

        void ClearAuthors();
    } 
}
