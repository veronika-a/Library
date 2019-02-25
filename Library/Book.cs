using System;

namespace Library
{
    class Book
    {
        public Guid id;
        public string title;
        public Author author;

        internal Author Author
        {
            get => default(Library.Author);
            set
            {
            }
        }
    }
}
