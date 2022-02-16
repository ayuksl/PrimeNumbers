using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithClasses
{
    public class Address
    {

        public string Straße
        {
            set;

            get;


        }

        public string Hausnummer
        {
            set;

            get;


        }

        public string Wohnort
        {
            set;

            get;


        }

        public string Land
        {
            set;

            get;


        }

        // constructor.......................................
        public Address(string straße, string hausnummer, string wohnort, string land)
        {
            this.Straße = straße;
            this.Hausnummer = hausnummer;
            this.Wohnort = wohnort;
            this.Land = land;


        }
        //Alternative: bastan bos verir. Cok Cok önemli..............
        // public Address() : this("","","","")
        //{
        //}
        public Address( )
        {
            this.Straße = "Anger";
            this.Hausnummer = "1";
            this.Wohnort = "99085";
            this.Land = "Deutschland";
        }

        public void Describe()
        {
            Console.WriteLine("The street is {0};\nThe house number is {1};\nThe postcode is {2} and \nThe country is {3}",
                this.Straße, this.Hausnummer, this.Wohnort, this.Land);

        }
        //public void Describe()
        //{ "My street is {0}; My housenumber is {1}; My city is {2} and My country is {3}",
            //this.Address.Straße, this.Address.Hausnummer, this.Address.Wohnort, this.Address.Land);
        //}
    }
}
