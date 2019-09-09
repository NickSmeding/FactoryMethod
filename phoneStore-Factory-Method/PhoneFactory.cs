using System;
using System.Collections.Generic;
using System.Text;

namespace phoneStore_Factory_Method
{
    abstract class PhoneFactory
    {
        public abstract Phone GetPhone();
    }
}
