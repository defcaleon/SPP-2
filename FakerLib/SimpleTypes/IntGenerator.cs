using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerLib.Types
{
    class IntGenerator : ISimpleTypeGenerator
    {
        public Type type => typeof(int);

        public object Create()
        {
            return new Random().Next();
        }
    }
}
