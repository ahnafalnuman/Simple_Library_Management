using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrary
{
    public abstract class LibraryItem
    {
        public string Title { get; private set; }
        protected DateOnly Year { get;  set; }
        public bool IsBorrowed { get;  set; }

        public LibraryItem(string title, DateOnly year  )
        {
            this.Title = title;
            this.Year = year;
            this.IsBorrowed = false;
        }

        public abstract string DisplayDetails();

    }

}
