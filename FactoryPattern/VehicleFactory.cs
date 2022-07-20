using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal static class VehicleFactory
    {
        public static IVehicle GetVehicle(int x)
        {
            
                switch (x)
                {
                    case 1:
                        return new Unicycle();
                    case 2:
                        return new Motorcycle();
                    case 3:
                        return new Slingshot();
                    case 4:
                        return new Car();
                    default:
                        return new Other();
                }

        }
    }
}
