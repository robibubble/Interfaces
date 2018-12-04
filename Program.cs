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

            IElectronicDevice TV = Remotes.GetTvRemote();
            PowerButton powerButtonTv = new PowerButton(TV);

            IElectronicDevice Radio = Remotes.GetRadioRemote();
            PowerButton powerButtonRadio = new PowerButton(Radio);

            //powerButtonTv.Start();

            //TV.VolumeUp();
            //TV.VolumeUp();

            //TV.ChangeBatery();

            //TV.VolumeDown();
            //TV.VolumeDown();

            //powerButtonTv.Stop();

            if (TV.isBroken)
            {
                TV.ChangeProgramm();
            }
            else
            {
                TV.ChangeProgramm();
            }
           

           
       

            

        }
    }
}
