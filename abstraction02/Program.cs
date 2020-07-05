using System;
using System.Xml.Serialization;

namespace abstraction02
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler xML = new XMLHandler();
            xML.Create();
            xML.Open();
            xML.Chenge();
            xML.Save();

            Console.WriteLine(xML.GetType() + " document type");
        }
       
    }
}
