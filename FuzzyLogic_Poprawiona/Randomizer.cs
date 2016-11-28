using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic_Poprawiona
{
    class Randomizer
    {
        private static readonly Random getrandom = new Random();
        private static readonly object syncLock = new object();
        public static double GetRandomNumber(double min, double max)
        {
            lock (syncLock)
            { // synchronize
                return getrandom.NextDouble() * (max-min)+min;
            }
        }
    }
}
