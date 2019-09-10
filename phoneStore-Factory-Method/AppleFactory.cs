using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace phoneStore_Factory_Method
{
    class AppleFactory : PhoneFactory
    {
        private double _width;
        private double _height;
        private ArrayList _additions;

        public AppleFactory(double width, double height, ArrayList additions)
        {
            _width = width;
            _height = height;
            _additions = additions;
        }

        public override Phone GetPhone()
        {
            return new ApplePhone(_width, _height, _additions);
        }
    }
}
