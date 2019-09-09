using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace phoneStore_Factory_Method
{
    class SamsungFactory : PhoneFactory
    {
        private int _width;
        private int _height;
        private ArrayList _additions;

        public SamsungFactory(int width, int height, ArrayList additions)
        {
            _width = width;
            _height = height;
            _additions = additions;
        }

        public override Phone GetPhone()
        {
            return new SamsungPhone(_width, _height, _additions);
        }
    }
}
