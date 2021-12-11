using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsParking
{
    public class HangarNotFoundException: Exception
    {
        public HangarNotFoundException(int i) : base("Не найден самолет по месту "+ i)
        { }
    }
}
