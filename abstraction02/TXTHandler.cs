using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction02
{
    class TXTHandler : AbstractHandler
    {
        public readonly string type = "TXT";
        public override void Chenge()
        {
            Console.WriteLine("TXT chenge");
        }

        public override void Create()
        {
            Console.WriteLine("TXT Create");
        }

        public override void Open()
        {
            Console.WriteLine("TXT Opened");
        }

        public override void Save()
        {
            Console.WriteLine("TXT Saved");
        }
    }
}
