using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal interface IMessage
    {
        public string Serialize();
        public void Deserialize(string data);
    }
}
