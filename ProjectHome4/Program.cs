using System;
using System.Text;

namespace ProjectHome4
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            IRemoteControl tv = new Television();
            IRemoteControl radio = new Radio();

            Console.WriteLine(" КЕРУВАННЯ ТЕЛЕВІЗОРОМ ");
            tv.TurnOn();
            tv.SetChannel(5);
            tv.SetChannel(12);
            tv.TurnOff();

            Console.WriteLine("\n КЕРУВАННЯ РАДІО ");
            radio.TurnOn();
            radio.SetChannel(101);
            radio.SetChannel(99);
            radio.TurnOff();
        }
    }
}
