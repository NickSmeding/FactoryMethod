using NUnit.Framework;
using phoneStore_Factory_Method;
using System.Collections;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("phoneStore-Factory-Method")]

namespace Tests
{

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [TestCase(2, 7, null, "test")]
        public void OsTestSamsung(int w, int h, ArrayList add, string name)
        {
            DeviceFactory Factory = new SamsungFactory(name);
            var Phone = Factory.CreatePhone(w, h, add);

            var result = "Android";

            Assert.AreEqual(result, Phone.OS);
        }

        [TestCase(2, 7, null, "test")]
        public void OsTestApple(int w, int h, ArrayList add, string name)
        {
            DeviceFactory Factory = new AppleFactory(name);
            var Phone = Factory.CreatePhone(w, h, add);

            var result = "IOS";

            Assert.AreEqual(result, Phone.OS);
        }
    }
}