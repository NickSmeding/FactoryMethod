using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace phoneStore_Factory_Method
{
    public class AppleFactory : DeviceFactory
    {
        private string _name;

        public AppleFactory(String name)
        {
            _name = name;
        }

        public override Device CreatePhone(double width, double height, ArrayList additions)
        {
            return new ApplePhone(width, height, additions, _name);
        }

        public override Device CreateTablet(double width, double height, ArrayList additions)
        {
            return new AppleTablet(width, height, additions, _name);
        }
    }
}
