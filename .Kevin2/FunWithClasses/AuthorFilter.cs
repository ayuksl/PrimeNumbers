using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithClasses
{
    internal class AuthorFilter : IBookSampleFilter
    {
        public string Author { get; set; }



        public AuthorFilter(string author)

        {
            
            this.Author = author;
        }

        public bool Matches(BookSample sample)
        {

            foreach (string e in sample.Authors)
            {
                if (e.Equals(this.Author, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }

   
            }
            return false;
        }
    }
}
