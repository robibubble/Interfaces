using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            IElectronicDevice TV = TVRemote.GetDevice();
            PowerButton powerButton = new PowerButton(TV);

            powerButton.Start();

            TV.VolumeUp();
            TV.VolumeUp();

            TV.ChangeBatery();

            TV.VolumeDown();
            TV.VolumeDown();

            powerButton.Stop();


            

        }
    }
}
