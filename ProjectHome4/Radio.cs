using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHome4
{
    internal class Radio : IRemoteControl
    {
        private bool isOn;
        private int channel;
        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("Радіо увімкнено.");
        }
        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("Радіо вимкнено.");
        }
        public void SetChannel(int channel)
        {
            this.channel = channel;
            Console.WriteLine($"Радіо: встановлено частоту/канал {channel}.");
        }
    }
}
