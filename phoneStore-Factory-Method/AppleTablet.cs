using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace phoneStore_Factory_Method
{
    class AppleTablet : Device
    {
        private readonly string _phoneType;
        private readonly string _OS;
        private double _width;
        private double _height;
        private ArrayList _additions;

        public AppleTablet(double width, double height, ArrayList additions)
        {
            _phoneType = "Samsung";
            _OS = "IOS";
            _additions = additions;
            _width = width;
            _height = height;
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

        public override double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public override double Height
        {
            get { return _height; }
            set { _height = value; }
        }
    }
}
