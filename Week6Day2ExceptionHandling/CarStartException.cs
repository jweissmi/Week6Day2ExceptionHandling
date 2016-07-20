using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Day2ExceptionHandling
{
    public enum CarStartSound { Grind, Click, Screech };


    [Serializable]
    public class CarStartException : Exception
    {
        public CarStartException() { }
        public CarStartException(string message) : base(message) { }
        public CarStartException(string message, Exception inner) : base(message, inner) { }
        protected CarStartException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        public CarStartSound Sound { get; set; }
        public CarStartSound Start { get; set; }
        public int NumTimes { get; set; }



        public CarStartException(string message, CarStartSound sound, int numTimes, bool start)
                : base(message)
        {
            Sound = sound;
            NumTimes = numTimes;
        }
    }
}
