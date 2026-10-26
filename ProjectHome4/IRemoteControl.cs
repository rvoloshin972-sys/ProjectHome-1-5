using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHome4
{
    internal interface IRemoteControl
    {
        void TurnOn();
        void TurnOff();
        void SetChannel(int channel);
    }
}
