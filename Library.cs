using System;
using System.Collections.Generic;

namespace Library
{
    class Library
    {
        public string name;
        static public List<Book> Books = new List<Book>();
        static public List<Reader> Readers = new List<Reader>();

        internal Book Book
        {
            get => default(Library.Book);
            set
            {
            }
        }

        internal Reader Reader
        {
            get => default(Library.Reader);
            set
            {
            }
        }
    }
}
