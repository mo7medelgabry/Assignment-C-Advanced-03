using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C__Advanced_03
{
    public class BookProcessor
    {
        public void ProcessBooks(Func<Book, string> bookDelegate)
        {
            List<Book> books = new List<Book>
            {
                new Book { ISBN = "1234567890", PublicationDate = DateTime.Now },
                new Book { ISBN = "0987654321", PublicationDate = DateTime.Now.AddYears(-1) }
            };

            foreach (var book in books)
            {
                string result = bookDelegate(book);
                Console.WriteLine(result);
            }
        }
    }
}
