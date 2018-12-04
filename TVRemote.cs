using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class TVRemote
    {
        public static IElectronicDevice GetDevice()
        {
            Console.WriteLine("What Brand is your Television ?");
            string brand = Console.ReadLine();

            return new Television(brand);
        }
    }
}
