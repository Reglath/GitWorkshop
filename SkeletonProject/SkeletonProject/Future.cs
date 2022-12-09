using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeletonProject
{
    public class Future
    {
        public void PrintHoroscope()
        {
            var text = "My horoscope sign is";
            var sign = "pisces";
            Console.WriteLine($"{text} {sign}.");
        }
    }
}
