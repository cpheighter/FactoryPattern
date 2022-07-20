using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Other : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("A vehicle cant be made for the number you entered");
            
        }
        
    }
}
