using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction02
{
    abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Chenge();
        public abstract void Save();

        public string GetType()
        {
            string type = ToString();
            type = type.Substring(type.IndexOf('.') + 1, 3);

            return type;
        }
    }
}
