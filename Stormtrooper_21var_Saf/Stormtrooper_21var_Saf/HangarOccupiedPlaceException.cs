using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsParking
{
    class HangarOccupiedPlaceException : Exception
    {
        public HangarOccupiedPlaceException() : base("Место занято")
        { }
    }
}
