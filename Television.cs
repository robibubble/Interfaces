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
        private string _defaultProgramm = "ARD";

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
        public string DefaultProgramm { get; set; }

        public Television(string brand = "No Brand", string defaultProgramm = "ARD")
        {
            Brand = brand;
            DefaultProgramm = defaultProgramm;
        }

        public void ChangeProgramm()
        {
            Console.WriteLine("What Programm would you like to change to ?");
            string input = Console.ReadLine();
            DefaultProgramm = input;
            Console.WriteLine("Your are Watching ... {0}", input);
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
