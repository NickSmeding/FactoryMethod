using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace phoneStore_Factory_Method
{
    public class SamsungTablet : Device
    {
        private readonly string _phoneType;
        private readonly string _OS;
        private double _width;
        private double _height;
        private ArrayList _additions;

        public SamsungTablet(double width, double height, ArrayList additions, String name)
        {
            _phoneType = name;
            _OS = "Android";
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
