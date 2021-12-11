using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stormtrooper_21var_Saf
{
    class HangarOccupiedPlaceException : Exception
    {
        public HangarOccupiedPlaceException() : base("Место занято")
        { }
    }
}
