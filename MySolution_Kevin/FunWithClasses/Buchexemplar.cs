using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithClasses
{
    //internal class Copy : Buchexemplar
    //{
    //private Buchexemplar book;

    //public Copy(Buchexemplar book)
    //{
    //this.book = book;
    //}
    //}
    internal class Buchexemplar
    {
        //public Buchexemplar copy
        //{
        //set; get; 
        //}
        public Guid ID
        {
            private set
            {

            }
            get
            {
                return ID;
            }
        }

        public string Titel
        {
            set;

            get;

        }

        public string[] Autoren
        {
            private set;

            get;

        }

        public int Seitenanzahl
        {
            set;

            get;

        }

        public string Sachgebiet
        {
            set;

            get;

        }

        public Medium Medium
        {

            set;


            get;

        }


        public string ISBN
        {

            set;


            get;

        }

        public Buchexemplar(Guid id, string titel, string[] autoren, int seitenanzahl, string sachgebiet,
            Medium medium, string isbn)
        {
            this.ID = Guid.NewGuid();
            this.Titel = titel;
            this.Autoren = autoren;
            this.Seitenanzahl = seitenanzahl;
            this.Sachgebiet = sachgebiet;
            this.Medium = medium;
            this.ISBN = isbn;


        }

        public Buchexemplar()
        {
            this.ID = new Guid();
            this.Titel = null;
            this.Autoren = new string[5];
            this.Seitenanzahl = 0;
            this.Sachgebiet = "";
            this.Medium = Medium.None;
            this.ISBN = "";

        }
        //public void Xcopy(Buchexemplar worth)
        //{
        //Buchexemplar xcp = new Buchexemplar();
        //xcp = worth;

        //}
        public Buchexemplar Copy()
        {
            Buchexemplar copy = new Buchexemplar(
                this.Titel, this.Seitenanzahl, this.Sachgebiet, this.ISBN, this.Medium, this.Autoren);
            return copy;
        }

       

            //Buchexemplar book = new Buchexemplar(
       

        //// Copy constructor
        //public static Buchexemplar Copy(Buchexemplar worth)
        //{
            //Buchexemplar obj = new Buchexemplar();
            //obj = worth;
        //}

        //public void Describe()
        //{
            //Console.WriteLine("My name is {0}; My birthdate is {1}; My nationality is {2} and My birthyear is {3}, {4} ",
                //this._Name, this.BirthDate, this.Nationality, this.BirthYear, this.Address);
            //this.Address.Describe();
            ////Console.WriteLine(this.Address);

        //}
        //public void AddrDescribe()
        //{
        //Console.WriteLine( "My street is {0}; My housenumber is {1}; My city is {2} and My country is {3}",
        //this.Address.Straße, this.Address.Hausnummer, this.Address.Wohnort, this.Address.Land);
        //}


    }



}

