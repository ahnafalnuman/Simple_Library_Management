using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrary
{
    internal class Magazine :LibraryItem
    {
        private int Issue { get; set; }
        private string Publisher { get; set; }  

            public Magazine(string title, DateOnly year, string publisher, int issue) : base(title, year)
        {
            Issue = issue;
            Publisher = publisher;
        }

        public override string DisplayDetails()
        {
            return $"Magazine: {Title},Publisher:{Publisher},Issue: {Issue}, Year: {Year}";
        }
        
    }
}
