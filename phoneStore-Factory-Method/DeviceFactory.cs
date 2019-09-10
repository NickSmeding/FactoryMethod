using System;
using System.Collections.Generic;
using System.Text;

namespace phoneStore_Factory_Method
{
    abstract class DeviceFactory
    {
        public abstract Device CreatePhone();
        public abstract Device CreateTablet();
    }
}
