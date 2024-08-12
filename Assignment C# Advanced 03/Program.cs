using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace Assignment_C__Advanced_03
{
    internal class Program
    {
        #region Part01 1-Creating a User-Defined Delegate

        public delegate string BookDelegate(Book book);

        #endregion

        static void Main(string[] args)
        {
            BookProcessor processor = new BookProcessor();
            #region Q1 B
            Func<Book, string> publicationDateDelegate = book => book.GetPublicationDate();
            processor.ProcessBooks(publicationDateDelegate);
            #endregion
            #region Q1 C
            Func<Book, string> isbnDelegate = book => book.GetISBN();
            processor.ProcessBooks(isbnDelegate);
            processor.ProcessBooks(delegate (Book book)
            {
                return book.GetISBN();
            });
            #endregion


            #region Q1 D
            processor.ProcessBooks(book => book.GetPublicationDate());
            #endregion


            BookList bookList = new BookList
            {
                new Book { ISBN = "1234567890", PublicationDate = DateTime.Now },
                new Book { ISBN = "0987654321", PublicationDate = DateTime.Now.AddYears(-1) }
            };
            #region Q2 1
            bool exists = bookList.Exists(book => book.ISBN == "1234567890");
            Console.WriteLine($"Book exists: {exists}");
            #endregion
            #region Q2 2
            Book foundBook = bookList.Find(book => book.ISBN == "1234567890");
            Console.WriteLine($"Found Book ISBN: {foundBook?.ISBN}");
            #endregion
            #region Q2 3
            List<Book> allBooks = bookList.FindAll(book => book.PublicationDate.Year == DateTime.Now.Year);
            Console.WriteLine($" published  year: {allBooks.Count}");
            #endregion
            #region Q2 4
            int index = bookList.FindIndex(book => book.ISBN == "1234567890");
            Console.WriteLine($"Index of book: {index}");
            #endregion
            #region Q2 5
            Book lastBook = bookList.FindLast(book => book.PublicationDate.Year == DateTime.Now.Year);
            Console.WriteLine($"Last published : {lastBook?.ISBN}");
            #endregion
            #region Q2 6
            int lastIndex = bookList.FindLastIndex(book => book.ISBN == "1234567890");
            Console.WriteLine($"Last index of book: {lastIndex}");
            #endregion
            #region Q2 7
            bookList.ForEach(book => Console.WriteLine($"Book ISBN: {book.ISBN}"));
            #endregion
            #region Q2 8
            bool allMatch = bookList.TrueForAll(book => book.PublicationDate.Year <= DateTime.Now.Year);
            Console.WriteLine($"All books published by this year: {allMatch}");
            #endregion
        }
    }
}
