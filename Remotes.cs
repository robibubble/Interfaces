using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Remotes
    {
        public static IElectronicDevice GetTvRemote()
        {
            Console.WriteLine("What Brand is your Television ?");
            string brandTelevision = Console.ReadLine();

            return new Television(brandTelevision);
        }

        public static IElectronicDevice GetRadioRemote()
        {
            return new Radio();
        }


    }
}
