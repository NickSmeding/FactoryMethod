using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace phoneStore_Factory_Method
{
    class SamsungFactory : DeviceFactory
    {
        private double _width;
        private double _height;
        private ArrayList _additions;

        public SamsungFactory(double width, double height, ArrayList additions)
        {
            _width = width;
            _height = height;
            _additions = additions;
        }

        public override Device CreatePhone()
        {
            return new SamsungPhone(_width, _height, _additions);
        }

        public override Device CreateTablet()
        {
            return new SamsungTablet(_width, _height, _additions);
        }
    }
}
