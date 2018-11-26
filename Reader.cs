using System;
using System.Collections.Generic;

namespace Library
{
    class Reader
    {
        public string name;
        public string surname;
        public string email;
        static public List<Hire> Hires = new List<Hire>();

        internal Hire Hire
        {
            get => default(Library.Hire);
            set
            {
            }
        }
    }
}
