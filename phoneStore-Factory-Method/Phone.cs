using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace phoneStore_Factory_Method
{
    abstract class Phone
    {
        public abstract string PhoneType { get; }   
        public abstract string OS { get; }
        public abstract int Width { get; set; }
        public abstract int Height { get; set; }
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
    }
}
