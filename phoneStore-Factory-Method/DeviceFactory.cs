using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace phoneStore_Factory_Method
{
    public abstract class DeviceFactory
    {
        public abstract Device CreatePhone(double width, double height, ArrayList additions);
        public abstract Device CreateTablet(double width, double height, ArrayList additions);
    }
}
