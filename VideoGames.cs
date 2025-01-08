using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrary
{
    internal class VideoGames : LibraryItem
    {
        private string Publisher { get; set; }
        private string Platform { get; set; }   // ex Xbox , PC and Play Station

        public VideoGames(string title, DateOnly year , string Publisher , string Platform) : base(title, year)
        {
            this.Publisher = Publisher;
            this.Platform = Platform;   
        }

        public override string DisplayDetails()
        {
            return $"Video Games: {Title}, Publisher {Publisher}, Platform: {Platform} mins, Year: {base.Year} ";
        }
    }
}
