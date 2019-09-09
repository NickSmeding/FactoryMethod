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
            PhoneFactory factory = null;

            Console.Write("Enter the phone type you would like to visit: ");
            string phoneName = Console.ReadLine();

            switch (phoneName.ToLower())
            {
                case "samsung":
                    factory = new SamsungFactory(400, 300, new ArrayList() { "camera", "fingerprint" });
                    break;
                case "apple":
                    factory = new AppleFactory(400, 300, new ArrayList() { "camera" });
                    break;
                case "...":

                default:
                    break;
            }

            if (factory != null)
            {
                Phone phone = factory.GetPhone();
                phone.GetSpecs();
            }
            else
            {
                Console.WriteLine("this phone doesn't exsist, Try again!");
                GetPhoneInfo();
            }
        }
    }
}
