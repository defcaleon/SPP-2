using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerLib.Types
{
    class BooleanGenerator : ISimpleTypeGenerator
    {
        public Type type => typeof(bool);

        public object Create()
        {
            return (new Random().Next(0, 2) == 1) ? true : false;
        }

    }
}
