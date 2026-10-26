using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHome4
{
    internal class Television : IRemoteControl
    {
        private bool isOn;
        private int channel;
        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("Телевізор увімкнено.");
        }
        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("Телевізор вимкнено.");
        }
        public void SetChannel(int channel)
        {
            this.channel = channel;
            Console.WriteLine($"Телевізор: встановлено канал {channel}.");
        }
    }
}
