using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsPlanes;

namespace Stormtrooper_21var_Saf
{
    public class PlaneComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x.GetType().Name.Equals(nameof(Plane)) && y.GetType().Name.Equals(nameof(Stormtrooper)))
            {
                return -1;
            }
            else if (y.GetType().Name.Equals(nameof(Plane)) && x.GetType().Name.Equals(nameof(Stormtrooper)))
            {
                return 1;
            }
            return 0;
        }


        private int ComparerPlane(Plane x, Plane y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerStormtrooper(Stormtrooper x, Stormtrooper y)
        {
            var res = ComparerPlane(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Rockets != y.Rockets)
            {
                return x.Rockets.CompareTo(y.Rockets);
            }
            if (x.Window != y.Window)
            {
                return x.Window.CompareTo(y.Window);
            }
            return 0;
        }
    }
}
