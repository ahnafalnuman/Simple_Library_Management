using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrary
{
    internal class DVD :LibraryItem
    {
        private int Duration { get; set; }
        private string Director {  get; set; }

        public DVD(string title, DateOnly year, string director, int duration) : base(title, year)
        {
            Duration = duration;
            Director = director;    
        }

        public override string DisplayDetails()
        {
            return $"DVD: {Title}, Director {Director}, Duration: {Duration} mins, Year: {Year} ";

        }
        
    }
}
