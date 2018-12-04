using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Radio : IElectronicDevice
    {
        private int _volume;

        public string Brand { get; set; }

        public void ChangeBatery()
        {
           
        }

        public void ChangeProgramm()
        {
            throw new NotImplementedException();
        }

        public void Off()
        {
            
        }

        public void On()
        {
            
        }

        public void VolumeDown()
        {
            _volume--;
            Console.WriteLine(_volume);
        }

        public void VolumeUp()
        {
            _volume++;
            Console.WriteLine(_volume);
        }
    }
}
