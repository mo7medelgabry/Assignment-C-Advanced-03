using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C__Advanced_03
{
    public class BookList : List<Book>
    {
        public bool Exists(Predicate<Book> match)
        {
            foreach (var book in this)
            {
                if (match(book))
                {
                    return true;
                }
            }
            return false;
        }

        public Book Find(Predicate<Book> match)
        {
            foreach (var book in this)
            {
                if (match(book))
                {
                    return book;
                }
            }
            return null;
        }

        public List<Book> FindAll(Predicate<Book> match)
        {
            List<Book> foundBooks = new List<Book>();
            foreach (var book in this)
            {
                if (match(book))
                {
                    foundBooks.Add(book);
                }
            }
            return foundBooks;
        }

        public int FindIndex(Predicate<Book> match)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (match(this[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public Book FindLast(Predicate<Book> match)
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                if (match(this[i]))
                {
                    return this[i];
                }
            }
            return null;
        }

        public int FindLastIndex(Predicate<Book> match)
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                if (match(this[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public void ForEach(Action<Book> action)
        {
            foreach (var book in this)
            {
                action(book);
            }
        }

        public bool TrueForAll(Predicate<Book> match)
        {
            foreach (var book in this)
            {
                if (!match(book))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
