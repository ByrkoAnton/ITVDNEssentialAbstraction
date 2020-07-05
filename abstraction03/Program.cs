using System;

namespace abstraction03
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            player.Play();
            player.Stop();
            player.Record();
            player.Pause();
            IRecodable player2 = player;
            player2.Pause();
            
        }
    }
}
