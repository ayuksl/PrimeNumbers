using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithClasses
{
    public class Rectangle
    {
        public double  Width;

        public double Height;

        public Rectangle()
        {

        }

        public void SetWidth(double value)
        {
            if (value > 0)
            {
                this.Width = value;

            }
            else
            {
                throw new ArgumentException("Width must be greater than zero.");
            }
        }

        public void SetHeight(double value)
        {
            if (value > 0)
            {
                this.Height = value;

            }
            else
            {
                throw new ArgumentException("Height must be greater than zero.");
            }
        }
        public double GetArea()
        {
            return this.Width * this.Height;
        }

        public double GetPerimeter()
        {
            return (2 * this.Width + 2 * this.Height);
        }
        public bool IsSquare() => (Width.Equals(Height));
    
        public void Describe()
        {
            Console.WriteLine("I am a rectangle; My Width is {1}; My height is {0}; My Area is {2}; My Diameter is {3}; IsSquare = {4}",
                this.Height, this.Width, this.GetArea(), this.GetPerimeter(), this.IsSquare() );

        }
    }




}



