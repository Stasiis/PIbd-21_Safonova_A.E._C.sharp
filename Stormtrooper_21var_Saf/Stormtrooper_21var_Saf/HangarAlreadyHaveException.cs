using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsParking
{
    public class HangarAlreadyHaveException : Exception
    {
        public HangarAlreadyHaveException() : base("В ангаре уже есть такой самолетик")
        {
        }
    }
}
