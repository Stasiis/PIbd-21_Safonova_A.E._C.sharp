using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsPlanes;

namespace Stormtrooper_21var_Saf
{
    public class HangarCollection
    {
        public readonly Dictionary<string, Hangar<Vehicle>> HangarStages;
        public List<string> Keys => HangarStages.Keys.ToList();
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        public HangarCollection(int pictureWidth, int pictureHeight)
        {
            HangarStages = new Dictionary<string, Hangar<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        public void AddHangar(string name)
        {
            if (HangarStages.ContainsKey(name))
            {
                return;
            }
            HangarStages.Add(name, new Hangar<Vehicle>(pictureHeight, pictureWidth));
        }
        public void DelHangar(string name)
        {
            if (HangarStages.ContainsKey(name))
            {
                HangarStages.Remove(name);
            }
        }
        public Hangar<Vehicle> this[string ind]
        {
            get
            {
                if (HangarStages.ContainsKey(ind))
                {
                    return HangarStages[ind];
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
