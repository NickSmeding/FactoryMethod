using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace phoneStore_Factory_Method
{
    class ApplePhone : Phone
    {
        private readonly string _phoneType;
        private readonly string _OS;
        private int _width;
        private int _height;
        private ArrayList _additions;

        public ApplePhone(int width, int height, ArrayList additions)
        {
            _phoneType = "Apple";
            _OS = "IOS";
            _width = width;
            _height = height;
            _additions = additions;
        }

        public override string PhoneType
        {
            get { return _phoneType; }
        }

        public override string OS
        {
            get { return _OS; }
        }

        public override ArrayList Additions
        {
            get { return _additions; }
            set { _additions = value; }
        }

        public override int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public override int Height
        {
            get { return _height; }
            set { _height = value; }
        }
    }
}
