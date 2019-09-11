using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace phoneStore_Factory_Method
{
    public abstract class Device
    {
        public abstract string PhoneType { get; }   
        public abstract string OS { get; }
        public abstract double Width { get; set; }
        public abstract double Height { get; set; }
        public abstract ArrayList Additions { get; set; }

        public void GetSpecs()
        {
            Console.WriteLine("Type: " + PhoneType);
            Console.WriteLine("OS: " + OS);

            String additions = null;

            foreach (var addition in Additions)
            {
                if (Additions[0] != addition)
                {
                    additions += ", ";
                }
                    
                additions += addition.ToString();
            }

            Console.WriteLine("Additions: " + additions);
        }

        public virtual void GetInches()
        {
            Console.WriteLine("Screen: " + Math.Round(Math.Sqrt((Width * Width) + (Height * Height)), 2) + " inches");
        }
    }
}
