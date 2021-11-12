using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerLib.Types
{
    class StringGenerator : ISimpleTypeGenerator
    {
        public Type type => typeof(string);

        public object Create()
        {
            var random = new Random(DateTime.Now.Millisecond);
            byte[] randomBytes = new byte[random.Next(30) + 1];
            random.NextBytes(randomBytes);
            return Convert.ToBase64String(randomBytes).Replace("=", "a");
        }
    }
}
