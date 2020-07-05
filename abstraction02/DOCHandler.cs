using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction02
{
    class DOCHandler : AbstractHandler
    {
        public readonly string type = "DOC";
        public override void Chenge()
        {
            Console.WriteLine("DOC chenge");
        }

        public override void Create()
        {
            Console.WriteLine("DOC Create");
        }

        public override void Open()
        {
            Console.WriteLine("DOC Opened");
        }

        public override void Save()
        {
            Console.WriteLine("DOC Saved");
        }
    }
}
