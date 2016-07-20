using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Day2ExceptionHandling
{
    class Car
    {
        private string v1;
        private int v2;

        public Car(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        internal void Start(CarStartSound grind, int v)
        {
            throw new NotImplementedException();
        }
    }
}
