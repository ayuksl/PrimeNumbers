using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithClasses
{
    internal class BadBookLibrary

    {
        private Buchexemplar?[] bookCopies;
        public void AddBook(Buchexemplar bookCopy)
        {
            if (FindBook(bookCopy.ID) is not null)
            {
                return;
            }
            
            for(int i = 0; i < this.bookCopies.Length; i++)
            {
                if (this.bookCopies[i] is null)
                {
                    this.bookCopies[i] = bookCopy;
                    return;
                }
            }

            throw new Exception("No more capacity to store book"):
        }

        public void RemoveBook(Guid id)
        {
            for int i = 0; i < this.bookCopies.Length; ++i)
            { 
                if (bookCopies[i].ID == id)
                {
                    bookCopies[i] = null;
                }
            }

        }

        public Buchexemplar? FindBook(Guid bookID)
        {
            foreach (Buchexemplar? copy in this.bookCopies)
            {
                if (copy is null)
                { continue; }


                if (copy.ID == bookID)
                {
                    return copy;
                }

            }
            return null;
        }
        public Buchexemplar
                if (copy?.Titel.Equals(
                    title, StringComparison.OrdinalIgnoreCase))
                {
                    return copy;
                }
        public BadBookLibrary(int capacity)
        {
            this.bookCopies = new Buchexemplar[capacity];
        }


        //public Buchexemplar? findBook(string title)
        //{
        //    foreach (Buchexemplar copy in this.bookCopies)
        //    if (copy.Titel.Equals(
        //        titel, StringComparison.OrdinalIgnoreCase())
        //}
    }

}
