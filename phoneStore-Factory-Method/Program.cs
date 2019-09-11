using System;
using System.Collections;

namespace phoneStore_Factory_Method
{
    public class Program
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
                    factory = new SamsungFactory("Samsung");
                    break;
                case "apple":
                    factory = new AppleFactory("Apple");
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
                        Device phone = factory.CreatePhone(2, 7, new ArrayList() { "camera", "fingerprint" });
                        phone.GetSpecs();
                        phone.GetInches();
                        break;
                    case "tablet":
                        Device tablet = factory.CreateTablet(14, 6, new ArrayList() { "camera", "fingerprint" });
                        tablet.GetSpecs();
                        tablet.GetInches();
                        break;
                    case "...":

                    default:
                        Console.WriteLine("this device doesn't exsist, Try again!");
                        GetPhoneInfo();
                        break;
                }
            }
            else
            {
                Console.WriteLine("this factory doesn't exsist, Try again!");
                GetPhoneInfo();
            }
        }
    }
}
