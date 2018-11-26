using System.Collections.Generic;

namespace Library
{
    class Author
    {

        public string name;
        public string surname;
        static public List<Book> Books = new List<Book>();

        internal Book Book
        {
            get => default(Library.Book);
            set
            {
            }
        }
    }
}
