using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Television : IElectronicDevice
    {

        private int _volume = 30;

        public int Volume
        {
            get
            {
                return _volume;
            }
            set
            {
                _volume = value;
            }
        }

        public string Brand { get; set; }

        public Television(string brand = "No Brand")
        {
            Brand = brand; 
        }

        public void ChangeBatery()
        {
            Console.WriteLine($"Changeing the Battery for {Brand}");
        }

        public void Off()
        {
            Console.WriteLine($"The {Brand} TV is Powering Off");
        }

        public void On()
        {
            Console.WriteLine($"The {Brand} TV is Powering On");
        }

        public void VolumeDown()
        {
            if (Volume != 0)
            {
                Volume--;
                Console.WriteLine($"The Volume is at {Volume}");
            }
            else if (Volume == 0)
            {
                Console.WriteLine($"The Volume can't be turned Down Anymore. Volue at: {Volume}");
            }
        }

        public void VolumeUp()
        {
            if (Volume != 100)
            {
                Volume++;
                Console.WriteLine($"The Volume is at {Volume}");
            }
            else if (Volume == 100)
            {
                Console.WriteLine($"The Volume can't be turned Up Anymore. Volue at: {Volume}");

            }
        }

       
    }
}
