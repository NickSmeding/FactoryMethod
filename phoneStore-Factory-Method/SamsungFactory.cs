using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace phoneStore_Factory_Method
{
    public class SamsungFactory : DeviceFactory
    {
        private string _name;

        public SamsungFactory(String name)
        {
            _name = name;
        }

        public override Device CreatePhone(double width, double height, ArrayList additions)
        {
            return new SamsungPhone(width, height, additions, _name);
        }

        public override Device CreateTablet(double width, double height, ArrayList additions)
        {
            return new SamsungTablet(width, height, additions, _name);
        }
    }
}
