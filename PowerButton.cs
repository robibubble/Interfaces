using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class PowerButton : ICommand
    {

        IElectronicDevice device;

        public PowerButton(IElectronicDevice device)
        {
            this.device = device;
        }

        public void ChangeBatery()
        {
            device.ChangeBatery();
        }

        public void Start()
        {
            device.On();
        }

        public void Stop()
        {
            device.Off();
        }
    }
}
