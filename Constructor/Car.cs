using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Car
    {
        //attributes
        public double Price { get; set; }
        public string Model { get; set; }
        public double Height  { get; set; }
        public string Size { get; set; }
       public double Speed { get; set; }

        //method-> start, drive , stop
        public void CarStart()
        {
            Console.WriteLine("Your Car has started. Please Select Your Destination!");
        }

        //constructor {2}
        //default

        public Car() {
            this.Speed = 0;            
        }

        //overloading constructor -> Polyphormism Concept

        public Car(Double Price, string Model, double Height, string Size, double Speed)
        {
            this.Price = Price;
            this.Model = Model;
            this.Height = Height;
            this.Size = Size;
            this.Speed = Speed;
        }
    }   
}
