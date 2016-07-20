using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Day2ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Car c = new Car("Dodge", 5);
                c.Start(CarStartSound.Grind, 12);
            }
            catch (CarStartException xx)
            {
                Console.WriteLine(xx.ToString());
                Console.WriteLine("  Attempted {0} start, {1} times", xx.Sound, xx.NumTimes);
            }

        }
    }
}
