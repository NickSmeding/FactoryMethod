using System;
using System.Collections;

namespace phoneStore_Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            GetPhoneInfo();
            Console.ReadKey();
        }

        public static void GetPhoneInfo()
        {
            DeviceFactory factory = null;

            Console.Write("Enter the brand you would like to visit: ");
            string brand = Console.ReadLine();

            switch (brand.ToLower())
            {
                case "samsung":
                    factory = new SamsungFactory(2, 7, new ArrayList() { "camera", "fingerprint" });
                    break;
                case "apple":
                    factory = new AppleFactory(3, 7, new ArrayList() { "camera" });
                    break;
                case "...":

                default:
                    break;
            }

            if (factory != null)
            {
                Console.Write("Enter the type you would like to see: ");
                string device = Console.ReadLine();

                switch (device.ToLower())
                {
                    case "phone":
                        Device phone = factory.CreatePhone();
                        phone.GetSpecs();
                        phone.GetInches();
                        break;
                    case "tablet":
                        Device tablet = factory.CreateTablet();
                        tablet.GetSpecs();
                        tablet.GetInches();
                        break;
                    case "...":

                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("this phone doesn't exsist, Try again!");
                GetPhoneInfo();
            }
        }
    }
}
