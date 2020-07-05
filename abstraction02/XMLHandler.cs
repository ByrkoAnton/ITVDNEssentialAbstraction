using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace abstraction02
{
    class XMLHandler : AbstractHandler
    {
        public readonly string type = "XML";
        public override void Chenge()
        {
            Console.WriteLine("XML chenge");
        }

        public override void Create()
        {
            Console.WriteLine("XML Create");
        }

        public override void Open()
        {
            Console.WriteLine("XML Opened");
        }

        public override void Save()
        {
            Console.WriteLine("XML Saved");
        }
    }
}
