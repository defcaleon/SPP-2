using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerLib.Types
{
    class CharGenerator : ISimpleTypeGenerator
    {
        public Type type => typeof(char);

        public object Create()
        {
            var number = new Random().Next(1, 64);
            return (char)number;
        }

    }
}
