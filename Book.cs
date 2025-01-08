using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrary
{
    internal class Book :LibraryItem
    {
        private string Author { get; set; }
        private string Genre { get; set; }
        private int pages { get; set; }

        public Book(string title, DateOnly year, string author, string genre, int pages) : base(title, year)
        {
            this.Author = author;
            this.Genre = genre; 
            this.pages = pages; 
            
        }

        public override string DisplayDetails()
        {
            return $"Book: {Title}, by : {Author}, {Year} ,Genre :{Genre},pages :{pages}";
        }

       
    }
}
