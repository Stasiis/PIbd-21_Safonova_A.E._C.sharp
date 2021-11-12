using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsPlanes;

namespace Stormtrooper_21var_Saf
{
    public class ParkingCollection
    {
        public readonly Dictionary<string, Parking<Vehicle>> parkingStages;
        public List<string> Keys => parkingStages.Keys.ToList();
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        public void AddParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                return;
            }
            parkingStages.Add(name, new Parking<Vehicle>(pictureHeight, pictureWidth));
        }
        /// <summary>
        /// Удаление ангара
        /// </summary>
        /// <param name="name">Название ангара</param>
        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }
        /// <summary>
        /// Доступ к ангару
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Parking<Vehicle> this[string ind]
        {
            get
            {
                if (parkingStages.ContainsKey(ind))
                {
                    return parkingStages[ind];
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
