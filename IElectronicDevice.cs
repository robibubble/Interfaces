using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IElectronicDevice
    {
        
        string Brand { get; set; }
        bool isBroken { get; set; }
        void On();
        void Off();
        void ChangeBatery();
        void ChangeProgramm();
        void VolumeUp();
        void VolumeDown();
    }
}
