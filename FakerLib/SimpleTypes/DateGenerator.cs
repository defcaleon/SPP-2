using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerLib.Types
{
    class DateGenerator : ISimpleTypeGenerator
    {

        public Type type => typeof(DateTime);

        public object Create()
        {
            var rnd = new Random();
            int milisecond = rnd.Next(0, 1000);
            int second = rnd.Next(0, 60);
            int minute = rnd.Next(0, 60);
            int hour = rnd.Next(0, 24);

            int year = rnd.Next(DateTime.MinValue.Year, DateTime.MaxValue.Year);
            int month = rnd.Next(1, 13);
            int day = rnd.Next(1, DateTime.DaysInMonth(year, month) + 1);

            return new DateTime(year, month, day, hour, minute, second, milisecond);
        }

    }
}
