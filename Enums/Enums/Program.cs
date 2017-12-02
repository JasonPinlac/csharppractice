using System;


namespace Enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 0,
        RegistgeredAirMail = 1,
        Express = 2,
    }

    class Program
    {
        static void Main(string[] args)
        {
            ShippingMethod myPreferedShippingMethod = ShippingMethod.Express;
            Console.WriteLine(myPreferedShippingMethod);

            int shippingMethodId = 0;
            Console.WriteLine((ShippingMethod)shippingMethodId);

            string anotherShippingMethod = "RegisteredAirMail";

            Console.WriteLine(Enum.Parse(typeof(ShippingMethod), anotherShippingMethod));

        }

    }
}
