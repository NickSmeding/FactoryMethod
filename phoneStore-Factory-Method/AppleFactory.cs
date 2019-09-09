using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace phoneStore_Factory_Method
{
    class AppleFactory : PhoneFactory
    {
        private int _width;
        private int _height;
        private ArrayList _additions;

        public AppleFactory(int width, int height, ArrayList additions)
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
