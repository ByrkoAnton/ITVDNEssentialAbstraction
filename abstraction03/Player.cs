using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace abstraction03
{
    class Player : IPlayable, IRecodable
    {
        public void Pause()
        {
            Console.WriteLine("IPlayable pause"); 
        }
        void IRecodable.Pause()
        {
            Console.WriteLine("Ircordable pause"); //для разнообразия переопределил
        }

        public void Play()
        {
            Console.WriteLine("play");
        }

        public void Record()
        {
            Console.WriteLine("rec");
        }

        public void Stop()
        {
            Console.WriteLine("stop");
        }
    }
}
