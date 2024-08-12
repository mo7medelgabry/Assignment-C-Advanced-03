using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C__Advanced_03
{
    public class Book
    {
        public string ISBN { get; set; }
        public DateTime PublicationDate { get; set; }

        public string GetISBN()
        {
            return ISBN;
        }

        public string GetPublicationDate()
        {
            return PublicationDate.ToString("yyyy-MM-dd");
        }
    }

    public delegate string BookDelegate(Book book);
}
